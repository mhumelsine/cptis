using System.Reflection;
using FluentValidation;
using Serilog;

namespace Cptis.Api.Filters;
/// <summary>
/// Applies a validation filter to an endpoint to validate the incoming request prior
/// to handing control to the handling delegate.
/// 1. IValidator&lt;T&gt; must be registered in the DI container or failed to resolve dependency exception is expected.
/// 2. It was decided that this would be placed on each handler instead of global registration/discovery
/// so that developers could easily navigate to the validations that apply.
/// </summary>
/// <typeparam name="T"></typeparam>
public class ValidationFilter<T> : IEndpointFilter
	where T : class
{
	/// <summary>
	/// The validator that will be used to validate the model
	/// </summary>
	private readonly IValidator<T> _validator;

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="validator">Validator that will be used by the filter to validate incoming requests</param>
	public ValidationFilter(IValidator<T> validator)
	{
		_validator = validator;
	}

	/// <summary>
	/// Filter delegate
	/// </summary>
	/// <param name="context">Filter context</param>
	/// <param name="next">Next handler in the pipeline</param>
	/// <returns>
	/// 400 - BadRequest as ProblemDetails response when validation fails.
	/// Forwards to next handler when validation succeeds
	/// </returns>
	public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
	{
		var model = context.GetArgument<T>(0);

		var result = await _validator.ValidateAsync(model, context.HttpContext.RequestAborted);

		Log.Debug("Request {RequestID} validation filter passed: {validationFilter}",
			context.HttpContext.TraceIdentifier, result.IsValid);

		if (result.IsValid) return await next(context);

		return Results.ValidationProblem(result.ToDictionary());
	}
}

/// <summary>
/// Extensions for validation system
/// </summary>
public static class ValidationExtensions
{
	/// <summary>
	/// Discovers all implementations of AbstractValidator and registers the implementation
	/// with the DI container using a scoped lifetime.  Equivalent to calling:
	/// services.AddScoped&lt;IValidator&lt;T&gt;, ConcreteValidator&gt;(); 
	/// </summary>
	/// <param name="services"></param>
	/// <param name="anchorType"></param>
	/// <returns></returns>
	public static IServiceCollection DiscoverValidators(this IServiceCollection services, Type anchorType)
	{
		Assembly
			.GetAssembly(anchorType)?
			.GetTypes()
			.Where(type => type.BaseType is { IsGenericType: true } && type.BaseType.GetGenericTypeDefinition() == typeof(AbstractValidator<>))
			.ToList()
			.ForEach(type =>
			{
				var abstractType = typeof(IValidator<>).MakeGenericType(type.BaseType!.GenericTypeArguments);

				services.AddScoped(abstractType, type);
			});

		return services;
	}

	/// <summary>
	/// Registers an endpoint filter that will validate T
	/// on the incoming request.  If validation fails, problem details 400 - Bad Request
	/// will be returned.  Otherwise, control will be passed to next handler
	/// </summary>
	/// <param name="builder">The route builder</param>
	/// <typeparam name="T">The model type to validate</typeparam>
	/// <returns>The builder</returns>
	public static RouteHandlerBuilder Validate<T>(this RouteHandlerBuilder builder)
		where T : class
		=> builder.AddEndpointFilter<ValidationFilter<T>>();
}
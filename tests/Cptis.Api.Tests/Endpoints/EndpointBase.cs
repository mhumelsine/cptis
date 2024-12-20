using System.Net.Http.Json;
using Cptis.Api.Tests.Setup;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Cptis.Api.Tests.Endpoints;

/// <summary>
/// Base class for endpoint tests.  Handles setup of HttpClient that can be used to run integration tests
/// </summary>
public class EndpointBase
{
    private ApplicationFactory? _factory;
    protected HttpClient? Client;
    protected JsonOptions JsonOptions;

    /// <summary>
    /// Execute setup tasks that should be done before all tests are run
    /// </summary>
    [OneTimeSetUp]
    public void Setup()
    {
       _factory = new ApplicationFactory();

        // This line is magic, it makes the "Unhandled Exception" in the API application buble through
        // to our unit test, allowing the result of the Assert to show us what the Exception in API was!
        _factory.Server.PreserveExecutionContext = true;

        Client = _factory.CreateClient();
        JsonOptions = _factory.Services.GetRequiredService<IOptions<JsonOptions>>().Value;
    }

    /// <summary>
    /// Execute tear down tasks that will run after all tests complete
    /// </summary>
    [OneTimeTearDown]
    public void Teardown()
    {
        Client?.Dispose();
        _factory?.Dispose();
    }

    /// <summary>
    /// Helper method to save a few lines parsing the json responses from the API
    /// </summary>
    /// <param name="response">HttpResponseMessage</param>
    /// <typeparam name="T">Expected Model type</typeparam>
    /// <returns>Awaitable possible null model</returns>
    protected Task<T?> ReadResponseAsync<T>(HttpResponseMessage response)
        => response.Content.ReadFromJsonAsync<T>(JsonOptions.SerializerOptions);
}
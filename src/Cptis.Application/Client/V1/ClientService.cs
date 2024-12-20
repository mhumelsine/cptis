
namespace Cptis.Application.Client.V1;

/// <summary>
/// Application service that handles the write operations (commands) for the client
/// </summary>
public class ClientService
{
    /// <summary>
    /// Creates a client using version 1 of the CreateClient command
    /// </summary>
    /// <param name="command">The command</param>
    /// <param name="cancel">A token to abort the request</param>
    /// <returns>A Client instance after it has been created</returns>
    public async Task<Core.Client> Execute(V1.CreateClient command, CancellationToken cancel)
    {
        var client = new Core.Client(
            id: command.ClientId,
            name: command.Name,
            birthDate: command.BirthDate
        );
        
        await Task.CompletedTask;
        
        return client;
    }
}
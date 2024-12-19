
namespace Cptis.Application.Client.V1;

public class ClientService
{
    public async Task<Core.Client> Execute(V1.CreateClient command, CancellationToken cancel)
    {
        var client = new Core.Client();
        
        await Task.CompletedTask;
        
        return client;
    }
}
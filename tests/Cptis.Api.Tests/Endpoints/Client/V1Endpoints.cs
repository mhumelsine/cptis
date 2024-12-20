using System.Net;

namespace Cptis.Api.Tests.Endpoints.Client;

/// <summary>
/// Tests for the V1 endpoints
/// </summary>
[TestFixture]
public class V1Endpoints : EndpointBase
{
    /// <summary>
    /// Expect 404 for invalid client keys
    /// </summary>
    /// <param name="clientKey">Unique client identifier</param>
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(int.MinValue)]
    public async Task Returns_404_For_Invalid_ClientKey(int clientKey)
    {
        //arrange
        //act
        var response = await Client!.GetAsync($"v1/client/{clientKey}");
        
        //assert
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
    }
}
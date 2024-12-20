using Cptis.Core;

namespace Cptis.Application.Client.V1;

/// <summary>
/// Version 1 of the CreateClient command.  Represents all the data required to create a client
/// </summary>
/// <param name="ClientId">The ID of the client</param>
/// <param name="Address">The current address of the client</param>
/// <param name="Name">The Name of the client</param>
/// <param name="BirthDate">The birthdate of the client</param>
public record CreateClient(
    ClientId ClientId, 
    Address Address, 
    Name Name, 
    BirthDate BirthDate
);
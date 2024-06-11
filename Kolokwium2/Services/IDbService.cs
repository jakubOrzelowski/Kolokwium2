using Kolokwium2.Models;

namespace Kolokwium2.Services;

public interface IDbService
{
    Task<Characters> GetCharacterById(int characterId);
}
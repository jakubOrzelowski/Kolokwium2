using Kolokwium2.DTOs;

namespace Kolokwium2.Services;

public interface IDbService
{
    Task<CharacterDto> GetCharacter(int characterId);
}
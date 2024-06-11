using Kolokwium2.Data;
using Kolokwium2.DTOs;

namespace Kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<CharacterDto> GetCharacter(int characterId)
    {
        return new CharacterDto
        {
        };
    }
}
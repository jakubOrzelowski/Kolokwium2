using Kolokwium2.Data;
using Kolokwium2.Models;

namespace Kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public Task<Characters> GetCharacterById(int characterId)
    {
        throw new NotImplementedException();
    }
}
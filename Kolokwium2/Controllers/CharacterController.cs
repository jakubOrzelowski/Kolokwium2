using Kolokwium2.Data;
using Kolokwium2.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{
    private readonly DatabaseContext _context;

    public CharacterController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet("{characterId}")]
    public async Task<IActionResult> GetCharacter(int characterId)
    {
        
        return Ok();
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;

[Table("Character_Titles")]
[PrimaryKey(nameof(CharacterId), nameof(TitlesId))]
public class Backpacks
{
    public int CharacterId { get; set; }
    public int TitlesId { get; set; }
    public DateTime AcquiredAt { get; set; }

    [ForeignKey(nameof(CharacterId))]
    public Characters Characters { get; set; } = null!;
    [ForeignKey(nameof(TitlesId))]
    public Titles Titles { get; set; } = null!;
}
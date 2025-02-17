using System.ComponentModel.DataAnnotations;

namespace FrostgravyTrain.Host;

public class Warband
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string WarbandName { get; set; }
    [Required]
    public Wizard Wizard { get; set; }
    [Required]
    public Apprentice Apprentice { get; set; }
    [Required]
    public IEnumerable<Soldier> Soldiers { get; set; }
    [Required]
    public HomeBase HomeBase { get; set; }
    [Required]
    public List<Items> Vault { get; set; }
    [Required]
    public int Treasury { get; set; }
}
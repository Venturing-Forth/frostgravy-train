using System.ComponentModel.DataAnnotations;

namespace FrostgravyTrain.Host;

public class Wizard
{
    [Required]
    public string WizardName { get; set; }
    [Required]
    public int Level { get; set; }
    [Required]
    public int Experience { get; set; }
    [Required]
    public WizardSchool School { get; set; }
    [Required]
    public Stats Stats { get; set; }
    [Required]
    public List<Spell> Spells { get; set; }
    public List<Item> ItemSlots { get; set; }
    public List<PermanentInjury> PermanentInjuries { get; set; }
    public List<string> Notes { get; set; }
}
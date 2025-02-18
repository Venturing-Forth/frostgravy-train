using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FrostgravyTrain.Host;

public class Item
{
    [Required]
    public string Name { get; set; }
}

public class GeneralArms : Item
{
    public int DamageModifier { get; set; }
    public int MaximumRange { get; set; }
    public string Notes { get; set; }
}

public class GeneralArmour : Item
{
    public int ArmourModifier { get; set; }
    public string Notes { get; set; }
}

public class Potions : Item
{
    public string Description { get; set; }
    public PotionGrade Grade { get; set; }
    public int PurchasePrice { get; set; }
    public int SalePrice { get; set; }
    public int IngredientCost { get; set; }
    public SourceBook SourceBook { get; set; }
}

public class MagicWeaponsAndArmour : Item
{
    public MagicEffects Effect { get; set; }
    public int PurchasePrice { get; set; }
    public int SalePrice { get; set; }
    public SourceBook SourceBook { get; set; }
}

public class MagicItems : Item
{
    public string Description { get; set; }
    public int PurchasePrice { get; set; }
    public int SalePrice { get; set; }
    public SourceBook SourceBook { get; set; }
}

public enum PotionGrade
{
    Lesser = 0,
    Greater = 1,
}

public enum SourceBook
{
    Core = 0,
}

public class MagicEffects
{
    public WizardStats ModifiedStat { get; set; }
    public int ModifierValue { get; set; }
    public string Notes { get; set; }
}
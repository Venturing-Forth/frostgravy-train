namespace FrostgravyTrain.Host;

public class Apprentice
{
    public string Name { get; set; }
    public Stats Stats { get; set; }
    public List<Item> ItemSlots { get; set; }
    public List<PermanentInjury> PermanentInjuries { get; set; }
    public string Notes { get; set; }
}
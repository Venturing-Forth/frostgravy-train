namespace FrostgravyTrain.Host;

public class Spell
{
    public int SpellId { get; set; }
    public string Name { get; set; }
    public School School { get; set; }
    public int BaseCastingNumber { get; set; }
    public List<SpellCategory> Category { get; set; }
    public string Description { get; set; }
}

public enum SpellCategory
{
    AreaEffect = 1,
    LineOfSight = 2,
    OutOfGameBefore = 3,
    OutOfGameAfter = 4,
    SelfOnly = 5,
    Touch = 6,
}
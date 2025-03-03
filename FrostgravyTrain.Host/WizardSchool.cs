namespace FrostgravyTrain.Host;

public class WizardSchool
{
    public School SchoolName { get; set; }
    public List<School> AlignedSchools { get; set; }
    public List<School> NeutralSchools { get; set; }
    public School OpposedSchool { get; set; }
}

public enum School
{
    Chronomancer = 1,
    Elementalist = 2,
    Enchanter = 3,
    Illusionist = 4,
    Necromancer = 5,
    Sigilist = 6,
    Soothsayer = 7,
    Summoner = 8,
    Thaumaturge = 9,
    Witch = 10,
}
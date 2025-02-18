namespace FrostgravyTrain.Host;

public class HomeBase
{
    public BaseLocation Location { get; set; }
    public List<BaseResource> Resources { get; set; }
}

/* REFACTOR NOTES: BaseLocation and BaseResources should be
 * implemented as their own classes rather than enums with
 * the associated data to go with them.
 */
public enum BaseLocation
{
    Inn = 1,
    Temple = 2,
    Crypt = 3,
    Tower = 4,
    Treasury = 5,
    Brewery = 6,
    Library = 7,
}

public enum BaseResource
{
    Kennel = 1,
    GiantCauldron = 2,
    EnchantersWorkshop = 3,
    CrystalBall = 4,
    Scriptorium = 5,
    CelestialTelescope = 6,
    SummoningCircle = 7,
    CarrierPigeons = 8,
    ArcaneCandle = 9,
    SummoningCandle = 10,
    SarcophagusOfHealing = 11,
}
﻿namespace FrostgravyTrain.Host;

public class Soldier
{
    public string Name { get; set; }
    public SoldierType Type { get; set; }
    public SoldierGrade Grade { get; set; }
    public Stats Stats { get; set; }
    public int Cost { get; set; }
    public Item ItemSlot { get; set; }
    public List<string> Notes { get; set; }
}
/* REFACTOR NOTES: Soldier Data should be derived from its own class rules,
 * rewrite to restructure the soldier type away from being an enum with
 * decoupled data.
 */
public enum SoldierType
{
    Thug = 1,
    Thief = 2,
    WarHound = 3,
    Infantryman = 4,
    ManAtArms = 5,
    Apothecary = 6,
    Archer = 7,
    Crossbowman = 8,
    TreasureHunter = 9,
    Tracker = 10,
    Knight = 11,
    Templar = 12,
    Ranger = 13,
    Barbarian = 14,
    Marksman = 15,
}

public enum SoldierGrade
{
    Standard = 1,
    Specialist = 2,
}
namespace NinthAgeCmsToArmyBook.UnitTests;

public class Unit
{
    public Unit(List<GlobalProfile> globalProfile, List<DefensiveProfile> defensiveProfile, List<OffensiveProfile> offensiveProfile, bool isMount)
    {
        GlobalProfile = globalProfile;
        DefensiveProfile = defensiveProfile;
        OffensiveProfile = offensiveProfile;
        IsMount = isMount;
    }
    
    public List<GlobalProfile> GlobalProfile { get; set; }
    public List<DefensiveProfile> DefensiveProfile { get; set; }
    public List<OffensiveProfile> OffensiveProfile { get; set; }
    public bool IsMount { get; set; }
}
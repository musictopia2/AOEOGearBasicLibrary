namespace AOEOGearBasicLibrary.Helpers;
public static class StarterGearClass
{
    public static string GetStarterGearName(string category, bool useLineOfSightGear)
    {
        if (category == "GearBldg")
        {
            return GetBuildingGear(useLineOfSightGear);
        }
        return GetStarterGearName(category);
    }
    private static string GetBuildingGear(bool  useLineOfSightGear)
    {
        if (useLineOfSightGear)
        {
            return "Gear_Bldg_LOS_R202";
        }
        return "Gear_Bldg_R202";
    }
    private static string GetStarterGearName(string category)
    {
        return category switch
        {
            "Swords1H" => "Sword1H_R202",
            "GreatAxe" => "Axe2H_R202",
            "Staffs2H" => "Staff2H_R202",
            "Sling" => "Sling2H_R202",
            "Arrows" => "ArrowOH_R202",
            "Shields" => "Shield1H_R202",
            "ArmorMed" => "ArmorMed_R202",
            "Scepter" => "Scepter2H_R202",
            "GearPriest" => "Gear_Prst_R202",
            "Spears1H" => "Spear1H_R202",
            "GearVill" => "Gear_Vill_R202",
            "Spears2H" => "Spear2H_R202",
            "ArmorLgt" => "ArmorLgt_R202",
            "Gear" => "Gear_R202",
            "ArmorCloth" => "ArmorClth_R202",
            "Bows" => "Bow1H_R202",
            "RamHeads" => "RamHead2H_R202",
            "ScoutSpecial1H" => "Scout1H_R202",
            "Javalins" => "Javalin2H_R202",
            "ArmorPlt" => "ArmorPlt_R202",
            "Tools" => "Tool1H_R202",
            "GearBoat" => "Gear_Boat_R202",
            "GearSiege" => "Gear_Siege_R202",
            "Merchant" => "Merchant2H_R202",
            "BallistaArms" => "Ballista2H_R202",
            "FishingNet" => "FishingNet1H_R202",
            "FireThrowers" => "FireThrower2H_R202",
            "Warpaint" => "Warpaint_R202",
            "Banner" => "Banner_R202",
            "BellyBows" => "BellyBow1H_R202",
            "Torc" => "Torc_R202",
            "War Horn" => "WarHorn_R202",
            "ArmorBuilding" => "ArmorBldg_R202",
            "Clubs2H" => "Club2H_R202",
            _ => throw new ArgumentOutOfRangeException(nameof(category), category, "Unknown starter gear category.")
        };
    }
}
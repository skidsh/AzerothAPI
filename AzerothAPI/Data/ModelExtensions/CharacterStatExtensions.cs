using AzerothAPI.Data.Models.Char;

namespace AzerothAPI.Data.ModelExtensions
{
    public static class CharacterStatExtensions
    {


        public static Dictionary<string, int> ToDictionary(this CharacterStat characterStats)
        {
            Dictionary<string, int> result = new();

            result.Add("Health", (int)characterStats.Maxhealth);
            result.Add("Mana", (int)characterStats.Maxpower1);
            result.Add("Rage", (int)characterStats.Maxpower2);
            result.Add("Focus", (int)characterStats.Maxpower3);
            result.Add("Energy", (int)characterStats.Maxpower4);
            result.Add("Runic Power", (int)characterStats.Maxpower7);
            result.Add("Strength", (int)characterStats.Strength);
            result.Add("Agility", (int)characterStats.Agility);
            result.Add("Stamina", (int)characterStats.Stamina);
            result.Add("Intellect", (int)characterStats.Intellect);
            result.Add("Spirit", (int)characterStats.Spirit);
            result.Add("Armor", (int)characterStats.Armor);
            result.Add("Resistance Holy", (int)characterStats.ResHoly);
            result.Add("Resistance Fire", (int)characterStats.ResFire);
            result.Add("Resistance Nature", (int)characterStats.ResNature);
            result.Add("Resistance Frost", (int)characterStats.ResFrost);
            result.Add("Resistance Shadow", (int)characterStats.ResShadow);
            result.Add("Resistance Arcane", (int)characterStats.ResArcane);
            result.Add("Block", (int)Math.Round(characterStats.BlockPct));
            result.Add("Dodge", (int)Math.Round(characterStats.DodgePct));
            result.Add("Parry", (int)Math.Round(characterStats.ParryPct));
            result.Add("Crit", (int)Math.Round(characterStats.CritPct));
            result.Add("Ranged Crit", (int)Math.Round(characterStats.RangedCritPct));
            result.Add("Spell Crit", (int)Math.Round(characterStats.SpellCritPct));
            result.Add("Attack Power", (int)characterStats.AttackPower);
            result.Add("Ranged Attack Power", (int)characterStats.RangedAttackPower);
            result.Add("Spell Power", (int)characterStats.SpellPower);
            result.Add("Resilience", (int)characterStats.Resilience);

            return result;
        }
}
}

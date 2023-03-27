namespace AzerothAPI.Data.DBC
{
    public class SpellItemEnchantment
    {
        public SpellItemEnchantment(int id, string name, int visual, int flags)
        {
            this.id = id;
            this.name = name;
            this.visual = visual;
            this.flags = flags;
        }
        public int id { get; set; }
        public string name { get; set; }
        public int visual { get; set; }
        public int flags { get; set; }
    }

    public static class SpellItemEnchantments
    {
        public static List<SpellItemEnchantment> data = new List<SpellItemEnchantment>();
    }
}

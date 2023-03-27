using AzerothAPI.Data.DBC;
using AzerothAPI.Dto.Char;

namespace AzerothAPI.DTO
{
    public partial class Item
    {
        public int Id { get; set; }
        public int DisplayId { get; set; }
        public int DisplaySlot { get; set; }
        public int EnchantVisual { get; set; }
        public int Slot { get; set; }
        public int Enchant { get; set; }
        public int Gem1 { get; set; }
        public int Gem2 { get; set; }
        public int Gem3 { get; set; }
        public int Transmog { get; set; }
        public List<int>? EquipedSetItems { get; set; }

        public bool IsWeapon()
        {
            return DisplaySlot == 21 || DisplaySlot == 22;
        }

        public void FindWeaponEnchantVisual()
        {
            if (IsWeapon())
            {
                if (Enchant > 0)
                {
                    var enchant = SpellItemEnchantments.data.Where(e => e.id == Enchant).FirstOrDefault();
                    if (enchant != null)
                    {
                        EnchantVisual = enchant.visual;
                    }
                }
            }
        }
    }
}

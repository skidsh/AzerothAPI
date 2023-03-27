namespace AzerothAPI.Data.DBC
{
    public class ItemDisplayInfo
    {
        public ItemDisplayInfo(int itemId, int itemAppearance, int itemAppMod, int order, int source, int displayId)
        {
            this.itemId = itemId;
            this.itemAppearance = itemAppearance;
            this.itemAppearanceMod = itemAppMod;
            this.order = order;
            this.source = source;
            this.displayId = displayId;
        }
        public int id { get; set; }
        public int itemId { get; set; }
        public int itemAppearance { get; set; }
        public int itemAppearanceMod { get; set; }
        public int order { get; set; }
        public int source { get; set; }
        public int displayId { get; set; }
    }

    public static class ItemDisplayInfos
    {
        public static List<ItemDisplayInfo> data = new List<ItemDisplayInfo>();
    }
}

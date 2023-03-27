using AzerothAPI.Data.DBC;

namespace AzerothAPI.Helpers
{
    public class CSVLoader
    {

        public static void LoadAll()
        {
            ItemDisplayInfos.data.Clear();
            ReadCSV(@"DBC/ItemDisplayInfo.csv", (values) => {
                ItemDisplayInfos.data.Add(new ItemDisplayInfo(
                                        int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]),
                                        int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
            });
            SpellItemEnchantments.data.Clear();
            ReadCSV(@"DBC/SpellItemEnchantment.csv", (values) => {
                SpellItemEnchantments.data.Add(new SpellItemEnchantment(
                                            int.Parse(values[0]), values[1], int.Parse(values[2]),
                                            int.Parse(values[3])));
            });
        }
        public static void ReadCSV(string csv_file, Action<string[]> callback)
        {
            using var reader = new StreamReader(csv_file);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(',');
                    try
                    {
                        callback(values);
                    }
                    catch { } // eat this and ignore values we don't like..
                }
            }
        }
    }
}

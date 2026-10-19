using System;
using System.Collections.Generic;
using System.Text;

namespace CITA255_Midterm
{
    public static class Cart
    {
        public static List<string> ItemNames { get; set; } = new List<string>();
        public static List<string> ItemPrices { get; set; } = new List<string>();
        public static List<string> ItemQuantities { get; set; } = new List<string>();

        public static Dictionary<string, int> GameInventory { get; set; } = new Dictionary<string, int>()
        {
            { "Gears of War E Day", 5 },
            { "Fallout New Vegas", 12 },
            { "Monster Hunter Wilds", 8 },
            { "Final Fantasy 7 Rebirth", 15 }
        };
    }
}

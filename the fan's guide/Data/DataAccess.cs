using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using the_fan_s_guide.Models;

namespace the_fan_s_guide.Data
{
    internal static class DataAccess
    {
        const string DATA_PATH = "SportBase.json";
        public static void Save(SportBase sportbase)
        { 
            string jsonString = JsonSerializer.Serialize(sportbase.Sportsmen);

            File.WriteAllText(DATA_PATH, jsonString);
            sportbase.Changed = false;
        }

        public static void Load(SportBase sportbase)
        {
            string jsonString = File.ReadAllText(DATA_PATH);

            var newSportsmen = JsonSerializer.Deserialize<List<Sportsman>>(jsonString);
            sportbase.Sportsmen.Clear();
            sportbase.Sportsmen.AddRange(newSportsmen);
            sportbase.Changed = false;
        }

    }
}

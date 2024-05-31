using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Star_Wars_Card_Game.Backend.Game
{
    public static class Classes
    {

        public static void LoadFromFile(string fileName)
        {
            Classes.ClassNames = MillerInc.Convert.Files.JSON_Converter.Deserialize<List<string>>(fileName);
        }

        public static void SaveToFile(string fileName)
        {
            System.IO.File.WriteAllText(fileName, Newtonsoft.Json.JsonConvert.SerializeObject(Classes.ClassNames));
                       
        }

        public static void SaveToFile()
        {
            System.IO.File.WriteAllText(Classes.FilePath, Newtonsoft.Json.JsonConvert.SerializeObject(Classes.ClassNames));
        }

        public static void LoadFromFile()
        {
            Classes.ClassNames = MillerInc.Convert.Files.JSON_Converter.Deserialize<List<string>>(Classes.FilePath);
        }

        public static void AddClass(string ClassName)
        {
            // Add a new class to the database
            if (!Classes.ClassNames.Contains(ClassName))
                Classes.ClassNames.Add(ClassName);
        }

        public static void RemoveClass(string ClassName)
        {
            // Remove a class from the database
            Classes.ClassNames.Remove(ClassName);
        }

        public static string FilePath { get; set; } = "Resources\\Classes.json";

        public static List<string> ClassNames { get; set; } = []; 
    }
}

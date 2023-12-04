using lab_1.Models.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class JSONworker
    {
        private string filePath = "D:/Programming/testing-app-csharp/lab_1/DataBase/data.json";
        private void CreateDB()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, "{}");
        }
        public void SaveTestToFile(Test test)
        {
            string json = JsonConvert.SerializeObject(test, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        public Test ReadData() {
            if (!File.Exists(filePath)) {
                CreateDB();
            }
            string jsonContent = System.IO.File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<dynamic>(jsonContent);
        }
        public void WriteData(Test data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Данные успешно записаны в файл {filePath}");
        }
    }
}

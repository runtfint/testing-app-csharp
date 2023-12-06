using lab_1.Models.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class JSONworker
    {
        private string filePath = "C:/Users/g220/Desktop/testing-app-csharp/lab_1/DataBase/data.json";
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
            string json = JsonConvert.SerializeObject(new Test[] {new Test() { Questions = new() { new Question() { QuestionText = "lolkek", Answers = new List<Answer>() { new Answer() { IsCorrect = true, Text ="kek" } } } } } }, Formatting.Indented);
            File.WriteAllText(filePath + "dd", json);
            string jsonContent = System.IO.File.ReadAllText(filePath + "dd");
            var r = JsonConvert.DeserializeObject<Test[]>(jsonContent);
            return r.First();
        }
        public void WriteData(Test data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Данные успешно записаны в файл {filePath}");
        }
    }
}

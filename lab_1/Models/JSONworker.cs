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
        public void SaveTestToFile(Test test)
        {
            string json = JsonConvert.SerializeObject(test, Formatting.Indented);
            File.WriteAllText("test.json", json);
        }
    }
}

using lab_1.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models
{
    public class CreateTestModel
    {
        public void CreateTest(Test test)
        {
            test.Questions.ForEach(question =>
            {
                Console.WriteLine(question);
            });
        }
    }
}

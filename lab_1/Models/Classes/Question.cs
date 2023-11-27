using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1.Models.Classes
{
    public class Question
    {
        public required string QuestionText { get; set; }
        public required List<Answer> Answers { get; set; }
    }
}

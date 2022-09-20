using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class UC1
    {
        public string Message;

        public UC1(string message)
        {
            this.Message = message;
        }

        public string Mood()
        {
            if (Message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}

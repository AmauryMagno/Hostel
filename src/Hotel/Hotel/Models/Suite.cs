using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    internal class Suite
    {
        public Suite(){ }
        public Suite(string suiteType, int capacity, decimal dailyValue)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            DailyValue = dailyValue;
        }

        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal DailyValue { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Salary
    {
        public int Rate { get; set; }
        public MonthOfYear Month { get; set; }
        public int Year { get; set; }

        public int NumberTax { get; set; }
        public override string ToString()
        {
            return string.Format($"Rate = {Rate}, Month = {Month.ToString()}\n" +
                $"Year = {Year}, Tax Number={NumberTax}");
        }
    }
}

using System;

namespace ClassLibrary
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NumberTax { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public DateTime DateOfStartWork { get; set; }

        public override string ToString()
        {
            return string.Format($"{Name} {Patronymic} {Surname} |" +
                $" {DateOfBirth.ToShortDateString()} | Tax Number={NumberTax} | Education={Education} | " +
                $"Profession={Profession} | Date of start={DateOfStartWork.ToShortDateString()} ");
        }
    }
}

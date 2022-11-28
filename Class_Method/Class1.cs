using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Class_Method
{
    internal class DataBase
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public DataBase(string name, string surname, string group, int point, bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isgraduated;

        }

        public void Graduated()
        {
            if (IsGraduated)
            {
                Console.WriteLine("Tebrik edirik"+" "+ Name + " " + Surname + " " +"artiq mezunsunuz!");
                Console.Write("Baliniz: ");
            }
            else
            {
                Console.WriteLine("Teessuf ki"+" "+ Name + " " + Surname + " " +"mezun ola bilmediniz...");
                Console.Write("Baliniz: ");
            }
        }

        public void Points()
        {
            if (Point > 80)
            {
                Console.WriteLine("2-ci defe yeniden imtahan vermek haqqini qazandiniz.");
            }
            
        }

    }
}

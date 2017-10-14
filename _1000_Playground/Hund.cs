using System;

namespace _01_Interfaces_Playground
{
    public class Hund : ISaeugetier
    {
        public int Alter { get; set; }

        public double Gewicht { get; set; }

        public double Groesse { get; set; }

        public string Name { get; set; }

        public void Ausscheiden()
        {
            Console.WriteLine("Der Hund kackt...");
        }

        public void Fressen()
        {
            Console.WriteLine("Der Hund frisst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt...");
        }
    }
}
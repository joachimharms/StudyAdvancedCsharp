using System;

namespace _1000_Playground
{
    public class Katze : ISaeugetier
    {
        public double Groesse { get; set; }

        public double Gewicht { get; set; }

        public void Ausscheiden()
        {
            Console.WriteLine("Die Katze kackt...");
        }

        public int Alter { get; set; }

        public string Name { get; set; }

        public void Trinken()
        {
            Console.WriteLine("Die Katze trinkt...");
        }

        public void Fressen()
        {
            Console.WriteLine("Die Katze frisst...");
        }
    }
}
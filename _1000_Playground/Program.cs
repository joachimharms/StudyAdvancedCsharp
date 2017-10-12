using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISaeugetier> saeugetiere = new List<ISaeugetier>();
            var cat01 = new Katze();
            var cat02 = new Katze();
            var dog01 = new Hund();
            var dog02 = new Hund();

            cat01.Alter = 5;
            cat01.Gewicht = 8;
            cat01.Name = "Minki";
            cat01.Groesse = 39;

            cat02.Alter = 10;
            cat02.Groesse = 45;
            cat02.Gewicht = 12;
            cat02.Name = "Mucki";

            dog01.Alter = 9;
            dog01.Groesse = 55;
            dog01.Gewicht = 15;
            dog01.Name = "Waldi";

            dog02.Alter = 6;
            dog02.Gewicht = 12;
            dog02.Groesse = 41;
            dog02.Name = "Tinka";

            saeugetiere.Add(cat01);

            saeugetiere.Add(cat02);

            saeugetiere.Add(dog01);

            saeugetiere.Add(dog02);

            foreach (var saeugetier in saeugetiere)
            {
                if (saeugetier is Hund)
                {
                    Console.WriteLine("Wuff!");
                    if (saeugetier.Name == "Waldi")
                    {
                        Console.WriteLine("Der Hund ist " + dog01.Alter + " Jahre alt und sein Name ist " + dog01.Name + ". Der Hund ist " + dog01.Gewicht + "kg schwer und " + dog01.Groesse + "cm groß.");
                        dog01.Ausscheiden();
                        dog01.Fressen();
                        dog01.Trinken();
                        Console.WriteLine();
                    }

                    else if (saeugetier.Name == "Tinka")
                    {
                        Console.WriteLine(
                            "Der Hund ist " + dog02.Alter + " Jahre alt und sein Name ist " + dog02.Name
                            + ". Der Hund ist " + dog02.Gewicht + "kg schwer und " + dog02.Groesse + "cm groß.");
                        dog02.Ausscheiden();
                        dog02.Fressen();
                        dog02.Trinken();
                        Console.WriteLine();
                    }
                    else return;
                }
                
                if (saeugetier is Katze)
                {
                    Console.WriteLine("Miau!");
                    if (saeugetier.Name == "Minki")
                    {
                        Console.WriteLine("Die Katze ist " + cat01.Alter + " Jahre alt und ihr Name ist " + cat01.Name + ". Die Katze ist " + cat01.Gewicht + "kg schwer und " + cat01.Groesse + "cm groß.");
                        cat01.Ausscheiden();
                        cat01.Fressen();
                        cat01.Trinken();
                        Console.WriteLine();
                    }

                    else if (saeugetier.Name == "Mucki")
                    {
                        Console.WriteLine(
                            "Die Katze ist " + cat02.Alter + " Jahre alt und ihr Name ist " + cat02.Name
                            + ". Die Katze ist " + cat02.Gewicht + "kg schwer und " + cat02.Groesse + "cm groß.");
                        cat02.Ausscheiden();
                        cat02.Fressen();
                        cat02.Trinken();
                        Console.WriteLine();
                    }
                    else return;
                   
                }
            }
        }
    }
}
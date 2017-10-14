#region License
// Copyright (c) 2017, Joachim Harms
// All rights reserved.
// 
// Unauthorized copying of this file, via any medium is strictly prohibited.
// Proprietary and confidential.
// 
// Written by Joachim Harms
// <joachimharms.business@gmail.com>
#endregion

using System;

namespace _01_Interfaces_Playground
{
    public class Schnecke : ILebewesen
    {
        public double Groesse { get; set; }

        public double Gewicht { get; set; }

        public void Ausscheiden()
        {
            Console.WriteLine("Die Schnecke kackt...");
        }

        // Klassenspezifische Methode
        public void Schleimen()
        {
            Console.WriteLine("Die Schnecke schleimt...");
        }
    }
}
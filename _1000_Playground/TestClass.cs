using System;

namespace _1000_Playground
{
    // Multiple Interface implementation to demonstrate Diamond problem
    public class TestClass : I1, I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("Zwei Interfaces mit derselben Methodensignatur implementiert...");
        }

    }
}
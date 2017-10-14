using System;

namespace _01_Interfaces_Playground
{
    // Multiple Interface implementation to demonstrate Diamond problem
    public class TestClass : I1, I2
    {
        // Explizite Interfaceimplementation. Wenn du explizite Interfaceimplementation verwendest dürfen keine Accessmodifier in für die Methodenimplementation verwendet werden:
        void I1.InterfaceMethod()
        {
          Console.WriteLine("Invoking I1 interface method");
        }


        void I2.InterfaceMethod()
        {
          Console.WriteLine("Invoking I2 interface method");
        }
    }
}
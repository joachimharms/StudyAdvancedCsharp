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
namespace _01_Interfaces
{
    public interface ICustomer
    {
        // Felder und Variablen dürfen nicht enthalten sein. Dies ist ein Kompilierfehler:
        //int Alter;   

        // Eigenschaften dürfen enthalten sein: 
        int Alter { get; set; }

        // Methoden dürfen enthalten sein:
        void BuyProduct();  

        // Delegates dürfen enthalten sein.
        // Events dürfen enthalten sein.

    }
}
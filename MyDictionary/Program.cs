 using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Product = new List<string>();
            Product.Add("Ayakkabi");
            Product.Add("Canta");

            MyList<string> myProduct = new MyList<string>();
            myProduct.Add("Ayakkabi");
            myProduct.Add("T-Shirt");
            
            //Liste yazdirma bicimi value=key mantiginda
            foreach (var item in Product)
            {
                Console.WriteLine(value: item);
            }
        }
    }
}

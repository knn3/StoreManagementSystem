using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public class Category : Store
    {
        public SmartArray<Product> ArrayOfProduct;
        public Category()
        {
            ArrayOfProduct = new SmartArray<Product>();
        }
        public Category(string aName)
        {
            nameofcategory = aName;
            ArrayOfProduct = new SmartArray<Product>();
        }

        public string nameofcategory { get; set; }

        ~Category()
        {
            Console.WriteLine("Destructor is comingggg");
        }


    }
}

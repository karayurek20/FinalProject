using Business.Concrete;
using DataAccess.Concrete.EntityFremework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryMenager categoryMenager = new CategoryMenager(new EfCategoryDal());
            foreach (var category in categoryMenager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductMenager productMenager = new ProductMenager(new EfProductDal());

            foreach (var product in productMenager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+"---"+product.CategoryName);
            }
            Console.ReadKey();
        }
    }
}

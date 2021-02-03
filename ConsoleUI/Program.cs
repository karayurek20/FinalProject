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
            ProductMenager productMenager = new ProductMenager(new EfProductDal());

            foreach (var product in productMenager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}

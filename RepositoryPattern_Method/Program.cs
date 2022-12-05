using RepositoryPattern_Method.Models;
using RepositoryPattern_Method.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork uw = new UnitOfWork();
            var repoCat = uw.Get<ProductCategory>();
            ProductCategory c1 = new ProductCategory { Id = 1, Name = "T-Shirt" };
            ProductCategory c2 = new ProductCategory { Id = 2, Name = "Jacket" };
            ProductCategory c3 = new ProductCategory(3, "Denim");
            repoCat.Add(c1);
            repoCat.Add(c2);
            repoCat.Add(c3);
            Console.WriteLine("Read data");
            repoCat.GetAll()
                .ToList()
                .ForEach(c=> Console.WriteLine($"{c.Name}"));
            Console.WriteLine();
            var repoProd = uw.Get<Product>();
            Product p1 = new Product { Id = 1, Name = "Back Printed T-Shirt", ListPrice = 299.99M, Size = "XL" };
            Product p2 = new Product { Id = 2, Name = "Jeans Jacket", ListPrice = 2399.99M, Size = "XXL" };
            Product p3 = new Product { Id = 3, Name = "Denim Long", ListPrice = 1299.99M, Size = "XXL" };
            repoProd.Add(p1);
            repoProd.Add(p2);
            repoProd.Add(p3);
            Console.WriteLine("Read data");
            repoProd.GetAll()
                .ToList()
                .ForEach(p => Console.WriteLine($"Name: {p.Name}, Size: {p.Size} Price: {p.ListPrice:0.00}"));
            Console.WriteLine("Update data");
            p2.ListPrice = 3399.99M;
            repoProd.Update(p2);
            repoProd.GetAll()
                .ToList()
                .ForEach(p => Console.WriteLine($"Name: {p.Name}, Size: {p.Size} Price: {p.ListPrice:0.00}"));
            Console.WriteLine("Delete data");
            p2.ListPrice = 3399.99M;
            repoProd.Delete(2);
            repoProd.GetAll()
                .ToList()
                .ForEach(p => Console.WriteLine($"Name: {p.Name}, Size: {p.Size} Price: {p.ListPrice:0.00}"));
            Console.ReadLine();
        }
    }
}

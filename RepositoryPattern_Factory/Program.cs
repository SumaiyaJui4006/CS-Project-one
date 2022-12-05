using RepositoryPattern_Factory.Factories;
using RepositoryPattern_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ef = new EntityFactory();
            var rf = new RepoFactory();
            var repoCat = rf.Create<ProductCategory>();
            var c1 = ef.Create<ProductCategory>(1, "T-Shirt");
            var c2 = ef.Create<ProductCategory>(2, "Jacket");
            var c3 = ef.Create<ProductCategory>(3, "Denim");
            repoCat.Add(c1);
            repoCat.Add(c2);
            repoCat.Add(c3);
            Console.WriteLine("Read data");
            repoCat.GetAll()
                .ToList()
                .ForEach(c => Console.WriteLine($"{c.Name}"));
            Console.WriteLine();
            var repoProd = rf.Create<Product>();
            var p1 = ef.Create<Product>(1, "Back Printed T-Shirt", 299.00M, "XL");
            var p2 = ef.Create<Product>(2, "Jeans Jacket", 2399.00M, "XXL");
            var p3 = ef.Create<Product>(3, "Denim Long", 1299.99M, "XXL");
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

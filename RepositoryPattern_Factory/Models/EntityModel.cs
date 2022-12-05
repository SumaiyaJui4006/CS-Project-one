using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Factory.Models
{
    public class ProductCategory : IEntity
    {
        public ProductCategory() { }
        public ProductCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class Product : IEntity
    {
        public Product()
        {

        }
        public Product(int id, string name, decimal listPrice, string size)
        {
            this.Id = id;
            this.Name = name;   
            this.ListPrice = listPrice;
            this.Size = size;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
    }
}

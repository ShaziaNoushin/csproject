using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03Project.Models
{
    public class Product : IModelBase
    {

        public Product() { }
        public Product(int id, string name, decimal unitPrice)
        {
            this.Id = id;
            this.Name = name;
            this.UnitPrice = unitPrice;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

    }
}

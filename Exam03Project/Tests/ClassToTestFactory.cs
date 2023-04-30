using Exam03Project.Factories;
using Exam03Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03Project.Tests
{
    public class ClassToTestFactory
    {
        private readonly IModelFactory factory = null;
        public ClassToTestFactory(IModelFactory factory)
        {
            this.factory = factory;
        }
        public void RunTest()
        {
            var products = new[]
            {
                factory.Create<Product>(1, "250ply Tissue Paper", 27.50M),
                factory.Create<Product>(2, "8pcs Marker Pen", 153.00M),
                factory.Create<Product>(3, "Wooden Organizer", 110.00M)
            };
            products.ToList()
            .ForEach(p => Console.WriteLine($"Id: {p.Id} Name: {p.Name} Unit Price: {p.UnitPrice}"));
            Console.WriteLine();
            var sales = new[]
            {
                factory.Create< Sales>(1, 2022, 1, 1, 34000),
                factory.Create < Sales>(2, 2022, 2, 2, 37000),
                factory.Create < Sales>(1, 2022, 1, 1, 34000)
            };
            sales.ToList()
            .ForEach(s => Console.WriteLine($"Id: {s.Id} Month: {s.Month} Product Id: {s.ProductId} Sold: {s.QuatitySold}"));
        }
    }
}

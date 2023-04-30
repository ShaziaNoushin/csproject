using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam03Project.Models
{
    public class Sales : IModelBase
    {
        public Sales() { }
        public Sales(int id, int year, int month, int productId, int quantitySold)
        {
            this.Id = id;
            this.Year = year;
            this.Month = month;
            this.ProductId = productId;
            this.QuatitySold = quantitySold;
        }
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int ProductId { get; set; }
        public int QuatitySold { get; set; }

    }
}

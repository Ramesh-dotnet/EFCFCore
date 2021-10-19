using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCFCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descrption { get; set; }
        public int Cost { get; set; }
       // public List<Customer> customers { get; set; }
    }
}
 
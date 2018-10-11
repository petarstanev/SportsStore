using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class Product : IEnumerable
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description {get;set;}
        public decimal Price { get; set; }
        public string Category { get; set; }
        public IEnumerator GetEnumerator()
        {
            yield break;
        }
    }
}

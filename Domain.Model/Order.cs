using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsRealized { get; set; }
        public List<Product> ProductList { get; set; }
        //public string zamawiajacy { get; set; }
    }
}

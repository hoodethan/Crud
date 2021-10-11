using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductRelationships.Models
{
    public class Order
    {
        //[ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}

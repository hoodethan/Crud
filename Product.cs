using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductRelationships.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public int OrderId { get; set; }

        //[ForeignKey("OrderId")]
        public virtual ICollection<Order> Orders
        {
            get; set;

        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEditor
{
    public class Purchase
    {
        [Key] public int Id { get; set; }

        [ForeignKey("Product")]
        public int Id_Product { get; set; }

        public Product? Product { get; set; }
        
        public DateTime Date { get; set; }

        public decimal Quantity { get; set; }

       
    }
}

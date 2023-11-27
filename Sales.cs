using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseEditor
{
    public class Sales
    {

        [Key] public int Id { get; set; }

        [ForeignKey("Product")]
        public int Id_Product { get; set; }

        public Product? Product { get; set; }

        /// <summary>
        /// Дата продажи
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Всего количество проданого товара
        /// </summary>
        public decimal TotalSold { get; set; }

        /// <summary>
        /// Сумма продажи общая
        /// </summary>
        public decimal Sum { get; set; }
    }
}

﻿using System;
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

        /// <summary>
        /// Дата закупки
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Колличество закупленного товара
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Цена за единицу
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Сумма закупки
        /// </summary>
        public decimal SumPurchase { get; set; }

       
    }
}

using System;
using System.Collections.Generic;

namespace BaseEditor;

public partial class Product
{
    public int Id { get; set; }

    /// <summary>
    /// Наименование товара
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Единица измерения
    /// </summary>
    public string? MeasureUnit { get; set; }

    /// <summary>
    /// Остаток на складе
    /// </summary>
    public decimal Balance { get; set; }

    /// <summary>
    /// Закупочная цена
    /// </summary>
    public decimal Price { get; set; } 

    /// <summary>
    /// Минимально допустимый остаток на складе
    /// </summary>
    public decimal MinBalance { get; set; } 

    /// <summary>
    /// Лимит на закупку в деньгах
    /// </summary>
    public decimal Limit { get; set; } 

    /// <summary>
    /// Отдел магазина: продуктовый или промышленный
    /// </summary>
    public string? Group { get; set; }

    /// <summary>
    /// Поставщик товара
    /// </summary>
    public string? Provider { get; set; }

    /// <summary>
    /// Закупки 
    /// </summary>
    public List<Purchase>? Purchases { get; set; }

    /// <summary>
    /// Продажи
    /// </summary>
    public List<Sales>? Sales { get; set; }
}

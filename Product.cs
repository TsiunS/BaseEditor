using System;
using System.Collections.Generic;

namespace BaseEditor;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? MeasureUnit { get; set; }

    public decimal Balance { get; set; }

    public decimal Price { get; set; } 

    public decimal MinBalance { get; set; } 

    public decimal Limit { get; set; } 

    public string? Group { get; set; }

    public string? Provider { get; set; }
}

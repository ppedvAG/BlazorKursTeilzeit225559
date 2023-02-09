using System;
using System.Collections.Generic;

namespace BlazorKursTeilzeit225559.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}

using System;
using System.Collections.Generic;

namespace BlazorKursTeilzeit225559.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}

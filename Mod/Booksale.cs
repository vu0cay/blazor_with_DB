﻿using System;
using System.Collections.Generic;

namespace BookSale.Mod;

public partial class Booksale
{
    public int SaleId { get; set; }

    public string? Title { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }
}

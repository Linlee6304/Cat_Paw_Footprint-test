using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class ProductAnalysis
{
    public int? ProductId { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public DateTime? RemovalDate { get; set; }

    public virtual Product? Product { get; set; }
}

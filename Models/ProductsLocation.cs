using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class ProductsLocation
{
    public int? ProductId { get; set; }

    public int? LocationId { get; set; }

    public virtual Location? Location { get; set; }

    public virtual Product? Product { get; set; }
}

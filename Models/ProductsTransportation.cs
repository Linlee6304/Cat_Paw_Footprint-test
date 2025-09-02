using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class ProductsTransportation
{
    public int? ProductId { get; set; }

    public int? TransportId { get; set; }

    public string? TransportInfo { get; set; }

    public DateTime? TransportTime { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Transportation? Transport { get; set; }
}

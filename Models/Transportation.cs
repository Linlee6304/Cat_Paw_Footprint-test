using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Transportation
{
    public int TransportId { get; set; }

    public string? TransportName { get; set; }

    public string? TransportDesc { get; set; }

    public int? TransportPrice { get; set; }

    public decimal? Rating { get; set; }

    public int? Views { get; set; }
}

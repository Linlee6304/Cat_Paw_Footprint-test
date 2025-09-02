using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class SemiTransportation
{
    public int? ProductId { get; set; }

    public int? TransportId { get; set; }

    public virtual SemiSelfProduct? Product { get; set; }

    public virtual Transportation? Transport { get; set; }
}

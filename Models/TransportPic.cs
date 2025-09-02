using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class TransportPic
{
    public int? TransportId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual Transportation? Transport { get; set; }
}

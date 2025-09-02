using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class LocationPic
{
    public int? LocationId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual Location? Location { get; set; }
}

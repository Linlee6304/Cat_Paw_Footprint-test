using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class RestaurantPic
{
    public int? RestaurantId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}

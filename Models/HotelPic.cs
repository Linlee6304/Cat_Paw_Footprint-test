using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class HotelPic
{
    public int? HotelId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual Hotel? Hotel { get; set; }
}

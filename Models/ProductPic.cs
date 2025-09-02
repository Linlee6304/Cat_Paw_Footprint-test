using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class ProductPic
{
    public int? ProductId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual Product? Product { get; set; }
}

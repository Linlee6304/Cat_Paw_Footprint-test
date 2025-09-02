using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class ProductsHotel
{
    public int? ProductId { get; set; }

    public int? HotelId { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Product? Product { get; set; }
}

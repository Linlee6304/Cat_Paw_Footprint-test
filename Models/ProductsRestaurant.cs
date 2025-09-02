using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class ProductsRestaurant
{
    public int? ProductId { get; set; }

    public int? RestaurantId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}

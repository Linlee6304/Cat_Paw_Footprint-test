using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class ProductsPromotion
{
    public int? PromoId { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Promotion? Promo { get; set; }
}

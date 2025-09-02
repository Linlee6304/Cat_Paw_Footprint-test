using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Restaurant
{
    public int RestaurantId { get; set; }

    public string? RestaurantName { get; set; }

    public string? RestaurantAddr { get; set; }

    public decimal? RestaurantLat { get; set; }

    public decimal? RestaurantLng { get; set; }

    public string? RestaurantDesc { get; set; }

    public int? RegionId { get; set; }

    public int? DistrictId { get; set; }

    public decimal? Rating { get; set; }

    public int? Views { get; set; }

    public virtual District? District { get; set; }

    public virtual Region? Region { get; set; }
}

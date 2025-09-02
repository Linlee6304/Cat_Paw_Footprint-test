using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string? RegionName { get; set; }

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}

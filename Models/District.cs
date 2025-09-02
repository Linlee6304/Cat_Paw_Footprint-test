using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}

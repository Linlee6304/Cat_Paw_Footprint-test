using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string? HotelName { get; set; }

    public string? HotelAddr { get; set; }

    public decimal? HotelLat { get; set; }

    public decimal? HotelLng { get; set; }

    public string? HotelDesc { get; set; }

    public int? RegionId { get; set; }

    public int? DistrictId { get; set; }

    public decimal? Rating { get; set; }

    public int? Views { get; set; }

    public virtual District? District { get; set; }

    public virtual Region? Region { get; set; }
}

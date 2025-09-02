using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Location
{
    public int LocationId { get; set; }

    public string? LocationName { get; set; }

    public string? LocationAddr { get; set; }

    public decimal? LocationLat { get; set; }

    public decimal? LocationLng { get; set; }

    public string? LocationDesc { get; set; }

    public int? TicketPrice { get; set; }

    public int? RegionId { get; set; }

    public int? DistrictId { get; set; }

    public decimal? Rating { get; set; }

    public int? Views { get; set; }

    public virtual District? District { get; set; }

    public virtual Region? Region { get; set; }
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class TripProjectDetail
{
    public int? ProjectId { get; set; }

    public DateTime? TripDate { get; set; }

    public int? TripSequence { get; set; }

    public DateTime? StartTime { get; set; }

    public int? StayMinute { get; set; }

    public int? TransportId { get; set; }

    public string? TripType { get; set; }

    public int? HotelId { get; set; }

    public int? LocationId { get; set; }

    public int? RestaurantId { get; set; }

    public string? Notes { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Location? Location { get; set; }

    public virtual CustomerTripProject? Project { get; set; }

    public virtual Restaurant? Restaurant { get; set; }

    public virtual Transportation? Transport { get; set; }
}

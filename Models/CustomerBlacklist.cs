using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerBlacklist
{
    public int BlacklistId { get; set; }

    public int? CustomerId { get; set; }

    public string? Reason { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? PermissionStatus { get; set; }

    public virtual CustomerProfile? Customer { get; set; }
}

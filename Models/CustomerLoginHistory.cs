using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerLoginHistory
{
    public int LoginLogId { get; set; }

    public int? CustomerId { get; set; }

    public string? LoginIp { get; set; }

    public DateTime? LoginTime { get; set; }

    public bool? IsSuccessful { get; set; }

    public virtual Customer? Customer { get; set; }
}

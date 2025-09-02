using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Account { get; set; }

    public string? Password { get; set; }

    public string? FullName { get; set; }

    public int? Level { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Status { get; set; }

    public bool? IsBlacklisted { get; set; }

    public string? CustomerCode { get; set; }

    public virtual ICollection<CustomerLoginHistory> CustomerLoginHistories { get; set; } = new List<CustomerLoginHistory>();

    public virtual CustomerProfile? CustomerProfile { get; set; }

    public virtual CustomerLevel? LevelNavigation { get; set; }
}

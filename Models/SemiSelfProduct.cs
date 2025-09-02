using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class SemiSelfProduct
{
    public int ProductId { get; set; }

    public string? ProjectName { get; set; }

    public int? Region { get; set; }

    public string? ProductDesc { get; set; }

    public int? ProductPrice { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? Notes { get; set; }

    public int? MaxPeople { get; set; }

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();
}

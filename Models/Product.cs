using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int? RegionId { get; set; }

    public string? ProductDesc { get; set; }

    public int? ProductPrice { get; set; }

    public string? ProductNote { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? MaxPeople { get; set; }

    public byte[]? ProductImage { get; set; }

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();

    public virtual Region? Region { get; set; }
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class OrderStatus
{
    public int OrderStatusId { get; set; }

    public string? StatusDesc { get; set; }

    public virtual ICollection<CustomerOrder> CustomerOrders { get; set; } = new List<CustomerOrder>();
}

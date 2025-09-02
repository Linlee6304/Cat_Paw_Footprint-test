using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerOrder
{
    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public int OrderId { get; set; }

    public int? OrderStatusId { get; set; }

    public int? TotalAmount { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual CustomerProfile? Customer { get; set; }

    public virtual ICollection<CustomerOrderFeedback> CustomerOrderFeedbacks { get; set; } = new List<CustomerOrderFeedback>();

    public virtual ICollection<OrderPaymentInfo> OrderPaymentInfos { get; set; } = new List<OrderPaymentInfo>();

    public virtual OrderStatus? OrderStatus { get; set; }

    public virtual Product? Product { get; set; }

    public virtual SemiSelfProduct? ProductNavigation { get; set; }
}

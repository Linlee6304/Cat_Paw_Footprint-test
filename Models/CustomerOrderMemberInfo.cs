using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerOrderMemberInfo
{
    public int? OrderId { get; set; }

    public string? CustomerName { get; set; }

    public string? Idnumber { get; set; }

    public DateTime? CustomerBirth { get; set; }

    public virtual CustomerOrder? Order { get; set; }
}

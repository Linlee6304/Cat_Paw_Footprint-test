using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class CustomerLevel
{
    public int Level { get; set; }

    public string? LevelName { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}

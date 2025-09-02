using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class EmployeeRole
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}

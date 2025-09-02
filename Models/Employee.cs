using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? Account { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Status { get; set; }

    public string? EmployeeCode { get; set; }

    public virtual ICollection<CustomerSupportTicket> CustomerSupportTickets { get; set; } = new List<CustomerSupportTicket>();

    public virtual EmployeeProfile? EmployeeProfile { get; set; }

    public virtual EmployeeRole? Role { get; set; }
}

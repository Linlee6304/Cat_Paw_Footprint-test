using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class EmployeeProfile
{
    public int ProfileId { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Idnumber { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public byte[]? Photo { get; set; }

    public string? ProfileCode { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<NewsTable> NewsTables { get; set; } = new List<NewsTable>();
}

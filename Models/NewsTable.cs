using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class NewsTable
{
    public int NewsId { get; set; }

    public string? NewsTitle { get; set; }

    public string? NewsContent { get; set; }

    public DateTime? PublishTime { get; set; }

    public DateTime? ExpireTime { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? EmployeeId { get; set; }

    public virtual EmployeeProfile? Employee { get; set; }
}

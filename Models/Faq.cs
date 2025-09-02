using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Faq
{
    public int Faqid { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public virtual Faqcategory? Category { get; set; }
}

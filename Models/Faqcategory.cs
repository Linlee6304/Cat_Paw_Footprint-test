using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class Faqcategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Faq> Faqs { get; set; } = new List<Faq>();
}

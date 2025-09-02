using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class RestaurantKeyword
{
    public int? RestaurantId { get; set; }

    public int? KeywordId { get; set; }

    public virtual Keyword? Keyword { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}

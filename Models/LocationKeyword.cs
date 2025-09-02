using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class LocationKeyword
{
    public int? LocationId { get; set; }

    public int? KeywordId { get; set; }

    public virtual Keyword? Keyword { get; set; }

    public virtual Location? Location { get; set; }
}

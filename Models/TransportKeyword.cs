using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class TransportKeyword
{
    public int? TransportId { get; set; }

    public int? KeywordId { get; set; }

    public virtual Keyword? Keyword { get; set; }

    public virtual Transportation? Transport { get; set; }
}

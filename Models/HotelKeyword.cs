using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class HotelKeyword
{
    public int? HotelId { get; set; }

    public int? KeywordId { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Keyword? Keyword { get; set; }
}

using System;
using System.Collections.Generic;

namespace Cat_Paw_Footprint.Models;

public partial class NewsPic
{
    public int? NewsId { get; set; }

    public byte[]? NewsPic1 { get; set; }

    public virtual NewsTable? News { get; set; }
}

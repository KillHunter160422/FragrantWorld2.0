using System;
using System.Collections.Generic;

namespace FragrantWorld.Models;

public partial class OrderProduct
{
    public int OrderProductId { get; set; }

    public string ProductArticleNumber { get; set; } = null!;

    public int OrderProductAmount { get; set; }

    public virtual Order OrderProductNavigation { get; set; } = null!;

    public virtual Product ProductArticleNumberNavigation { get; set; } = null!;
}

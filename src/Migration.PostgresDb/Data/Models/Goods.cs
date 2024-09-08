using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Goods
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? GoodTypeId { get; set; }

    public long? ObjectId { get; set; }

    public string? StateId { get; set; }

    public bool? IsCantChose { get; set; }

    public string? CostDesc { get; set; }

    public double? BonusShopCost { get; set; }

    public List<long>? RoleId { get; set; }

    public string? DeliveryType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

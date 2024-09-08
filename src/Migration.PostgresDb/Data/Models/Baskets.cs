using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Baskets
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? CurrencyTypeId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

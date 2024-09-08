using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CustomReports
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? ObjectNameType { get; set; }

    public string? ObjectName { get; set; }

    public string? Connect2Object { get; set; }

    public string? Block { get; set; }

    public string? AccessBlockType { get; set; }

    public bool? Subscription { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PayPhases
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? EventId { get; set; }

    public string? EventName { get; set; }

    public double? Cost { get; set; }

    public string? Currency { get; set; }

    public double? InvoiceSum { get; set; }

    public double? DraftSum { get; set; }

    public double? ActSum { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

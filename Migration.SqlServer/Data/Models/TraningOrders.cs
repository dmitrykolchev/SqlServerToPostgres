using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class TraningOrders
{
    public long Id { get; set; }

    public string? Number { get; set; }

    public DateTime? Date { get; set; }

    public string? SigningPersonFullname { get; set; }

    public string? ResponsiblePersonFullname { get; set; }

    public string? PerformerPersonFullname { get; set; }

    public long? OrderTypeId { get; set; }

    public long? EventId { get; set; }

    public long? EducationOrgId { get; set; }

    public long? PayPhaseId { get; set; }

    public double? Cost { get; set; }

    public string? Currency { get; set; }

    public string? Status { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

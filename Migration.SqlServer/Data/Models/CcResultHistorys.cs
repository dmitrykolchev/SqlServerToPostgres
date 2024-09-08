using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcResultHistorys
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? CourseName { get; set; }

    public string? AppNum { get; set; }

    public string? EventForm { get; set; }

    public long? EduType { get; set; }

    public long? EduOrgId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public string? ValidationProtocol { get; set; }

    public DateTime? ValidationDate { get; set; }

    public long? Presence { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? Order { get; set; }
}

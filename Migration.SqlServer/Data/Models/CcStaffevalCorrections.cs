using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalCorrections
{
    public long Id { get; set; }

    public string? CheckName { get; set; }

    public long? ControlObject { get; set; }

    public long? CheckedObject { get; set; }

    public string? OrderCorrection { get; set; }

    public string? ContentOfViolation { get; set; }

    public string? PointName { get; set; }

    public long? Responsible { get; set; }

    public DateTime? Date { get; set; }

    public bool? Status { get; set; }

    public string? OrderResult { get; set; }

    public long? StationId { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? LastEditionDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PresenceStates
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? StateId { get; set; }

    public string? StateName { get; set; }

    public bool? Accessible { get; set; }

    public bool? IsAbsence { get; set; }

    public long? WorkflowId { get; set; }

    public bool? CanCancel { get; set; }

    public bool? CanChange { get; set; }

    public long? CancelWorkflowId { get; set; }

    public long? ChangeWorkflowId { get; set; }

    public long? Position { get; set; }

    public string? StyleCss { get; set; }

    public bool? AllDay { get; set; }

    public bool? IsSubWorkTime { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

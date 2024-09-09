using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnLicenses
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? PostLicensedId { get; set; }

    public string? OrderProps { get; set; }

    public bool? FlHeldPost { get; set; }

    public bool? FlPrepare { get; set; }

    public long? ActivityId { get; set; }

    public string? Number { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? FlCancel { get; set; }

    public string? CancelNote { get; set; }

    public bool? FlPrepareComplete { get; set; }

    public DateTime? PrepareCompleteDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

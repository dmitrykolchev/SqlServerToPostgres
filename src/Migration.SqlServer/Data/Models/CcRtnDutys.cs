using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnDutys
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? PostLicensedId { get; set; }

    public bool? FlHeldPost { get; set; }

    public DateTime? BeginDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? OrderProps { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcCollaborators
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? ForeignPersonId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

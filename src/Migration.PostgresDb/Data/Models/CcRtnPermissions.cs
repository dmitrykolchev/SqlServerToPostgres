using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnPermissions
{
    public long Id { get; set; }

    public long? CollaboratorId { get; set; }

    public long? PostLicensedId { get; set; }

    public long? ActivityId { get; set; }

    public string? OrderProps { get; set; }

    public short? FlStop { get; set; }

    public short? FlCancel { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcPfoPasswords
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? Password { get; set; }

    public DateTime? PassDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

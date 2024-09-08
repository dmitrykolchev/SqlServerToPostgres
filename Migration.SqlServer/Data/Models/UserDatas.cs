using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class UserDatas
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public DateTime? DeleteDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreationUserId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModificationUserId { get; set; }
}

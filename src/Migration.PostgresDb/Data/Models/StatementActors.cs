using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class StatementActors
{
    public long Id { get; set; }

    public string? Path { get; set; }

    public string? Name { get; set; }

    public string? ObjectType { get; set; }

    public long? StatementId { get; set; }

    public string? Mbox { get; set; }

    public string? MboxSha1sum { get; set; }

    public string? Openid { get; set; }

    public string? AccountHomePage { get; set; }

    public string? AccountName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ForumThemeReadByCollaborators
{
    public long Id { get; set; }

    public long? ForumId { get; set; }

    public long? ForumThemeId { get; set; }

    public DateTime? Date { get; set; }

    public long? PersonId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

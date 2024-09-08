using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalDocumentCodes
{
    public long Id { get; set; }

    public string? DocumentId { get; set; }

    public string? NameDocument { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

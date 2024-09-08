using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcEducations
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public string? Type { get; set; }

    public string? Org { get; set; }

    public string? DocType { get; set; }

    public string? DocNum { get; set; }

    public string? Specialty { get; set; }

    public string? Qualification { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

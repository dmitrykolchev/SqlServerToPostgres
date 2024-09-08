using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ClassificationModels
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? RequiredProbability { get; set; }

    public long? CodeLibraryId { get; set; }

    public long? ProcessingCodeLibraryId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public bool? IsStd { get; set; }

    public bool? Changed { get; set; }
}

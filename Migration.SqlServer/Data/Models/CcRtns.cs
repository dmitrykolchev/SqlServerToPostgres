using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtns
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? Validity { get; set; }

    public string? Serial { get; set; }

    public string? Position { get; set; }

    public string? ResolutionForm { get; set; }

    public string? ResolutionType { get; set; }

    public string? IssuedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SubmissionRecipients
{
    public long Id { get; set; }

    public long? SubmissionTypeId { get; set; }

    public string? SubmissionTypeName { get; set; }

    public long? CollaboratorId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonPositionName { get; set; }

    public string? PersonSubdivisionName { get; set; }
}

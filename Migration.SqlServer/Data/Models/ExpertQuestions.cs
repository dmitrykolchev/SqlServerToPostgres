using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ExpertQuestions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? NormativeDate { get; set; }

    public string? Question { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ExpertId { get; set; }

    public bool? Status { get; set; }

    public bool? IsFaq { get; set; }

    public bool? IsDisclosed { get; set; }

    public string? KnowledgeParts { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? Tags { get; set; }

    public DateTime? AnswerDate { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcQuizs
{
    public long Id { get; set; }

    public long? PersonId { get; set; }

    public DateTime? CheckDate { get; set; }

    public string? PositionType { get; set; }

    public string? Position { get; set; }

    public string? Exam { get; set; }

    public string? CheckPeriod { get; set; }

    public string? ExamType { get; set; }

    public DateTime? NextDate { get; set; }

    public string? Protocol { get; set; }

    public string? Value { get; set; }

    public string? ElectroGroup { get; set; }

    public string? RespGroup { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

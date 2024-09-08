using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class PollResults
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? PollId { get; set; }

    public long? PollProcedureId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public string? QuestionId { get; set; }

    public bool? IsDone { get; set; }

    public long? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? MainValue { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? Code { get; set; }
}

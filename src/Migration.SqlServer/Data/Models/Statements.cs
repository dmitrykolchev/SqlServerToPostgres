using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Statements
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? LearningStorageId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public string? VerbId { get; set; }

    public string? VerbName { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? CreateTicks { get; set; }

    public string? StatementRefId { get; set; }

    public bool? Voited { get; set; }

    public long? ActivityId { get; set; }

    public string? ActivityCode { get; set; }

    public string? AgentJsonStr { get; set; }

    public string? Registration { get; set; }
}

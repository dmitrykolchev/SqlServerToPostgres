using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class Statements
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public long? CreateTicks { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? StatementRefId { get; set; }

    public bool? Voided { get; set; }

    public bool? Processed { get; set; }

    public long? LearningStorageId { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public long? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjectName { get; set; }

    public long? ActivityId { get; set; }

    public string? ActivityCode { get; set; }

    public string? VerbId { get; set; }

    public string? VerbName { get; set; }

    public string? AgentJsonStr { get; set; }

    public string? Registration { get; set; }

    public string? ContextRegistration { get; set; }

    public string? ContextInstructor { get; set; }

    public string? ContextTeam { get; set; }

    public string? ContextRevision { get; set; }

    public string? ContextPlatform { get; set; }

    public string? ContextLanguage { get; set; }

    public string? ContextStatement { get; set; }

    public double? ResultScoreMax { get; set; }

    public double? ResultScoreMin { get; set; }

    public double? ResultScoreRaw { get; set; }

    public double? ResultScoreScaled { get; set; }

    public bool? ResultSuccess { get; set; }

    public bool? ResultCompletion { get; set; }

    public string? ResultResponse { get; set; }

    public string? ResultDuration { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

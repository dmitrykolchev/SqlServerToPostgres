using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ProjectParticipantRoles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? ProjectId { get; set; }

    public long? ParticipantNum { get; set; }

    public long? ProviderId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class GroupCollaborators
{
    public long Id { get; set; }

    public long? GroupId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ForumId { get; set; }

    public long? TutorId { get; set; }

    public string? TutorFullname { get; set; }

    public bool? IsDynamic { get; set; }

    public long? CollaboratorId { get; set; }

    public string? CollaboratorFullname { get; set; }

    public bool? AllowSocialPost { get; set; }

    public bool? IsHidden { get; set; }
}

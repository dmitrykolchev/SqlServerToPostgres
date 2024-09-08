using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Items
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? TypeId { get; set; }

    public string? Title { get; set; }

    public string? QuestionText { get; set; }

    public long? QuestionPoints { get; set; }

    public string? RoleId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public string? Status { get; set; }
}

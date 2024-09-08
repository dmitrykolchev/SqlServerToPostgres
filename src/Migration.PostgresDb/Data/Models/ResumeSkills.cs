using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ResumeSkills
{
    public long Id { get; set; }

    public long? ResumeId { get; set; }

    public string? Name { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? PersonOrgName { get; set; }

    public string? PersonPosition { get; set; }

    public long? CreatorPersonId { get; set; }

    public string? CreatorPersonFullname { get; set; }

    public long? SkillId { get; set; }

    public string? SkillName { get; set; }

    public long? SkillIdWithLevels { get; set; }

    public string? LevelId { get; set; }

    public string? LevelName { get; set; }
}

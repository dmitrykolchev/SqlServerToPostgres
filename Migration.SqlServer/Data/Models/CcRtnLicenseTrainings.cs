using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcRtnLicenseTrainings
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public DateTime? TheoryBegin { get; set; }

    public DateTime? TheoryEnd { get; set; }

    public bool? FlTheorySuccess { get; set; }

    public DateTime? PracticeBegin { get; set; }

    public DateTime? PracticeEnd { get; set; }

    public bool? FlPracticeSuccess { get; set; }

    public DateTime? ExperienceBegin { get; set; }

    public DateTime? ExperienceEnd { get; set; }

    public bool? FlExperienceSuccess { get; set; }

    public DateTime? DoublingBegin { get; set; }

    public DateTime? DoublingEnd { get; set; }

    public string? DoublingProps { get; set; }

    public bool? FlDoublingSuccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

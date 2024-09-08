using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseTraining2s
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public DateTime? TheoryBegin { get; set; }

    public DateTime? TheoryEnd { get; set; }

    public double? TheoryHours { get; set; }

    public short? FlTheorySuccess { get; set; }

    public DateTime? PracticeBegin { get; set; }

    public DateTime? PracticeEnd { get; set; }

    public double? PracticeHours { get; set; }

    public short? FlPracticeSuccess { get; set; }

    public DateTime? ExperienceBegin { get; set; }

    public DateTime? ExperienceEnd { get; set; }

    public double? ExperienceHours { get; set; }

    public short? FlExperienceSuccess { get; set; }

    public DateTime? AdditionalBegin { get; set; }

    public DateTime? AdditionalEnd { get; set; }

    public double? AdditionalHours { get; set; }

    public short? FlAdditionalSuccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

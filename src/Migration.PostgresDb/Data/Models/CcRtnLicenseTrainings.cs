using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcRtnLicenseTrainings
{
    public long Id { get; set; }

    public long? LicenseId { get; set; }

    public DateTime? TheoryBegin { get; set; }

    public DateTime? TheoryEnd { get; set; }

    public short? FlTheorySuccess { get; set; }

    public DateTime? PracticeBegin { get; set; }

    public DateTime? PracticeEnd { get; set; }

    public short? FlPracticeSuccess { get; set; }

    public DateTime? ExperienceBegin { get; set; }

    public DateTime? ExperienceEnd { get; set; }

    public short? FlExperienceSuccess { get; set; }

    public DateTime? DoublingBegin { get; set; }

    public DateTime? DoublingEnd { get; set; }

    public string? DoublingProps { get; set; }

    public short? FlDoublingSuccess { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalPpkSpFromCas
{
    public long Id { get; set; }

    public long? PpkCaId { get; set; }

    public string? PositionName { get; set; }

    public string? SpList { get; set; }

    public long? ResponsibleId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? PracticalHours { get; set; }

    public long? InternshipHours { get; set; }

    public long? InstructionHours { get; set; }

    public string? TrainingHours { get; set; }

    public string? StaffQty { get; set; }

    public string? OrgsRate { get; set; }

    public long? StatusId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

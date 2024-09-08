using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PositionCommonInstructions
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PositionCommonId { get; set; }

    public string? PositionCommonName { get; set; }

    public long? SectionInstructionId { get; set; }

    public string? SectionInstructionName { get; set; }

    public string? Desc { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

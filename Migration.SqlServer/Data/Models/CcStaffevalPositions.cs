using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalPositions
{
    public long Id { get; set; }

    public long? NameCa { get; set; }

    public string? Name { get; set; }

    public string? NameId { get; set; }

    public string? SubdivisionName { get; set; }

    public long? SubdivisionId { get; set; }

    public string? DivisionName { get; set; }

    public long? DivisionId { get; set; }

    public long? StationId { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? LastEditionDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

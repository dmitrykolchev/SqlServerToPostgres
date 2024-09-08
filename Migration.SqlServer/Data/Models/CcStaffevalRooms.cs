using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalRooms
{
    public long Id { get; set; }

    public string? NumberBuilding { get; set; }

    public long? NameUtp { get; set; }

    public long? TypeRoom { get; set; }

    public string? NumberRoom { get; set; }

    public string? FunctionRoom { get; set; }

    public long? AreaRoom { get; set; }

    public long? NumberOfSeats { get; set; }

    public string? TypePc { get; set; }

    public string? TypeProjector { get; set; }

    public string? TypeBoard { get; set; }

    public string? TypeMonitor { get; set; }

    public long? Screen { get; set; }

    public long? MagnetoMarkerBoard { get; set; }

    public long? AudioSpeakers { get; set; }

    public long? StationId { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? EditDate { get; set; }

    public bool? InPlan { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

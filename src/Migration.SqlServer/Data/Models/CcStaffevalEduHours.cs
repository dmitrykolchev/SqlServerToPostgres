using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CcStaffevalEduHours
{
    public long Id { get; set; }

    public long? StationId { get; set; }

    public string? Categorie { get; set; }

    public DateTime? Date { get; set; }

    public double? VolumeUtp { get; set; }

    public double? VolumeSp { get; set; }

    public double? VolumeOu { get; set; }

    public double? VolumeTso { get; set; }

    public double? VolumeSs { get; set; }

    public string? Code { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

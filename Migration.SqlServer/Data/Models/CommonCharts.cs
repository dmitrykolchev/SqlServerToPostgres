using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class CommonCharts
{
    public string ChartId { get; set; } = null!;

    public string? ChartType { get; set; }

    public string? ChartSubtypes { get; set; }

    public string? ChartName { get; set; }

    public string? Icon { get; set; }

    public string? Xcolor { get; set; }

    public string? Xcolor2 { get; set; }

    public long? Xoverlap { get; set; }

    public string? XcolorLine { get; set; }

    public bool? FlagShowAxis { get; set; }

    public long? Thickness { get; set; }

    public bool? FlagColorDatapoints { get; set; }

    public bool? FlagRightAngleAxes { get; set; }

    public bool? FlagForeignCaption { get; set; }

    public bool? FlagShowPercent { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class PresenceStates
{
    public long Id { get; set; }

    public string? StateId { get; set; }

    public string? StateName { get; set; }

    public bool? Accessible { get; set; }

    public long? Position { get; set; }

    public string? StyleCss { get; set; }

    public bool? AllDay { get; set; }

    public bool? IsSubWorkTime { get; set; }
}

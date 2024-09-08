using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcEventThemes
{
    public long Id { get; set; }

    public long? EventId { get; set; }

    public string? ThemeId { get; set; }

    public long? Duration { get; set; }

    public string? Name { get; set; }

    public DateTime? Tdate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public long? LectorId { get; set; }

    public long? RoomId { get; set; }

    public string? EventForm { get; set; }

    public long? ThemeTid { get; set; }
}

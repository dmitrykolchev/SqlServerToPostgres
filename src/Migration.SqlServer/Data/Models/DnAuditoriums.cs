using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DnAuditoriums
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? NumberPlaces { get; set; }

    public long? PlaceId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}

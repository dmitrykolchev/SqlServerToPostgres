using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class EventTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? CustomWebTemplateId { get; set; }

    public long? SimplCustomWebTemplateId { get; set; }

    public bool? Online { get; set; }

    public bool? AutoStart { get; set; }

    public bool? CanUseCamera { get; set; }

    public bool? CanUseMicrophone { get; set; }

    public bool? Changed { get; set; }

    public bool? IsStd { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

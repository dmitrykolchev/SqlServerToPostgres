using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class DeviceRegs
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? DeviceId { get; set; }

    public DateTime? LastAccessDate { get; set; }

    public long? MobileAppConfigId { get; set; }

    public long? PersonId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }
}

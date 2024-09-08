﻿using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class OrgVendorStates
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? VendorStatusId { get; set; }

    public long? EducationOrgId { get; set; }

    public long? OrgId { get; set; }

    public string? VendorStatusTypeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? RecertificationDate { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class Contacts
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? ProjectId { get; set; }

    public long? TypeId { get; set; }

    public string? StatusId { get; set; }

    public long? ResultId { get; set; }

    public long? InitiatorPersonId { get; set; }

    public string? InitiatorPersonFullname { get; set; }

    public long? ContactPersonId { get; set; }

    public string? ContactPersonFullname { get; set; }

    public string? ContactOrgName { get; set; }

    public string? ContactPositionName { get; set; }

    public long? ContactOrgId { get; set; }

    public long? PreviousContactId { get; set; }

    public DateTime? ContactDate { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

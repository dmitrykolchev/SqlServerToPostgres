using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonnelDocumentTypes
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public List<string>? OrgSignatureTypes { get; set; }

    public List<string>? PersonSignatureTypes { get; set; }

    public bool? PersonFirstSignature { get; set; }

    public long? PrintFormId { get; set; }

    public long? CustomWebTemplateId { get; set; }

    public string? PersonnelEventCode { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? RoleId { get; set; }
}

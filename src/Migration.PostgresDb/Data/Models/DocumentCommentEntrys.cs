using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DocumentCommentEntrys
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? Deleted { get; set; }

    public string? How2show { get; set; }

    public string? AuthorInfo { get; set; }

    public long? UserId { get; set; }

    public string? PersonFullname { get; set; }

    public long? PortalDocId { get; set; }

    public long? ParentDocumentEntryId { get; set; }

    public DateTime? LastCreateDate { get; set; }

    public long? ChildNum { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

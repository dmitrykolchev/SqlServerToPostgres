using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class LibraryMaterials
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Author { get; set; }

    public long? SectionId { get; set; }

    public long? Year { get; set; }

    public string? Isbn { get; set; }

    public bool? HasDigital { get; set; }

    public bool? HasPhysical { get; set; }

    public bool? OnlineVideoPrepared { get; set; }

    public long? LibraryMaterialTypeId { get; set; }

    public string? LibraryMaterialFormats { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public string? UserAccessRole { get; set; }

    public long? UserGroupId { get; set; }

    public long? ResourceId { get; set; }

    public bool? AllowDownload { get; set; }

    public string? ExternalId { get; set; }

    public long? PreviousVersionObjectId { get; set; }

    public string? StatusInKnowledgeMap { get; set; }
}

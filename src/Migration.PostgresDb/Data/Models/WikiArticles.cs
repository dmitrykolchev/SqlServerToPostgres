using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class WikiArticles
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public long? WikiBaseId { get; set; }

    public long? WikiArticleTypeId { get; set; }

    public string? AcquaintTypeId { get; set; }

    public string? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public List<long>? AuthorId { get; set; }

    public DateTime? PublicateDate { get; set; }

    public DateTime? CriticalPublicateDate { get; set; }

    public List<long>? AcquaintGroupIds { get; set; }

    public string? Annotation { get; set; }

    public string? KnowledgeParts { get; set; }

    public string? Tags { get; set; }

    public string? Experts { get; set; }

    public List<long>? FilesId { get; set; }

    public string? CurrentHash { get; set; }

    public string? ProcessedEmbeddingHash { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }

    public List<long>? AccessGroupIds { get; set; }

    public bool? EnableAnonymousAccess { get; set; }
}

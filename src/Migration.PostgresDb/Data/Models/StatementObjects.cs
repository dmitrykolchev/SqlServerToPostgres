using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class StatementObjects
{
    public long Id { get; set; }

    public string? Path { get; set; }

    public string? ObjectId { get; set; }

    public string? ObjectType { get; set; }

    public long? StatementId { get; set; }

    public string? DefinitionType { get; set; }

    public string? DefinitionMoreInfo { get; set; }

    public string? DefinitionInteractionType { get; set; }

    public string? ContextActivityType { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class PersonalAssistants
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? ResourceId { get; set; }

    public bool? IsEnabled { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public string? Sex { get; set; }

    public List<long>? ChatbotIds { get; set; }
}

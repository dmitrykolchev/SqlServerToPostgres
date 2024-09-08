using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcScmtAssigns
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? Subdivision { get; set; }

    public string? QuestOne { get; set; }

    public string? QuestTwo { get; set; }

    public long? AverageTimeAnswer { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Finished { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

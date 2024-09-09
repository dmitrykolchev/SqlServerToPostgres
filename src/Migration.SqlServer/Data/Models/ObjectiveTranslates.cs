using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class ObjectiveTranslates
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public long? AssessmentAppraiseId { get; set; }

    public long? TranslatorPersonId { get; set; }

    public string? TranslatorPersonFullname { get; set; }

    public string? TranslatorObjectiveId { get; set; }

    public string? TranslatorObjectiveName { get; set; }

    public long? TranslatorPaId { get; set; }

    public long? RecipientPersonId { get; set; }

    public string? RecipientObjectiveId { get; set; }

    public string? RecipientObjectiveName { get; set; }

    public long? RecipientPaId { get; set; }

    public string? RecipientPersonFullname { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

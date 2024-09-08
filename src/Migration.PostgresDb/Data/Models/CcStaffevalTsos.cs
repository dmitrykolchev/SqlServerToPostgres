using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class CcStaffevalTsos
{
    public long Id { get; set; }

    public long? TypeTso { get; set; }

    public string? InfoTso { get; set; }

    public string? NameTso { get; set; }

    public string? TypeBrandNumTso { get; set; }

    public string? PurposeTso { get; set; }

    public long? InstallationLocation { get; set; }

    public string? CommissioningDocument { get; set; }

    public string? PersonalCategory { get; set; }

    public string? EquipmentInformation { get; set; }

    public DateTime? DateEquipmentInformation { get; set; }

    public string? PmtInformation { get; set; }

    public DateTime? DatePmtInformation { get; set; }

    public string? RequisitesProjectTso { get; set; }

    public long? StationId { get; set; }

    public long? CreatorId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? LastEditorId { get; set; }

    public DateTime? EditDate { get; set; }

    public short? InPlan { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

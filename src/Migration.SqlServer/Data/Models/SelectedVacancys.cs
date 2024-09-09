using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SelectedVacancys
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? VacancyId { get; set; }

    public string? VacancyName { get; set; }

    public long? PersonId { get; set; }

    public string? PersonFullname { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

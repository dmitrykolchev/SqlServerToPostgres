using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class DnGroupStudents
{
    public long Id { get; set; }

    public long? StudentId { get; set; }

    public long? PersonId { get; set; }

    public string? Lastname { get; set; }

    public string? Firstname { get; set; }

    public string? Middlename { get; set; }

    public string? Sex { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? MobilePhone { get; set; }

    public string? MobilePhoneConfCode { get; set; }

    public DateTime? MobilePhoneConfDate { get; set; }

    public bool? MobilePhoneConf { get; set; }

    public string? Email { get; set; }

    public string? EmailConfCode { get; set; }

    public DateTime? EmailConfDate { get; set; }

    public bool? EmailConf { get; set; }

    public string? SystemEmail { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? Comment { get; set; }

    public string? PersonFullname { get; set; }

    public long? SpecialId { get; set; }

    public long? SpecializationId { get; set; }

    public string? StatusId { get; set; }

    public long? MainGroupId { get; set; }

    public long? GroupId { get; set; }
}

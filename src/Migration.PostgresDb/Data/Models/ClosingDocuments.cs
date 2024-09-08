using System;
using System.Collections.Generic;

namespace Migration.PostgresDb.Data.Models;

public partial class ClosingDocuments
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? PayStageId { get; set; }

    public string? TypeId { get; set; }

    public double? Cost { get; set; }

    public string? CurrencyTypeId { get; set; }

    public string? Number { get; set; }

    public DateTime? ExpenseCreateDate { get; set; }

    public bool? IsFormed { get; set; }

    public DateTime? SentDate { get; set; }

    public string? Recipient { get; set; }

    public string? ConsignmentDocumentNumber { get; set; }

    public bool? IsReceived { get; set; }

    public long? ReceivingStatusId { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? DocsComment { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AppInstanceId { get; set; }
}

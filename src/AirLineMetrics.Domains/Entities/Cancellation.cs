namespace AirLineMetrics.Domain.Models
{
    public class Cancellation
    {
        public int CancellationId { get; set; }

        public int CancellationReasonId { get; set; }

        public int InvoiceId { get; set; }

        public decimal RefundAmount { get; set; }

        public DateTime CancellationDate { get; set; }

        public int SatisfactionEstimated { get; set; }


        public CancellationReason CancellationReason { get; set; } = null!;
        public Invoice Invoice { get; set; }
    }
}

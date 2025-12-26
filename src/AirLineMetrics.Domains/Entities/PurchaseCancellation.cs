namespace AirLineMetrics.Domain.Entities
{
    public class PurchaseCancellation
    {
        public int CancellationId { get; set; }
        public decimal RefundAmount { get; set; }
        public DateTime CancellationDate { get; set; }
        public int SatisfactionEstimated { get; set; }       
        public int CancellationReasonId { get; set; }
        public int InvoiceDetailId { get; set; }
        public CancellationReasson CancellationReassonNavigation { get; set; } = null!;
        public InvoiceDetail InvoiceDetailNavigation { get; set; } = null!;
    }
}

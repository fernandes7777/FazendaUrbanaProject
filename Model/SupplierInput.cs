namespace FazendaUrbana.Forms.Model
{
    public class SupplierInput
    {
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public int InputId { get; set; }
        public Input? Input { get; set; }

        public decimal PurchasePrice { get; set; }
        public string PaymentTerms { get; set; } = string.Empty;
    }
}
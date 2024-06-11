namespace FazendaUrbana.Forms.Model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TradeName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string TaxId { get; set; } = string.Empty;
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public int ContactId { get; set; }
        public Contact? Contact { get; set; }
        public float Rating { get; set; }

        // Navigation
        public ICollection<SupplierInput>? SupplierInputs { get; set; }
        public ICollection<SupplierCertificate>? SupplierCertificates { get; set; }
    }
}

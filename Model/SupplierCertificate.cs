namespace FazendaUrbana.Forms.Model
{
    public class SupplierCertificate
    {
        public Supplier? Supplier { get; set; }
        public int SupplierId { get; set; }

        public Certificate? Certificate { get; set; }
        public int CertificateId { get; set; }
    }
}
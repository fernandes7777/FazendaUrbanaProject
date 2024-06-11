namespace FazendaUrbana.Forms.Model
{
    public class Certificate
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public byte[]? File { get; set; }  // File data
        public string? FileType { get; set; }  // MIME type

        // Navigation
        public ICollection<SupplierCertificate>? SupplierCertificates { get; set; }
    }
}
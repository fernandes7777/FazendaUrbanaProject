namespace FazendaUrbana.Forms.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Other { get; set; }

        // Navigation
        public ICollection<Supplier>? Suppliers { get; set; }
    }
}
namespace FazendaUrbana.Forms.Model
{
    public class Input
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        // Navigation
        public ICollection<SupplierInput>? SupplierInputs { get; set; }
        public ICollection<ProductionInput>? ProductionInputs { get; set; }
    }
}
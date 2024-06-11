namespace FazendaUrbana.Forms.Model
{
    public class ProductionProduct
    {
        public int ProductionId { get; set; }
        public Production? Production { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int QuantityProduced { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
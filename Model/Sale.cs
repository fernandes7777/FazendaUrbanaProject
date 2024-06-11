using FazendaUrbana.Forms.Utils;

namespace FazendaUrbana.Forms.Model
{
    public class Sale
    {
        [CsvColumnName("Identificador da Venda")]
        public int Id { get; set; }

        [CsvColumnName("Quantidade")]
        public int Quantity { get; set; }

        [CsvColumnName("Data da Venda")]
        public DateTime SaleDate { get; set; }

        [CsvColumnName("Comprador")]
        public string Buyer { get; set; } = string.Empty;

        [CsvColumnName("Método de pagamento")]
        public string PaymentMethod { get; set; } = string.Empty;

        [CsvColumnName("Preço total")]
        public decimal? TotalPrice { get; set; }

        public Product? Product { get; set; }

        [CsvColumnName("Identificador do Produto")]
        public int ProductId { get; set; }
    }
}

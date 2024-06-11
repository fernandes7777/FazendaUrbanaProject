namespace FazendaUrbana.Forms.Model
{
    public class ProductionInput
    {
        public int ProductionId { get; set; }
        public Production? Production { get; set; }

        public int InputId { get; set; }
        public Input? Input { get; set; }

        public int QuantityUsed { get; set; }
    }
}
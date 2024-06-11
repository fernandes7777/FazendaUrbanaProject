using FazendaUrbana.Forms.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using static FazendaUrbana.Forms.Enum.Enums;

namespace FazendaUrbana.Forms.Model
{
    public class Production
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public string ProductionMethod { get; set; } = string.Empty;
        public CurrentState CurrentState { get; set; }

        [NotMapped]
        public string CurrentStateView
        {
            get
            {
                return EnumsList.GetCurrentStateEnum()?.FirstOrDefault(p => p.Enum == CurrentState)?.Description ?? string.Empty;
            }
        }

        public string ResourcesUsed { get; set; } = string.Empty;
        public string QualityControl { get; set; } = string.Empty;

        // Navigation
        public ICollection<ProductionProduct>? ProductionProducts { get; set; }
        public ICollection<ProductionInput>? ProductionInputs { get; set; }
    }
}

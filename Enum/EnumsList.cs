using FazendaUrbana.Forms.BaseObjects;
using static FazendaUrbana.Forms.Enum.Enums;

namespace FazendaUrbana.Forms.Enum
{
    public static class EnumsList
    {
        public static List<KeyDescriptionValue<CurrentState>> GetCurrentStateEnum()
        {
            var lst = new List<KeyDescriptionValue<CurrentState>>
            {
                new KeyDescriptionValue<CurrentState>(CurrentState.Stopped, "Parado", ""),
                new KeyDescriptionValue<CurrentState>(CurrentState.InProgress, "Em Andamento", ""),
                new KeyDescriptionValue<CurrentState>(CurrentState.Finished, "Finalizado", "")
            };

            return lst;
        }
    }
}

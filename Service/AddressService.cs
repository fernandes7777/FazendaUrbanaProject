using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;

namespace FazendaUrbana.Forms.Service
{
    public class AddressService
    {
        public Address GetById(int id)
        {
            using var context = new DbContextPrincipal();
            return context.Addresses.FirstOrDefault(p => p.Id == id) ?? new Address();
        }
    }
}

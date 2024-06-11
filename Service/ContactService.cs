using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;

namespace FazendaUrbana.Forms.Service
{
    public class ContactService
    {
        public Contact GetById(int id)
        {
            using var context = new DbContextPrincipal();
            return context.Contacts.FirstOrDefault(p => p.Id == id) ?? new Contact();
        }
    }
}

using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FazendaUrbana.Forms.Service
{
    public class SupplierService
    {
        /// <summary>
        /// Método que salvar fornecedor e relaciona a ele um endereço e um contato
        /// </summary>
        /// <returns></returns>
        public bool Save(Supplier supplier, Address address, Contact contact)
        {
            using var context = new DbContextPrincipal();

            // Iniciando uma transação explícita
            using var transaction = context.Database.BeginTransaction();
            try
            {
                if (address.Id > 0)
                    context.Addresses.Update(address);
                else
                    context.Addresses.Add(address);

                if (contact.Id > 0)
                    context.Contacts.Update(contact);
                else
                    context.Contacts.Add(contact);

                // Salvando as primeiras mudanças para garantir que temos os IDs de endereço e contato
                context.SaveChanges();

                if (supplier.Id > 0)
                {
                    supplier.AddressId = address.Id;
                    supplier.ContactId = contact.Id;
                    context.Suppliers.Update(supplier);
                }
                else
                {
                    supplier.AddressId = address.Id;
                    supplier.ContactId = contact.Id;
                    context.Suppliers.Add(supplier);
                }

                // Salvando todas as mudanças
                context.SaveChanges();
                transaction.Commit();  // Confirma a transação se tudo correu bem
                return true;
            }
            catch (DbUpdateException)
            {
                transaction.Rollback();
                return false;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public bool Delete(int supplierId)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var supplier = context.Suppliers.FirstOrDefault(p => p.Id == supplierId);
                if (supplier != null)
                {
                    context.Suppliers.Remove(supplier);
                    context.SaveChanges();
                    transaction.Commit();
                }

                return true;
            }
            catch (DbException)
            {
                transaction.Rollback();
                return false;
            }
            catch (Exception)
            {
                transaction.Rollback();
                return false;
            }
        }

        public List<Supplier> GetAll()
        {
            using var context = new DbContextPrincipal();
            return context.Suppliers.ToList();
        }
    }
}

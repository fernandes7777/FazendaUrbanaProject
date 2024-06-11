using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FazendaUrbana.Forms.Service
{
    public class SaleService
    {
        public bool Save(Sale sale)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();

            try
            {

                if (sale.Id > 0)
                {
                    context.Update(sale);
                }
                else
                {
                    context.Sales.Add(sale);
                }

                context.SaveChanges();
                transaction.Commit();
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

        public List<Sale> GetAll()
        {
            using var context = new DbContextPrincipal();
            return context.Sales.ToList();
        }

        internal bool Delete(int productId)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var sale = context.Sales.FirstOrDefault(p => p.Id == productId);
                if (sale != null)
                {
                    context.Sales.Remove(sale);
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
    }
}

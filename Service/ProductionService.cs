using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FazendaUrbana.Forms.Service
{
    public class ProductionService
    {
        public bool Save(Production production)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();

            try
            {
                if (production.Id > 0)
                {
                    context.Update(production);
                }
                else
                {
                    context.Productions.Add(production);
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

        public List<Production> GetAll()
        {
            using var context = new DbContextPrincipal();
            return context.Productions.ToList();
        }

        internal bool Delete(int productionId)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var production = context.Productions.FirstOrDefault(p => p.Id == productionId);
                if (production != null)
                {
                    context.Productions.Remove(production);
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

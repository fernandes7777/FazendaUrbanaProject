using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FazendaUrbana.Forms.Service
{
    public class InputService
    {
        public bool Save(Input input)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();

            try
            {

                if (input.Id > 0)
                {
                    context.Update(input);
                }
                else
                {
                    context.Inputs.Add(input);
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

        public List<Input> GetAll()
        {
            using var context = new DbContextPrincipal();
            return context.Inputs.ToList();
        }

        internal bool Delete(int inputId)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var input = context.Inputs.FirstOrDefault(p => p.Id == inputId);
                if (input != null)
                {
                    context.Inputs.Remove(input);
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

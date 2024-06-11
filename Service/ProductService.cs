using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FazendaUrbana.Forms.Service
{
    public class ProductService
    {
        public bool Save(Product product)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();

            try
            {

                if (product.Id > 0)
                {
                    context.Update(product);
                }
                else
                {
                    context.Products.Add(product);
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

        public List<Product> GetAll()
        {
            using var context = new DbContextPrincipal();
            return context.Products.ToList();
        }

        internal bool Delete(int productId)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var product = context.Products.FirstOrDefault(p => p.Id == productId);
                if (product != null)
                {
                    context.Products.Remove(product);
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

        public Product GetById(int id)
        {
            using var context = new DbContextPrincipal();
            return context.Products.FirstOrDefault(p => p.Id == id) ?? new Product();
        }
    }
}

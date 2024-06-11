using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FazendaUrbana.Forms.Service
{
    public class ProductionProductService
    {
        public bool Save(ProductionProduct productionProduct)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();

            try
            {
                var productionProductOriginal = context.ProductionProducts.FirstOrDefault(p => p.ProductId == productionProduct.ProductId && p.ProductionId == productionProduct.ProductionId);
                if (productionProductOriginal == null)
                {
                    context.ProductionProducts.Add(productionProduct);
                }
                else if (productionProduct.QuantityProduced != productionProductOriginal.QuantityProduced || productionProduct.TotalPrice != productionProductOriginal.TotalPrice)
                {
                    context.Update(productionProduct);
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

        public List<ProductionProduct> GetAll()
        {
            using var context = new DbContextPrincipal();
            return context.ProductionProducts.ToList();
        }

        internal bool Delete(int productionId, int productId)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var productionProduct = context.ProductionProducts.FirstOrDefault(p => p.ProductionId == productionId && p.ProductId == productId);
                if (productionProduct != null)
                {
                    context.ProductionProducts.Remove(productionProduct);
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

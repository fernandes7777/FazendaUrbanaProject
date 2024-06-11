using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Model.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FazendaUrbana.Forms.Service
{
    public class SupplierInputService
    {
        public bool Save(SupplierInput supplierInput)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();

            try
            {
                var supplierInputOriginal = context.SupplierInputs.FirstOrDefault(p => p.InputId == supplierInput.InputId && p.SupplierId == supplierInput.SupplierId);
                if (supplierInputOriginal == null)
                {
                    context.SupplierInputs.Add(supplierInput);
                }
                else if (supplierInput.PurchasePrice != supplierInputOriginal.PurchasePrice || supplierInput.PaymentTerms != supplierInputOriginal.PaymentTerms)
                {
                    context.Update(supplierInput);
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

        public List<SupplierInput> GetAll()
        {
            using var context = new DbContextPrincipal();
            return context.SupplierInputs.ToList();
        }

        internal bool Delete(int inputId, int supplierId)
        {
            using var context = new DbContextPrincipal();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var supplierInput = context.SupplierInputs.FirstOrDefault(p => p.InputId == inputId && p.SupplierId == supplierId);
                if (supplierInput != null)
                {
                    context.SupplierInputs.Remove(supplierInput);
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

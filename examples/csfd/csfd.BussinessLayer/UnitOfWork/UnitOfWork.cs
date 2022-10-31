using csfd.BussinessLayer.Models;
using csfd.DataLayer;

namespace csfd.BussinessLayer.UniCustomerOfWork
{
    public class UnitOfWork
    {
        private List<Customer> created = new List<Customer>();
        private List<Customer> dirty = new List<Customer>();
        private List<Customer> removed = new List<Customer>();

        public void RegisterCreated(Customer entity)
        {
            created.Add(entity);
        }

        public void RegisterDirty(Customer entity)
        {
            dirty.Add(entity);
        }

        public void RegisterRemoved(Customer entity)
        {
            removed.Add(entity);
        }

        public void Rollback()
        {
            created.Clear();
            dirty.Clear();
            removed.Clear();
        }

        public void Commit()
        {
            var gateway = new CustomerTableDataGateway();
            foreach (var customer in created)
            {
                // gateway.Create();
            }

            foreach (var customer in dirty)
            {
                // gateway.Update();
            }

            foreach (var customer in removed)
            {
                // gateway.Delete();
            }

        }
    }
}

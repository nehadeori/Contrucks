using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrucks.Repository.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private CustomerContext dataContext;
        public CustomerContext Get()
        {
            return dataContext ?? (dataContext = new CustomerContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMS.IMS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DataBaseContext dbContext;

        public DataBaseContext Init()
        {
            return dbContext ?? (dbContext = new DataBaseContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}

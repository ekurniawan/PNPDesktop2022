using POSApplication.FrontEnd.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApplication.FrontEnd.Repository
{
    public class DapperContext : IDapperContext
    {
        public IDbConnection db => throw new NotImplementedException();

        public IDbTransaction transaction => throw new NotImplementedException();

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool ExecSQL(string sql)
        {
            throw new NotImplementedException();
        }

        public string GetGUID()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenConnection()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}

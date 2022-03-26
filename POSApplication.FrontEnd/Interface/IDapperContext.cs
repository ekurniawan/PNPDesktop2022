using System;
using System.Data;


namespace POSApplication.FrontEnd.Interface
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection db { get; }
        IDbTransaction transaction { get; }
        bool IsOpenConnection();
        bool ExecSQL(string sql);

        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);
        void Commit();
        void Rollback();

        string GetGUID();
    }
}

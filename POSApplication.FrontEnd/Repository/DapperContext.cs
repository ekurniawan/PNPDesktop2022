using POSApplication.FrontEnd.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using Dapper;

namespace POSApplication.FrontEnd.Repository
{
    public class DapperContext : IDapperContext
    {
        private IDbConnection _db;
        private readonly string _connStr;
        private readonly string _providerName;

        public IDbConnection db
        {
            get { return _db ?? (_db=GetOpenConnection(_connStr,_providerName)); }
        }

        public IDbTransaction transaction => throw new NotImplementedException();

        public DapperContext()
        {
            _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _providerName = ConfigurationManager.ConnectionStrings["DefaultConnection"].ProviderName;

            if (_db == null)
            {
                _db = GetOpenConnection(_connStr, _providerName);
            }
        }

        private IDbConnection GetOpenConnection(string connStr,string providerName)
        {
            DbConnection conn = null;
            try
            {
                DbProviderFactory provider = DbProviderFactories.GetFactory(providerName);
                conn = provider.CreateConnection();
                conn.ConnectionString = connStr;
                conn.Open();
            }
            catch
            {}

            return conn;
        }

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            throw new NotImplementedException();
        }
        public void Commit()
        {
            throw new NotImplementedException();
        }
        public void Rollback()
        {
            throw new NotImplementedException();
        }



        public void Dispose()
        {
            if(_db != null)
            {
                try
                {
                    if(_db.State != ConnectionState.Closed)
                    {
                        _db.Close();
                    }
                }
                finally
                {
                    _db.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }

        public bool ExecSQL(string sql)
        {
            var result = false;
            try
            {
                _db.Execute(sql);
                result = true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public string GetGUID()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenConnection()
        {
            var isConnected = false;
            try
            {
                using(var conn = GetOpenConnection(_connStr,_providerName))
                {
                    isConnected = conn.State == ConnectionState.Open;
                }
            }
            catch { }
            return isConnected;
        }

       
    }
}

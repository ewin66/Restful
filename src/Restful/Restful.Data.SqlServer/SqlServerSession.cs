﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restful.Data.SqlServer
{
    public class SqlServerSession : ISession
    {
        private SqlServerSessionProvider provider;

        public SqlServerSession( ISessionProviderFactory factory, string connectionStr )
        {
            this.provider = new SqlServerSessionProvider( factory, connectionStr );
        }

        public int CommandTimeout
        {
            get
            {
                return this.provider.CommandTimeout;
            }
            set
            {
                this.provider.CommandTimeout = value;
            }
        }

        public ISessionProvider Provider
        {
            get { return this.provider; }
        }

        public void Dispose()
        {
            this.provider.Dispose();
        }
    }
}

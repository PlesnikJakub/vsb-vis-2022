﻿using System.Data.SqlClient;

namespace csfd.DataLayer
{
    public static class DBConnector
    {
        public static SqlConnectionStringBuilder GetBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"dbsys.cs.vsb.cz\STUDENT";   // update me
            builder.UserID = "ple0049";              // update me
            builder.Password = "aaa";      // update me
            builder.InitialCatalog = "ple0049";
            return builder;
        }
    }
}

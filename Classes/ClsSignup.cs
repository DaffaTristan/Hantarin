using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Odbc;
using Hantarin.Classes;


namespace Hantarin.Classes
{
    public class ClsSignup
    {
        public static DataTable DtSignup(string First_Name, string Last_Name, string Email, string Password)
        {
            DataTable Dt = new DataTable();
            OdbcConnection OdbcConn = new OdbcConnection(ClsModule.Conn.ToString());
            OdbcCommand cmd = new OdbcCommand();
            OdbcCommand cmd1 = new OdbcCommand();
            OdbcDataAdapter da = new OdbcDataAdapter();

            OdbcConn.Open();
            cmd.Connection = OdbcConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO user (First_Name, Last_Name, Email, Password) VALUES('" + First_Name + "', '" + Last_Name + "', '" + Email + "', '" + Password + "'); ";
            da.SelectCommand = cmd;
            da.Fill(Dt);
            OdbcConn.Close();
            return Dt;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Odbc;
using System.Configuration;

namespace Hantarin.Classes
{
    public class ClsModule
    {
        public static string Conn = ConfigurationManager.ConnectionStrings["Koneksi"].ConnectionString;
    }
}
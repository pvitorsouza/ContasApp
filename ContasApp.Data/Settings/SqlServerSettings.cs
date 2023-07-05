using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasApp.Data.Settings
{
    public class SqlServerSettings
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDContasApp;Integrated Security=True;";
        }

    }
}

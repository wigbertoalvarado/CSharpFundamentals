using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DAL.Interfaces;

namespace DAL
{
    public class Operations : IOperations
    {
       private String connectionString = $"Server={ConfigurationManager.AppSettings["ServerName"]};"
            + $"Database={ConfigurationManager.AppSettings["Database"]};"
            + $"Integrated Security={ConfigurationManager.AppSettings["IntegratedSecurity"]}";

        private void UpdateState();
    }
}

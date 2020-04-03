using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLogger
{
    class GlobalVars
    {
        private MySqlConnection connection;

        public MySqlConnection MyDBConnection
        {
            get
            {
                return connection;
            }
            set
            {
                connection = value;
            }
        }
    }
}

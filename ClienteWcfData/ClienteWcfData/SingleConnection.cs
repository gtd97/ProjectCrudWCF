using ClienteWcfData.ReferenciaWeb;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWcfData
{
    public class SingleConnection
    {
        private static SingleConnection _instance;

        protected SingleConnection()
        {

        }

        public static SingleConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new SingleConnection();
            }

            return _instance;
        }

    }
}

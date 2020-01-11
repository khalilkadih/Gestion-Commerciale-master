using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_Commerciale.BL
{
    class Client
    {
        DAL.DataAccessLayer db = new DAL.DataAccessLayer();
        public DataTable SelectDataClient()
        {
            return db.SelectData("SelectDataClient",null);
        }
        
    }
}

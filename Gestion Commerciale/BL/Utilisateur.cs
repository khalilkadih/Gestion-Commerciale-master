using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_Commerciale.BL
{
    class Utilisateur
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public void Login(string utilisateur, string pwd, out bool ok)
        {
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[3];

            //Pour la parametre @utilisateur
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@utilisateur";
            param1.SqlDbType = SqlDbType.VarChar;
            param1.Size = 50;
            param1.Value = utilisateur;
            param[0] = param1;

            //Pour la parametre @pwd
            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@pwd";
            param2.SqlDbType = SqlDbType.VarChar;
            param2.Size = 50;
            param2.Value = pwd;
            param[1] = param2;

            //Pour la parametre @pwd
            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@ok";
            param3.SqlDbType = SqlDbType.Int;
            param3.Direction = ParameterDirection.Output;
            param[2] = param3;

            dal.SelectData("spLogintest",param);

            ok = param3.Value.ToString() == "1" ? true : false ;
        }
    }
}

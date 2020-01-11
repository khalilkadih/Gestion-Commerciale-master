using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_Commerciale.DAL
{
    public class DataAccessLayer
    {
        // Declaration des Objet
        public string connectionString = $@"Data Source=.; Initial Catalog = GestionCommercial; Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection();

        // Constructeur des initialisation
        public DataAccessLayer()
        {
            sqlConnection.ConnectionString = connectionString;
        }

        // Methode Open pour ouvrir la connexion
        public void OpenConnection()
        {
            if(sqlConnection.State != ConnectionState.Open) {
                sqlConnection.Open();
            }
        }

        // Methode Close pour fermer la connexion
        public void CloseConnection()
        {
            if(sqlConnection.State == ConnectionState.Open) {
                sqlConnection.Close();
            }
        }

        // Methode SelectData pour selectionner les donnees de base de donnees
        public DataTable SelectData(string storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCmd = new SqlCommand();
            SqlDataAdapter sqlDa = new SqlDataAdapter(); // ou Utilise sqlDataReader
            DataTable dt = new DataTable();

            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = storedProcedure;
            if(param != null) {
                sqlCmd.Parameters.AddRange(param);
            }
            sqlCmd.Connection = sqlConnection;

            sqlDa.SelectCommand = sqlCmd;
            sqlDa.Fill(dt);

            return dt;
        }

        // Methode IUDData pour Ajouter, Modifier et supprimer les donnees de base de donnees (IUD = Insert Update Delete)
        public void IUDData(string storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = storedProcedure;
            if(param != null) {
                sqlCmd.Parameters.AddRange(param);
            }
            sqlCmd.Connection = sqlConnection;

            sqlCmd.ExecuteNonQuery();
        }
    }
}

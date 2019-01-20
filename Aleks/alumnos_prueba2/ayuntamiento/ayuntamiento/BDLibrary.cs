using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;

namespace BDLibrary
{
    public class BDLibrary
    {
        public string origen_datos;
        public string cadenaConexion;
        public string cadenaConexionSQLNCLI;

        public BDLibrary()
        {
            
        }

        public List<object[]> Select(string consultaSelect)
        {
            
            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;

            List<object[]> res = new List<object[]>();
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand(consultaSelect, conexion);

            conexion.Open();
            DbDataReader reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                int numColumnas = reader.FieldCount;
                object[] fila = new object[numColumnas];
                for (int i = 0; i < numColumnas; ++i) fila[i] = reader[i];
                res.Add(fila);
            }

            conexion.Close();

            
            return res;
        }

        public object SelectScalar(string consultaSelect)
        {

            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;

          
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand(consultaSelect, conexion);

            conexion.Open();
            object res = comando.ExecuteScalar();

            conexion.Close();


            return res;
        }

        public void Update(string cadenaUpdate)
        {
            if (cadenaUpdate.Length == 0) return;

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand(cadenaUpdate, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Delete(string cadenaDelete)
        {
            if (cadenaDelete.Length == 0) return;

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);
            OleDbCommand comando = new OleDbCommand(cadenaDelete, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Insert(string cadenaInsert)
        {
            if (cadenaInsert.Length == 0) return;

            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            OleDbCommand comando = new OleDbCommand(cadenaInsert, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EjecutaProcedimiento(string name, SqlParameter[] param)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexionSQLNCLI);
            SqlCommand comando = new SqlCommand(name, conexion);
            foreach (SqlParameter p in param)
            {
                comando.Parameters.Add(p);
            }
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }

    public class AccessDB : BDLibrary
    {
        public AccessDB(string pathBD)
        {
            origen_datos = pathBD;
            cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0; "
                    + "Data Source=" + pathBD;
        }
    }

    public class AccessDB2007 : BDLibrary
    {

        public AccessDB2007(string pathBD)
        {
            origen_datos = pathBD;
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0; "
                    + "Data Source=" + pathBD;
        }
    }

    public class SQLSERVERDB : BDLibrary
    {
        public SQLSERVERDB(string server, string BD)
        {
            origen_datos = BD;

            cadenaConexion = "Provider=SQLOLEDB;Data Source=" + server + "\\SQLEXPRESS;"
                + "Integrated Security=SSPI;Initial Catalog=" + BD;
            cadenaConexionSQLNCLI = "Data Source=" + server + "\\SQLEXPRESS;"
                + "Integrated Security=SSPI;Initial Catalog=" + BD;
        }
    }


}

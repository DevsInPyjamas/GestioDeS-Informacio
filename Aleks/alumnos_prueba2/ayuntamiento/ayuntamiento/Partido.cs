using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace ayuntamiento
{
    public class Partido
    {
        private string siglas;
        private string nombre;
        private List<Concejal> ediles;

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public static List<Partido> ListaPartidos()
        {
            List<Partido> lista = new List<Partido>();
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] row in dbManager.Select("select siglas from tPartido;")) lista.Add(new Partido((string)row[0]));
            return lista;
        }

        public Partido(string siglas)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] row = dbManager.Select("select * from tPartido where siglas = '" + siglas + "';")[0];
            this.siglas = siglas;
            this.nombre = (string)row[1];
        }

        public Partido(string siglas, string nombre)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Insert("Insert into tPartido(siglas, nombre) values ('" + siglas + "', '" + nombre + "');");
            this.siglas = siglas;
            this.nombre = nombre;
        }

        public string Siglas
        {
            get { return siglas; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tPartido set siglas = '" + value + "' where siglas = '" + siglas + "';");
                this.siglas = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tPartido set nombre = '" + value + "' where siglas = '" + siglas + "';");
                this.nombre = value;
            }
        }

        public List<Concejal> Ediles
        {
            get 
            {
                this.ediles = new List<Concejal>();
                this.CargarEdiles();
                return ediles; 
            }
            // No se permite asignar la lista de ediles
        }

        private void CargarEdiles()
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] row in dbManager.Select("select id from tConcejal where siglas = '" + siglas + "';"))
                this.ediles.Add(new Concejal((int)row[0]));
        }

        public override string ToString()
        {
            return Nombre + " (" + Siglas + ")";
        }

    }
}

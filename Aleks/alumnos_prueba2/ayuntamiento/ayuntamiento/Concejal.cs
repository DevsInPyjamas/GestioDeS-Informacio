using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace ayuntamiento
{
    public class Concejal
    {
        private int id;
        private string siglas;
        private string nombre;

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public static List<Concejal> ListaConcejales(string siglas)
        {
            List<Concejal> lista = new List<Concejal>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (object[] tupla in miBD.Select("SELECT ID FROM tConcejal Where siglas = '" 
                                                    + siglas + "';"))
            {
                int id = (int)tupla[0];
                Concejal c = new Concejal(id);
                lista.Add(c);
            }
            return lista;
        }

        public Concejal(int id)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM tConcejal WHERE ID=" + id + ";")[0];

            this.id = (int)tupla[0];
            this.siglas = (string)tupla[1];
            this.nombre = (string)tupla[2];
        }

        public Concejal(string siglas, string nombre)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO tConcejal VALUES('" + siglas + "', '" + nombre + "');");

            this.id = (int)miBD.SelectScalar("SELECT MAX(ID) FROM tConcejal;");
            this.siglas = siglas;
            this.nombre = nombre;
        }

        public void causarBaja()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE tConcejal WHERE ID=" + id + ";");

            this.id = -1;
            this.siglas = "";
            this.nombre = "";
        }

        public string Siglas
        {
            get { return siglas; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tConcejal SET siglas = '" + value + "' WHERE ID=" + this.id + ";");
                siglas = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tConcejal SET nombre = '" + value + "' WHERE ID=" + this.id + ";");
                nombre = value;
            }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}

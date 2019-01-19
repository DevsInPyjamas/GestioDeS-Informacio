using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace HIS
{
    public class Pais
    {
        private string cod;
        private string des;

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public static List<Pais> ListaPaises()
        {
            List<Pais> lista = new List<Pais>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (object[] tupla in miBD.Select("SELECT Codigo FROM tPais;"))
            {
                string id = (string)tupla[0];
                Pais p = new Pais(id);
                lista.Add(p);
            }

            return lista;
        }

        public Pais(string cod)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM tPais WHERE Codigo='" + cod + "';")[0];

            this.cod = (string)tupla[0];
            this.des = (string)tupla[1];
        }

        public Pais(string cod, string des)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Insert("INSERT INTO tPais VALUES('" + cod + "', '" + des + "');");
            this.cod = cod;
            this.des = des;
        }

        public string Codigo
        {
            get { return cod; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPais SET Codigo = '" + value
                    + "' WHERE Codigo='" + this.cod + "';");
                cod = value;
            }
        }

        public string Descripcion
        {
            get { return des; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPais SET Descripcion = '" + value
                    + "' WHERE Codigo='" + this.cod + "';");
                des = value;
            }
        }

        public void BorrarPais()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE FROM tPais WHERE Codigo='" + cod + "';");

            this.cod = null;
            this.des = null;
        }

        public override string ToString()
        {
            return des;
        }

        public override bool Equals(object obj)
        {
            return obj is Pais && (((Pais)obj).Codigo.CompareTo(this.Codigo) == 0);
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }
    }
}

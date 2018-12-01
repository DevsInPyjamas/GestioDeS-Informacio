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

        public static List<Pais> ListaPaises() {
            List<Pais> lista = new List<Pais>();
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach(object[] tuple in bd.Select("select codigo, descripcion from tPais;")) {
                lista.Add(new Pais((string) tuple[0]));
            }
            return lista;
        }

        public Pais(string cod) {
            SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tuple = db.Select("SELECT * FROM tPais WHERE codigo = '" + cod + "';")[0];
            this.cod = (string) tuple[0];
            des = (string) tuple[1];
        }

        public Pais(string cod, string des){
            SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
            db.Insert("insert into tPais (codigo, descripcion) values ('" + cod + "', '" + des + "');");
            this.cod = cod;
            this.des = des;
        }

        public string Codigo
        {
            get { return cod; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPais set codigo = '" + value + "' where codigo = '" + cod + "';");
                cod = value;
            }
        }

        public string Descripcion
        {
            get { return des; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("udate tPais set descripcion = '" + value + "' where codigo = '" + cod + "';");
                des = value;
            }
        }

        public void BorrarPais(string cod) {
            SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
            db.Delete("Delete from tPais where codigo = '" + cod + "';");
        }

        public override string ToString() {
            return des;
        }

        public override bool Equals(object obj) {
            return obj is Pais && (((Pais)obj).Codigo.CompareTo(this.Codigo) == 0);
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }
    }
}

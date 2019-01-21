using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace Prueba_2
{
    class Laboratorio
    {
        private static string BD_NAME = Prueba_2.Properties.Settings.Default.BD_NAME;
        private static string BD_SERVER = Prueba_2.Properties.Settings.Default.BD_SERVER;

        private int id_lab;
        private string name;

        public static List<Laboratorio> ListaLaboratorios()
        {
            List<Laboratorio> labList = new List<Laboratorio>();
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach(Object[] row in dbManager.Select("select id_laboratorio from tLaboratorio")) labList.Add(new Laboratorio((int) row[0]));
            return labList;
        }

        public Laboratorio(int id_lab)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] row = dbManager.Select("select * from tLaboratorio where id_laboratorio =" + id_lab + ";")[0];
            this.id_lab = id_lab;
            this.name = (string)row[1];
         }

        public Laboratorio(string nombre)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Insert("Insert into tLaboratorio(nombre) values ('" + nombre + "');");
            id_lab = (int)dbManager.Select("select max(id) from tLaboratorio")[0][0];
            this.name = nombre;
        }

        public void DeleteThis()
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Delete("delete from tLaboratorio where id_laboratorio = " + this.id_lab + ";");
            this.name = null;
            this.id_lab = -1;
        }

        public int ID
        {
            get
            {
                return id_lab;
            }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tLaboratorio set id_laboratorio = " + value + " where id_laboratorio = " + this.id_lab + ";");
                this.id_lab = value;
            }
        }

        public string Nombre
        {
            get
            {
                return name;
            }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tLaboratorio set nombre_laboratorio = '" + value + "' where id_laboratorio = " + this.id_lab + ";");
                this.name = value;
            }
        }

        public override string ToString()
        {
            return "" + this.Nombre + ": " + this.id_lab + ";";
        }

        public override bool Equals(object obj)
        {
            return obj is Laboratorio && ((Laboratorio) obj).ID.CompareTo(this.ID) == 0;
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }

}

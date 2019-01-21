using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDLibrary;

namespace Prueba_2
{
    class Medicamento
    {
        private static string BD_NAME = Prueba_2.Properties.Settings.Default.BD_NAME;
        private static string BD_SERVER = Prueba_2.Properties.Settings.Default.BD_SERVER;

        private int id;
        private string nombre;

        private int cantidad;

        private Laboratorio laboratorio_id;

        public static List<Medicamento> ListaMedicamentos()
        {
            List<Medicamento> medList = new List<Medicamento>();
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] row in dbManager.Select("")) medList.Add(new Medicamento((int)row[0]));
            return medList;
        }

        public Medicamento(int id)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] pastanaga = dbManager.Select("select * from tMedicamento where id_medicamento = " + id + ";")[0];
            this.id = (int)pastanaga[0];
            this.nombre = (string)pastanaga[1];
            this.cantidad = (int)pastanaga[2];
            this.laboratorio_id = new Laboratorio((int)pastanaga[3]);
        }

        public Medicamento(int id, string nombre, int cantidad, Laboratorio lab)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Insert("insert into tMedicamento(id_medicamento, nombre_medicamento, cantidad_disponible, laboratorio) values" +
            "(" + id + ", '" + nombre + "', " + cantidad + ", " + lab.ID + ");");
            this.id = id;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.laboratorio_id = lab;
        }

        public void DeleteThis()
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Delete("delete from tMedicamento where id_medicamento = " + this.id + ";");
            this.id = -1;
            this.laboratorio_id = null;
            this.nombre = null;
            this.cantidad = -1;
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tMedicamento set id_medicamento = " + value + " where id_medicamento = " + this.id + ";");
                this.id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tMedicamento set nombre_medicamento = " + value + " where id_medicamento = " + this.id + ";");
                this.nombre = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tMedicamento set cantidad_disponible = " + value + " where id_medicamento = " + this.id + ";");
                this.cantidad = value;
            }
        }

        public Laboratorio Laboratorio
        {
            get
            {
                return laboratorio_id;
            }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tMedicamento set laboratorio = " + value.ID + " where id_medicamento = " + id + ";");
                this.laboratorio_id = value;
            }
        }
    }
}

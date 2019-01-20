using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using CPais;

namespace Prueba2Lunes
{
    class Producto
    {
        private static string BD_SERVER = Properties.Settings.Default.SERVER_NAME;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int codigo;
        private string nombre;
        private Pais pais;

        public static List<Producto> ListaProducto()
	    {
		    List<Producto> lista = new List<Producto>(); 
		    // Retorna una lista con todos los objetos de la clase almacenados en la base de datos
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] row in dbManager.Select("select codigo from tProducto;")) lista.Add(new Producto((int)row[0]));
		    return lista;
	    }

        public Producto(int id)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] row = dbManager.Select("select * from tProducto where codigo = " + id + ";")[0];
            this.codigo = id;
            this.nombre = (string) row[1];
            this.pais = new Pais((string)row[2]);
        }

        public Producto(int cod, string name, Pais p)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Insert("Insert into tProducto(codigo, nombre, pais) values (" + cod + ", '" + name
                + "', '" + p.Codigo + "');");
            this.codigo = cod;
            this.nombre = name;
            this.pais = p;
        }

        public int CODIGO
        {
            get { return codigo; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tProducto set codigo = " + value + " where codigo = " + codigo + ";");
                this.codigo = value;
            }
        }

        public string NOMBRE
        {
                get { return nombre; }
                set
                {
                    SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    dbManager.Update("update tProducto set nombre =  '" + value + "' where codigo = " + codigo + ";");
                    this.nombre = value;
                }
        }

        public Pais PAIS
        {
            get { return pais; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tProducto set pais =  '" + value.Codigo + "' where codigo = " + codigo + ";");
                this.pais = value;
            }
        }

        public void BorrarProducto()
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Delete("Delete from tProducto where codigo = " + this.codigo + ";");
            this.nombre = null;
            this.pais = null;
            this.codigo = -1;
        }
    }
}

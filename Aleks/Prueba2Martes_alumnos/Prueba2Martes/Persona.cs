using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;
using CPais;

namespace Prueba2Martes
{
    class Persona
    {
        private static string BD_SERVER = Properties.Settings.Default.SERVER_NAME;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string nif;
        private string nombre;
        private Pais pais;

        public static List<Persona> ListaProducto()
	    {
		    List<Persona> lista = new List<Persona>();
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (Object[] row in dbManager.Select("select id from tPersona"))
            {
                lista.Add(new Persona((string) row[0]));
            }
		    return lista;
	    }

        
        public Persona(string id)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            Object[] tuples = dbManager.Select("select * from tPersona where nif = '" + id + "';")[0];
            this.nif = id;
            this.nombre = (string)tuples[1];
            this.pais = new Pais((string) tuples[2]);
        }

        public Persona(string cod, string name, Pais p)
        {
            this.nif = cod;
            this.nombre = name;
            this.pais = p;
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Insert("insert into tPersona(nif, nombre, pais) values ('" + this.nif + "', '" + 
                this.nombre + "' , '" + this.pais.Codigo + "');");
        }

        public string NIF
        {
            get { return nif; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tPersona set nif = '" + value + "' where nif = '" + nif + "';");
                this.nif = value;
            }
        }

        public string NOMBRE
        {
                get { return nombre; }
                set
                {
                    SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    dbManager.Update("update tPersona set nombre = '" + value + "' where nif = '" + nif + "';");
                    this.nombre = value;
                }
        }

        public Pais PAIS
        {
            get { return pais; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tPersona set pais = '" + value.Codigo + "' where nif = '" + nif + "';");
                this.pais = value;
            }
        }

        public void BorrarPersona()
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Update("delete from tPersona where nif = '" + nif + "';");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace HIS
{
    public class Permiso
    {

        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string rolName;
        private string pantalla;
        private bool acceso;
        private bool modificacion;


        public static List<Permiso> ListaPermisosRol(string rolName)
        {
		    List<Permiso> lista = new List<Permiso>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT pantalla FROM tPermiso WHERE rolName = '" + rolName + "';"))
            {
                string pantalla = (string)tupla[0];
                lista.Add(new Permiso(rolName, pantalla));
            }
		    return lista;
        }

        public Permiso(String r, String p)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM tPermiso WHERE rolName = '" 
                            + r + "' AND pantalla = '" + p + "';")[0];
            rolName = (string)tupla[0];
            pantalla = (string)tupla[1];
            acceso = (bool)tupla[2];
            modificacion = (bool)tupla[3];
        }

        public Permiso(string r, string p, bool a, bool m)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            miBD.Insert("INSERT INTO tPermiso VALUES('" + r + "', '"
                + p + "', " + (a ? 1 : 0) + ", " + (m ? 1 : 0) + ");");

            rolName = r;
            pantalla = p;
            acceso = a;
            modificacion = m;
        }

        public void BorrarPermiso()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("DELETE tPermiso"
                    + "  WHERE rolName = '" + rolName
                    + "' AND pantalla = '" + pantalla + "';");
            rolName = pantalla = null;
            acceso = modificacion = false;
        }

        public string RolName
        {
            get { return rolName; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPermiso SET rolName = '" + value 
                        + "' WHERE rolName = '" + rolName 
                        + "' AND pantalla = '" + pantalla + "';");
                rolName = value;
            }
        }

        public string Pantalla
        {
            get { return pantalla; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPermiso SET pantalla = '" + value
                        + "' WHERE rolName = '" + rolName
                        + "' AND pantalla = '" + pantalla + "';");
                pantalla = value;
            }
        }

        public bool Acceso
        {
            get { return acceso; }
            set {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("UPDATE tPermiso SET acceso = " + (value?1:0)
                            + " WHERE rolName = '" + rolName
                            + "' AND pantalla = '" + pantalla + "';");
                    acceso = value; 
                }
        }

        public bool Modificacion
        {
            get { return modificacion; }
            set {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("UPDATE tPermiso SET modificacion = " + (value ? 1 : 0)
                            + " WHERE rolName = '" + rolName
                            + "' AND pantalla = '" + pantalla + "';");
                    modificacion = value; 
                }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace HIS
{
    public class Rol
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string rolName;
        private string rolDes;
        private bool admin;
        private List<Permiso> permisos;

        public static List<Rol> ListaRoles()
	    {
		    List<Rol> lista = new List<Rol>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT rolName FROM tRol;"))
            {
                string r = (string)tupla[0];
                lista.Add(new Rol(r));
            }
		    return lista;
	    }

        public Rol(string name)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM tRol WHERE rolName = '" + name + "';")[0];
            rolName = (string)tupla[0];
            rolDes = (string)tupla[1];
            admin = (bool)tupla[2];
            permisos = Permiso.ListaPermisosRol(rolName);
        }
    
        public Rol(string name, string des, bool adm)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            miBD.Insert("INSERT INTO tRol VALUES('" + name + "', '"
                + des + "', "  + (adm ? 1 : 0) + ");");
            rolName = name;
            rolDes = des;
            admin = adm;
            permisos = new List<Permiso>();
        }

        public string RolName
        {
            get { return rolName; }
            set {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("UPDATE tRol SET rolName = '" + value
                            + "' WHERE rolName = '" + rolName + "';");
                    rolName = value;
                }
        }

        public string RolDes
        {
            get { return rolDes; }
            set {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("UPDATE tRol SET rolDes = '" + value
                            + "' WHERE rolName = '" + rolName + "';");
                    rolDes = value; 
                }
        }

        public bool Admin
        {
            get { return admin; }
        }

        public void BorrarRol()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE tRol WHERE rolName = '" + rolName + "';");
            rolName = RolDes = null;
            admin = false;
        }

        public bool Acceso(string pantalla)
        {
            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla)) return p.Acceso;
            }
            return false;
        }

        public bool Modificacion(string pantalla)
        {
            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla)) return p.Modificacion;
            }
            return false;
        }

        public void AddPermiso(Permiso p)
        {
            if (!permisos.Contains(p))
            {
                permisos.Add(p);
            }
        }

        public override string ToString()
        {
            return rolName;
        }

        public override bool Equals(object obj)
        {
            return obj is Rol && (((Rol)obj).rolName.CompareTo(rolName)==0);
        }

        public override int GetHashCode()
        {
            return rolName.GetHashCode();
        }
    }
}

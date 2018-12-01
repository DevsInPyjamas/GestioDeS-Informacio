using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace HIS
{
    public class Usuario
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private string nombre;
        private string password;
        private Rol rol;


	    public static List<Usuario> ListaUsuarios()
	    {
		    List<Usuario> lista = new List<Usuario>();

            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT nombre, password FROM tUsuario;"))
            {
                string n = (string)tupla[0];
                string p = (string)tupla[1];
                lista.Add(new Usuario(n,p));
            }

		    return lista;
	    }

        public Usuario(string n, string p)
        {

            try
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                object[] tupla = miBD.Select("SELECT * FROM tUsuario WHERE nombre = '" + n + "';")[0];

                nombre = (string)tupla[0];
                password = (string)tupla[1];
                rol = new Rol((string)tupla[2]);

                if (!password.Equals(p))
                {
                    nombre = password = null;
                    rol = null;
                    throw new Error("Usuario o Contraseña Incorrecta");
                }
            }
            catch (Exception ex)
            {
                throw new Error("Usuario o Contraseña Incorrecta: " + ex.Message);
            }
                
        }

        public Usuario(string n, string p, Rol r)
        {

            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            miBD.Insert("INSERT INTO tUsuario VALUES('" + n + "', '"
                + p + "', '" + r.RolName + "');");

            nombre = n;
            password = p;
            rol = r;

        }

        public string Nombre
        {
            get { return nombre; }
            set {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("UPDATE tUsuario SET nombre = '" + value
                            + "' WHERE nombre = '" + nombre + "';");
                    nombre = value;
                }
        }

        public string Password
        {
            get { return password; }
            set {
                    SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                    miBD.Update("UPDATE tUsuario SET password = '" + value
                            + "' WHERE nombre = '" + nombre + "';");
                    password = value;
                }
        }

        public Rol MyRol
        {
            get { return rol; }
        }

        public void ModiRol(Usuario u, Rol r)
        {
            if (!this.rol.Admin) 
                throw new Error("El usuario " + this.Nombre 
                    + " no puede cambiar el rol del usuario " + u.Nombre);
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Update("UPDATE tUsuario SET rolName = '" + r.RolName
                    + "' WHERE nombre = '" + u.Nombre + "';");
            u.rol = r;

        }

        public void BorrarUsuario()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE tUsuario WHERE nombre = '" + nombre + "';");
            nombre = password = null;
            rol = null;
        }


        public bool AccesoPantalla(string p)
        {
            return rol.Acceso(p);
        }

        public bool ModificaPantalla(string p)
        {
            return rol.Modificacion(p);
        }

    }
}

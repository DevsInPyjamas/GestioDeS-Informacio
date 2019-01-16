using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace HIS
{
    public class Paciente
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        private int NumSS;
        private string DNI_NIE;
        private string Nombre;
        private string Apellidos;
        private string Sexo;
        private DateTime FechaNacimiento;
        private string Direccion;
        private string Poblacion;
        private string Provincia;
        private string CodigoPostal;
        private Pais miPais;
        private string Telefono;
        private string e_mail;

        public static List<Paciente> ListaPacientes()
        {
            List<Paciente> lista = new List<Paciente>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (object[] tupla in miBD.Select("SELECT NumSS FROM tPaciente;"))
            {
                int id = (int)tupla[0];
                Paciente p = new Paciente(id);
                lista.Add(p);
            }
            return lista;
        }

        public Paciente(int nSS)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = miBD.Select("SELECT * FROM tPaciente WHERE NumSS=" + nSS + ";")[0];

            NumSS= (int)tupla[0];
            DNI_NIE= (string)tupla[1];
            Nombre= (string)tupla[2];
            Apellidos= (string)tupla[3];
            Sexo= (string)tupla[4];
            string[] fecha = tupla[5].ToString().Split('-');
            FechaNacimiento = new DateTime(int.Parse(fecha[0]), 
                int.Parse(fecha[1]), 
                int.Parse(fecha[2]));
            Direccion = (string)tupla[6];
            Poblacion = (string)tupla[7];
            Provincia = (string)tupla[8];
            CodigoPostal = (string)tupla[9];
            miPais = new Pais((string)tupla[10]);
            Telefono = (string)tupla[11];
            e_mail = (string)tupla[12];
            
        }

        public Paciente(int NumSS, string DNI_NIE, string Nombre, string Apellidos, string Sexo,
            DateTime FechaNacimiento, string Direccion, string Poblacion, string Provincia,
            string CodigoPostal, Pais miPais, string Telefono, string e_mail)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string ins = "INSERT INTO tPaciente VALUES(" + NumSS + ", '" + DNI_NIE + "', '"
                + Nombre + "', '" + Apellidos + "', '" + Sexo + "', '" + FechaNacimiento.ToShortDateString()
                + "', '" + Direccion + "', '" + Poblacion + "', '" + Provincia + "', '" + CodigoPostal
                + "', '" + miPais.Codigo + "', '" + Telefono + "', '" + e_mail + "');";
            miBD.Insert(ins);

            this.NumSS = NumSS;
            this.DNI_NIE = DNI_NIE;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Sexo = Sexo;
            this.FechaNacimiento = FechaNacimiento;
            this.Direccion = Direccion;
            this.Poblacion = Poblacion;
            this.Provincia = Provincia;
            this.CodigoPostal = CodigoPostal;
            this.miPais = miPais;
            this.Telefono = Telefono;
            this.e_mail = e_mail;
        }

        public void BorrarPaciente()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            miBD.Delete("DELETE tPaciente WHERE NumSS=" + this.NumSS + ";");

            NumSS = -1;
            DNI_NIE = null;
            Nombre = null;
            Apellidos = null;
            Sexo = null;
            FechaNacimiento = DateTime.Today;
            Direccion = null;
            Poblacion = null;
            Provincia = null;
            CodigoPostal = null;
            miPais = null;
            Telefono = null;
            e_mail = null;

        }

        public int NumeroSS_Paciente
        {
            get { return NumSS; }
            // No se permite cambiar el Número de la SS de un paciente
        }


        public string DNI_NIE_Paciente
        {
            get
            {
                return DNI_NIE;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET DNI_NIE='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                DNI_NIE = value;
            }
        }

        public string Nombre_Paciente
        {
            get
            {
                return Nombre;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Nombre='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                Nombre = value;
            }
        }

        public string Apellidos_Paciente
        {
            get
            {
                return Apellidos;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Apellidos='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                Apellidos = value;
            }
        }

        public string Sexo_Paciente
        {
            get
            {
                return Sexo;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Sexo='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                Sexo = value;
            }
        }

        public DateTime FechaNacimiento_Paciente
        {
            get
            {
                return FechaNacimiento;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET FechaNacimiento='" + value.ToShortDateString() 
                    + "' WHERE NumSS=" + this.NumSS + ";");
                FechaNacimiento = value;
            }
        }

        public string Direccion_Paciente
        {
            get
            {
                return Direccion;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Direccion='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                Direccion = value;
            }
        }

        public string Poblacion_Paciente
        {
            get
            {
                return Poblacion;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Poblacion='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                Poblacion = value;
            }
        }

        public string Provincia_Paciente
        {
            get
            {
                return Provincia;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Provincia='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                Provincia = value;
            }
        }

        public string CodigoPostal_Paciente
        {
            get
            {
                return CodigoPostal;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET CodigoPostal='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                CodigoPostal = value;
            }
        }

        public Pais Pais_Paciente
        {
            get
            {
                return miPais;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Pais='" + value.Codigo + "' WHERE NumSS=" + this.NumSS + ";");
                miPais = value;
            }
        }

        public string Telefono_Paciente
        {
            get
            {
                return Telefono;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET Telefono='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                Telefono = value;
            }
        }

        public string e_mail_Paciente
        {
            get
            {
                return e_mail;
            }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                miBD.Update("UPDATE tPaciente SET e_mail='" + value + "' WHERE NumSS=" + this.NumSS + ";");
                e_mail = value;
            }
        }

        public override string ToString()
        {
            return NumSS + "->" + DNI_NIE + "//" + Nombre + " " + Apellidos;
        }
    }
}

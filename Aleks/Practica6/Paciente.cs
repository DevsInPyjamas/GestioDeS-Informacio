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

        public static List<Paciente> ListaPacientes() {
            List<Paciente> lista = new List<Paciente>();
            SQLSERVERDB bd = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (object[] tuple in bd.Select("select numSS from tPaciente;")) {
                lista.Add(new Paciente((int) tuple[0]));
            }
            return lista;
        }

        public Paciente(int nSS) {
            SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tuple = db.Select("SELECT * FROM tPaciente WHERE numSS = '" + nSS + "';")[0];
            NumSS = (int) tuple[0];
            DNI_NIE = (string) tuple[1];
            Nombre = (string) tuple[2];
            Apellidos = (string) tuple[3];
            Sexo = (string) tuple[4];
            // solution adapted from https://stackoverflow.com/questions/919244/converting-a-string-to-datetime
            FechaNacimiento = DateTime.ParseExact((string) tuple[5], "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture);
            Direccion = (string) tuple[6];
            Poblacion = (string) tuple[7];
            Provincia = (string) tuple[8];
            CodigoPostal = (string) tuple[9];
            miPais = new Pais((string) tuple[10]);
            Telefono = (string) tuple[11];
            e_mail = (string) tuple[12];
        }

        public Paciente(int NumSS, string DNI_NIE, string Nombre, string Apellidos, string Sexo,
            DateTime FechaNacimiento, string Direccion, string Poblacion, string Provincia,
            string CodigoPostal, Pais miPais, string Telefono, string e_mail) {
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
            SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
            db.Insert("insert into tPaciente values ('" + NumSS + "', '" + DNI_NIE + "', '" + Nombre + "','"
                      +Apellidos+"','"+Sexo+"','"+FechaNacimiento+"','"+Direccion+"','"+Poblacion+"','"+
                      Provincia+"','"+CodigoPostal+"','"+miPais.Codigo+"','"+Telefono+"','"+e_mail);
        }

        public void BorrarPaciente(){
            SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
            
        }

        public int NumeroSS_Paciente {
            get { return NumSS;}
        }


        public string DNI_NIE_Paciente{
            get { return DNI_NIE; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set DNI_NIE = '" + value + "' where numss = '" + NumSS + "';");
                DNI_NIE = value;
            }
        }

        public string Nombre_Paciente {
            get { return Nombre; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Nombre = '" + value + "' where numss = '" + NumSS + "';");
                Nombre = value;
            }
        }

        public string Apellidos_Paciente
        {
            get { return Apellidos; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Apellidos = '" + value + "' where numss = '" + NumSS + "';");
                Apellidos = value;
            }
        }

        public string Sexo_Paciente
        {
            get { return Sexo; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Sexo = '" + value + "' where numss = '" + NumSS + "';");
                Sexo = value;
            }
        }

        public DateTime FechaNacimiento_Paciente
        {
            get { return FechaNacimiento; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set FechaNacimiento = '" + value + "' where numss = '" + NumSS + "';");
                FechaNacimiento = value;
            }
        }

        public string Direccion_Paciente
        {
            get { return Direccion; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Direccion = '" + value + "' where numss = '" + NumSS + "';");
                Direccion = value;
            }
        }

        public string Poblacion_Paciente
        {
            get { return Poblacion; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Poblacion = '" + value + "' where numss = '" + NumSS + "';");
                Poblacion = value;
            }
        }

        public string Provincia_Paciente
        {
            get { return Provincia; }
            set {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Provincia = '" + value + "' where numss = '" + NumSS + "';");
                Provincia = value;
            }
        }

        public string CodigoPostal_Paciente
        {
            get {return CodigoPostal; }
            set
            {
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set CodigoPostal = '" + value + "' where numss = '" + NumSS + "';");
                CodigoPostal = value;
            }
        }

        public Pais Pais_Paciente
        {
            get { return miPais; }
            set{
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Pais = '" + value + "' where numss = '" + NumSS + "';");
                miPais = value;
            }
        }

        public string Telefono_Paciente
        {
            get { return Telefono; }
            set{
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set Telefono = '" + value + "' where numss = '" + NumSS + "';");
                Telefono = value;
            }
        }

        public string e_mail_Paciente
        {
            get { return e_mail; }
            set{
                SQLSERVERDB db = new SQLSERVERDB(BD_SERVER, BD_NAME);
                db.Update("update tPaciente set e_mail = '" + value + "' where numss = '" + NumSS + "';");
                e_mail = value;
            }
        }

        public override string ToString()
        {
            return NumSS + "->" + DNI_NIE + "//" + Nombre + " " + Apellidos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BDLibrary;

namespace HIS
{
    public class Cita
    {
        private int id;
        private int numSS;
        private string consulta;
        private DateTime fecha_hora;


        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;

        public static List<Cita> ListaCitas(Paciente p)
        {
            List<Cita> lista = new List<Cita>();
            SQLSERVERDB miDB = new SQLSERVERDB(BD_SERVER, BD_NAME);
            foreach (object[] tupla in miDB.Select("SELECT id_cita FROM tCita where numsspaciente = " + p.NumeroSS_Paciente + ";"))
            {
                int id = (int)tupla[0];
                Cita c = new Cita(id);
                lista.Add(c);
            }
            return lista;
        }

        public Cita(int id)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            object[] tupla = dbManager.Select("select * from tCita where id_cita = " + id + ";")[0];
            this.id = (int) tupla[0];
            this.numSS = (int) tupla[1];
            this.consulta = (string) tupla[3];
            this.fecha_hora = DateTime.Parse(tupla[2].ToString());
        }

        public Cita(int numSS, DateTime fecha_hora, string consulta)
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Insert("insert into tCita (numSSPaciente, fecha_hora, consulta) values"
                + "(" + numSS + ", '" + fecha_hora + "', '" + consulta + "');");
            this.id = (int) dbManager.Select("select max(id_cita) from tCita")[0][0];
            this.numSS = numSS;
            this.fecha_hora = fecha_hora;
            this.consulta = consulta;
        }

        public int ID
        {
            get { return id; }
        }

        public int NumSS
        {
            get { return numSS; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tcita set numsspaciente = " + value + " where id_cita = "+ this.id + ";");
                numSS = value;
            }
        }

        public DateTime Fecha_Hora
        {
            get { return fecha_hora; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sFecha = value.ToShortDateString() + " " + value.ToShortTimeString();
                miBD.Update("UPDATE tCita SET Fecha_Hora = '" + sFecha + "' WHERE ID_Cita=" + this.id + ";");
                fecha_hora = value;
            }
        }

        public string Consulta
        {
            get { return consulta; }
            set
            {
                SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
                dbManager.Update("update tcita set consulta = '" + value + "' where id_cita = " + this.id + ";");
                consulta = value;
            }
        }

        public void BorrarCita()
        {
            SQLSERVERDB dbManager = new SQLSERVERDB(BD_SERVER, BD_NAME);
            dbManager.Delete("delete tcita where id_cita = " + this.id + ";");
            this.numSS = -1;
            this.consulta = null;
            this.id = -1;
        }

        public override string ToString()
        {
            return ID + " " + NumSS + fecha_hora.ToShortDateString() + " " + fecha_hora.ToShortTimeString() + " " + consulta;
        }

        public override bool Equals(object obj)
        {
            return obj is Cita && ((Cita)obj).ID == ID;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}

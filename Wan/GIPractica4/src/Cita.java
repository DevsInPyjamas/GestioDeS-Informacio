
import java.util.*;
import java.text.SimpleDateFormat;

public class Cita
{
	    private static String BD_SERVER = "localhost";
	    private static String BD_NAME = "GI1819";
	
	    private int ID;
	    private int NumSS;
	    private Date Fecha_Hora;
	    private String Consulta;

        public static List<Cita> ListaCitas(Paciente p)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	List<Cita> lista = new ArrayList<Cita>();
        	
        	for(Object[] tuples: miBD.Select("SELECT * FROM tCita;"))
        	{
        		Cita c = new Cita((Integer)tuples[0]);
        		lista.add(c);
        	}
            return lista;
        }

        public Cita(int id)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	
        	Object[] tuples = miBD.Select("SELECT * FROM tCita WHERE ID_CITA = '" + id + "';").get(0);
        	
        	ID = (Integer)tuples[0];
        	NumSS = (Integer)tuples[1];
        	Fecha_Hora = (Date)tuples[2];
        	Consulta = (String)tuples[3];
         }

		public Cita(int ID_Paciente, Date Fecha, String consulta)
         {
			SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss"); 
            String DateToStr = format.format(Fecha);
             
            BD miBD = new BD(BD_SERVER,BD_NAME);
              
            miBD.Insert("INSERT INTO tCita (NumSSPaciente, Fecha_Hora, Consulta) VALUES('" + ID_Paciente + "','" + DateToStr + "','" + consulta + "');");
            
            NumSS = ID_Paciente;
            Fecha_Hora = Fecha;
            Consulta = consulta;
         }

         public int getID()
         {
             return ID; 
             // No se permite cambiar el ID de una Cita
         }

         public int getPacientePrueba()
         {
             return NumSS; 
             // No se permite cambiar el paciente de una cita
         }

         public Date getFechaHora()
         {
             return Fecha_Hora; 
         }
             
         public void setFechaHora(Date value)             
         {
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss"); 
            String DateToStr = format.format(value); 
                 
            BD miBD = new BD(BD_SERVER,BD_NAME);
          	miBD.Update("UPDATE tCita SET Fecha_Hora = '" + DateToStr + "' WHERE ID_CITA = '" + ID + "';");
           	Fecha_Hora = value;
         }


		public String getConsulta()
        {
             return Consulta; 
        }
        
		public void setConsulta(String value)
        {
			BD miBD = new BD(BD_SERVER,BD_NAME);
          	miBD.Update("UPDATE tCita SET Consulta = '" + value + "' WHERE ID_CITA = '" + ID + "';");
           	Consulta = value;
        }

         @SuppressWarnings("null")
		public void BorrarCita()
         {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
         	miBD.Delete("DELETE FROM tCita WHERE ID_CITA ='"+ ID + "';");    	
         	ID = NumSS = (Integer) null;
         	Fecha_Hora = null;
         	Consulta = null;
         }
         
         public String toString()
         {
        	 SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss"); 
             String DateToStr = format.format(Fecha_Hora);
             
        	 return this.ID + "/" + this.NumSS + "/" + DateToStr + "/" + this.Consulta;
         }
}

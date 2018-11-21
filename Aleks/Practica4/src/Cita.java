
import java.text.ParseException;
import java.util.*;
import java.text.SimpleDateFormat;

public class Cita {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";

    private int ID;
    private int NumSS;
    private Date Fecha_Hora;
    private String Consulta;

    public static List<Cita> ListaCitas(Paciente p) {
        List<Cita> lista = new ArrayList<Cita>();
        BD bd = new BD(BD_SERVER, BD_NAME);
        for(Object[] tupla : bd.Select("SELECT * FROM tCita where numsspaciente = " + p.getNumeroSS_Paciente())) {
            lista.add(new Cita((int) tupla[0]));
        }
        return lista;
    }

    public Cita(int id) {
        BD miBD = new BD(BD_SERVER,BD_NAME);
        Object[] tupla = miBD.Select("SELECT * FROM tCita where id_cita = '" + id + "';").get(0);
        this.ID = (int) tupla[0];
        this.NumSS = (int) tupla[1];
        Fecha_Hora = (Date)tupla[2];
        this.Consulta = (String) tupla[3];
     }

    public Cita(int ID_Paciente, Date Fecha, String consulta) {
         SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
         String DateToStr = format.format(Fecha);
    }

    public int getID() {
         return ID;
         // No se permite cambiar el ID de una Cita
    }

    public int getPacientePrueba() {
         return NumSS;
         // No se permite cambiar el paciente de una cita
    }

    public Date getFechaHora()
     {
         return Fecha_Hora;
     }
    public void setFechaHora(Date value) {
             SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
             String DateToStr = format.format(value);

    }


    public String getConsulta()
    {
         return Consulta;
    }

    public void setConsulta(String value) {

    }

    public void BorrarCita() {

    }
    public String toString() {
         SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
         String DateToStr = format.format(Fecha_Hora);

         return this.ID + "/" + this.NumSS + "/" + DateToStr + "/" + this.Consulta;
    }
}


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
        List<Cita> lista = new ArrayList<>();
        BD miBD = new BD(BD_SERVER, BD_NAME);

        for (Object[] tupla : miBD.Select("SELECT * FROM tCita;")) {
            Cita u = new Cita((Integer) tupla[0]);
            lista.add(u);
        }
        return lista;
    }

    public Cita(int id) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        Object[] tupla = miBD.Select(String.format("Select * from tCita where ID_CITA=%d;", id)).get(0);
        this.ID = (Integer) tupla[0];
        this.NumSS = (Integer) tupla[1];
        this.Fecha_Hora = (Date) tupla[2];
        this.Consulta = (String) tupla[3];
    }

    public Cita(int ID_Paciente, Date Fecha, String consulta) {

        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        String DateToStr = format.format(Fecha);
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert(String.format("insert into tCita(NumSSPaciente, Fecha_Hora, Consulta) " +
                "values (%d, '%s', '%s')", ID_Paciente, DateToStr, consulta));

        this.NumSS = ID_Paciente;
        this.Fecha_Hora = Fecha;
        this.Consulta = consulta;
    }

    public int getID() {
        return ID;
        // No se permite cambiar el ID de una Cita
    }

    public int getPacientePrueba() {
        return NumSS;
        // No se permite cambiar el paciente de una cita
    }

    public Date getFechaHora() {
        return Fecha_Hora;
    }

    public void setFechaHora(Date value) {
        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        String DateToStr = format.format(value);
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert(String.format("update tCita set Fecha_hora = '%s' where ID_CITA=%d", DateToStr, this.ID));
        this.Fecha_Hora=value;
    }


    public String getConsulta() {
        return Consulta;
    }

    public void setConsulta(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert(String.format("update tCita set Consulta = '%s' where ID_CITA=%d", value, this.ID));
        this.Consulta=value;
    }

    public void BorrarCita() {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Delete(String.format("Delete from tCita where ID_CITA = %d",this.ID));
    }

    public String toString() {
        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        String DateToStr = format.format(Fecha_Hora);

        return this.ID + "/" + this.NumSS + "/" + DateToStr + "/" + this.Consulta;
    }
}

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
        List<Cita> list = new ArrayList<>();
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> query = bd.Select("SELECT * FROM tCita WHERE NumSSPaciente == " + p.getNumeroSS_Paciente());
        for (Object[] ob : query) {
            list.add(new Cita((int) ob[0], (Date) ob[1], ob[2].toString()));
        }
        return list;
    }

    public Cita(int id) {
        BD miBD = new BD(BD_SERVER, BD_NAME);

        Object[] tuples = miBD.Select("SELECT * FROM tCita WHERE ID_CITA = '" + id + "';").get(0);

        this.ID = (Integer) tuples[0];
        this.NumSS = (Integer) tuples[1];
        this.Fecha_Hora = (Date) tuples[2];
        this.Consulta = (String) tuples[3];
    }

    public Cita(int ID_Paciente, Date Fecha, String consulta) {
        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        String DateToStr = format.format(Fecha);

        BD miBD = new BD(BD_SERVER,BD_NAME);

        miBD.Insert("INSERT INTO tCita (NumSSPaciente, Fecha_Hora, Consulta) VALUES('" + ID_Paciente + "','" +
                DateToStr + "','" + consulta + "');");

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
        BD bd = new BD(BD_SERVER,BD_NAME);
        bd.Update("UPDATE tCita SET Fecha_Hora = '" + DateToStr + "' WHERE ID_CITA = '" + ID + "';");
        Fecha_Hora = value;
    }

    public String getConsulta() {
        return Consulta;
    }

    public void setConsulta(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tCita SET consulta = '" + value + "' WHERE ID_CITA = " + this.ID + ";");
        this.Consulta = value;

    }

    public void BorrarCita() {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Delete("DELETE FROM tCita WHERE ID_CITA = " + this.ID + ";");
        this.NumSS = this.ID = -1;
        this.Consulta = null;
        this.Fecha_Hora = null;
    }

    public String toString() {
        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd hh:mm:ss");
        String DateToStr = format.format(Fecha_Hora);

        return this.ID + "/" + this.NumSS + "/" + DateToStr + "/" + this.Consulta;
    }
}

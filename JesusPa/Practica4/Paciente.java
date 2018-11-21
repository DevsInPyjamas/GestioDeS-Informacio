import java.util.*;
import java.text.SimpleDateFormat;

public class Paciente {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";

    private int NumSS;
    private String DNI_NIE;
    private String Nombre;
    private String Apellidos;
    private String Sexo;
    private Date FechaNacimiento;
    private String Direccion;
    private String Poblacion;
    private String Provincia;
    private String CodigoPostal;
    private Pais miPais;
    private String Telefono;
    private String e_mail;

    public static List<Paciente> ListaPacientes() {
        List<Paciente> list = new ArrayList<>();
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> query = bd.Select("SELECT * FROM tPaciente");
        for (Object[] ob : query) {
            list.add(new Paciente((int) ob[0], ob[1].toString(), ob[2].toString(), ob[3].toString(),
                    ob[4].toString(), (Date) ob[5], ob[6].toString(), ob[7].toString(), ob[8].toString(),
                    ob[9].toString(), (Pais) ob[10], ob[11].toString(), ob[12].toString()));
        }
        return list;
    }

    public Paciente(int nSS) {
        BD miBD = new BD(BD_SERVER, BD_NAME);

        Object[] tuples = miBD.Select("SELECT * FROM tPaciente WHERE NumSS = '" + nSS + "';").get(0);
        NumSS = (Integer) tuples[0];
        DNI_NIE = (String) tuples[1];
        Nombre = (String) tuples[2];
        Apellidos = (String) tuples[3];
        Sexo = (String) tuples[4];
        FechaNacimiento = (Date) tuples[5];
        Direccion = (String) tuples[6];
        Poblacion = (String) tuples[7];
        Provincia = (String) tuples[8];
        CodigoPostal = (String) tuples[9];
        miPais = new Pais((String) tuples[10]);
        Telefono = (String) tuples[11];
        e_mail = (String) tuples[12];
    }

    public Paciente(int NumSS, String DNI_NIE, String Nombre, String Apellidos, String Sexo,
                    Date FechaNacimiento, String Direccion, String Poblacion, String Provincia,
                    String CodigoPostal, Pais miPais, String Telefono, String e_mail) {
        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
        String DateToStr = format.format(FechaNacimiento);

        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert("INSERT INTO tPaciente VALUES('" + NumSS + "','" + DNI_NIE + "','" + Nombre + "','" +
                Apellidos + "','" + Sexo + "','" + DateToStr + "','" + Direccion + "','" + Poblacion + "','" +
                Provincia + "','" + CodigoPostal + "','" + miPais.getCodigo() + "','" + Telefono + "','" +
                e_mail + "','");
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

    public List<Cita> getCitas() {
        List<Cita> list = new ArrayList<>();
        BD miBD = new BD(BD_SERVER, BD_NAME);
        for (Object[] tuples : miBD.Select("SELECT * FROM tCita")) {
            Cita c = new Cita((int) tuples[0]);
            list.add(c);
        }
        return list;
    }

    @SuppressWarnings("null")
    public void BorrarPaciente() {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Delete("DELETE FROM tPaciente WHERE NumSS = " + this.NumSS + ";");
        this.NumSS = -1;
        this.FechaNacimiento = null;
        this.miPais = null;
        this.Nombre = this.Apellidos = this.CodigoPostal = this.Direccion = this.DNI_NIE = null;
        this.e_mail = this.Poblacion = this.Provincia = this.Sexo = this.Telefono = null;
    }

    public int getNumeroSS_Paciente() {
        return NumSS;
        // No se permite cambiar el N�mero de la SS de un paciente
    }


    public String getDNI_NIE_Paciente() {
        return DNI_NIE;
    }

    public void setDNI_NIE_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set DNI_NIE = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.DNI_NIE = value;
    }

    public String getNombre_Paciente() {
        return Nombre;
    }

    public void setNombre_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Nombre = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.Nombre = value;
    }

    public String getApellidos_Paciente() {
        return Apellidos;
    }

    public void setApellidos_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Apellidos = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.Apellidos = value;
    }

    public String getSexo_Paciente() {
        return Sexo;
    }

    public void setSexo_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Sexo = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.Sexo = value;
    }

    public Date getFechaNacimiento_Paciente() {
        return FechaNacimiento;
    }

    public void setFechaNacimiento_Paciente(Date value) {
        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
        String DateToStr = format.format(value);

        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set FechaNacimiento = '" + DateToStr + "' WHERE NumSS = " + this.NumSS + ";");
        this.FechaNacimiento = value;
    }

    public String getDireccion_Paciente() {
        return Direccion;
    }

    public void setDireccion_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Direccion = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.Direccion = value;
    }

    public String getPoblacion_Paciente() {
        return Poblacion;
    }

    public void setPoblacion_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Poblacion = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.Poblacion = value;
    }

    public String getProvincia_Paciente() {
        return Provincia;
    }

    public void setProvincia_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Provincia = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.Provincia = value;
    }

    public String getCodigoPostal_Paciente() {
        return CodigoPostal;
    }

    public void setCodigoPostal_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set CodigoPostal = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.CodigoPostal = value;
    }

    public Pais getPais_Paciente() {
        return miPais;
    }

    public void setPais_Paciente(Pais value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Pais = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.miPais = value;
    }

    public String getTelefono_Paciente() {
        return Telefono;
    }

    public void setTelefono_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set Telefono = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.Telefono = value;
    }

    public String getE_mail_Paciente() {
        return e_mail;
    }

    public void setE_mail_Paciente(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPaciente set e_mail = '" + value + "' WHERE NumSS = " + this.NumSS + ";");
        this.e_mail = value;
    }

    public String toString() {
        return NumSS + "->" + DNI_NIE + "//" + Nombre + " " + Apellidos;
    }
}

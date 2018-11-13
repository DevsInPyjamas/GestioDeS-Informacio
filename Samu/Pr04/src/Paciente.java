
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
        List<Paciente> lista = new ArrayList<>();
        BD miBD = new BD(BD_SERVER, BD_NAME);

        for (Object[] tupla : miBD.Select("SELECT * FROM tPaciente;")) {
            Paciente u = new Paciente((int) tupla[0]);
            lista.add(u);
        }

        return lista;
    }

    public Paciente(int nSS) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        Object[] tupla = miBD.Select(String.format("Select * from tPaciente where NumSS='%d';",
                nSS)).get(0);
        this.NumSS = (Integer) tupla[0];
        this.DNI_NIE = (String) tupla[1];
        this.Nombre = (String) tupla[2];
        this.Apellidos = (String) tupla[3];
        this.Sexo = (String) tupla[4];
        this.FechaNacimiento = (Date) tupla[5];
        this.Direccion = (String) tupla[6];
        this.Poblacion = (String) tupla[7];
        this.Provincia = (String) tupla[8];
        this.CodigoPostal = (String) tupla[9];
        this.miPais = new Pais((String) tupla[10]);
        this.Telefono = (String) tupla[11];
        this.e_mail = (String) tupla[12];

    }

    public Paciente(int NumSS, String DNI_NIE, String Nombre, String Apellidos, String Sexo,
                    Date FechaNacimiento, String Direccion, String Poblacion, String Provincia,
                    String CodigoPostal, Pais miPais, String Telefono, String e_mail) {

        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
        String DateToStr = format.format(FechaNacimiento);
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert(String.format("INSERT INTO tPaciente (NumSS, DNI_NIE, Nombre, Apellidos, Sexo, FechaNacimiento, Direccion," +
                "Poblacion, Provincia, CodigoPostal, Pais, Telefono, e_mail) values (%s, '%s', '%s', '%s', '%s', '%s', '%s', '%s'" +
                ", '%s', '%s', '%s', '%s', '%s')", NumSS, DNI_NIE, Nombre, Apellidos, Sexo, DateToStr, Direccion, Poblacion, Provincia,
                CodigoPostal, miPais.getCodigo(), Telefono, e_mail));

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
        return Cita.ListaCitas(this);
    }

    public void BorrarPaciente() {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Delete(String.format("delete from tPaciente where NumSS = '%d';", this.NumSS));
    }

    public int getNumeroSS_Paciente() {
        return NumSS;
        // No se permite cambiar el Numero de la SS de un paciente
    }


    public String getDNI_NIE_Paciente() {
        return DNI_NIE;
    }

    public void setDNI_NIE_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set DNI_NIE = '%s' where NumSS = '%d';", value, this.NumSS));
        this.DNI_NIE = value;
    }

    public String getNombre_Paciente() {
        return Nombre;
    }

    public void setNombre_Paciente(String value) {

    }

    public String getApellidos_Paciente() {
        return Apellidos;
    }

    public void setApellidos_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set Nombre = '%s' where NumSS = '%d';", value, this.NumSS));
        this.Nombre = value;
    }

    public String getSexo_Paciente() {
        return Sexo;
    }

    public void setSexo_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set Sexo = '%s' where NumSS = '%d';", value, this.NumSS));
        this.Sexo = value;
    }

    public Date getFechaNacimiento_Paciente() {
        return FechaNacimiento;
    }

    public void setFechaNacimiento_Paciente(Date value) {
        SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
        String DateToStr = format.format(value);
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set FechaNacimiento = '%s' where NumSS = '%d';", DateToStr, this.NumSS));
        this.FechaNacimiento = value;
    }

    public String getDireccion_Paciente() {
        return Direccion;
    }

    public void setDireccion_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set Direccion = '%s' where NumSS = '%d';", value, this.NumSS));
        this.Direccion = value;
    }

    public String getPoblacion_Paciente() {
        return Poblacion;
    }

    public void setPoblacion_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set Poblacion = '%s' where NumSS = '%d';", value, this.NumSS));
        this.Poblacion = value;
    }

    public String getProvincia_Paciente() {
        return Provincia;
    }

    public void setProvincia_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set Provincia = '%s' where NumSS = '%d';", value, this.NumSS));
        this.Provincia = value;
    }

    public String getCodigoPostal_Paciente() {
        return CodigoPostal;
    }

    public void setCodigoPostal_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set CodigoPostal = '%s' where NumSS = '%d';", value, this.NumSS));
        this.CodigoPostal = value;
    }

    public Pais getPais_Paciente() {
        return miPais;
    }

    public void setPais_Paciente(Pais value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set Pais = '%s' where NumSS = '%d';", value.getCodigo(), this.NumSS));
        this.miPais = value;
    }

    public String getTelefono_Paciente() {
        return Telefono;
    }

    public void setTelefono_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set Telefono = '%s' where NumSS = '%d';", value, this.NumSS));
        this.Telefono = value;
    }

    public String getE_mail_Paciente() {
        return e_mail;
    }

    public void setE_mail_Paciente(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPaciente set e_mail = '%s' where NumSS = '%d';", value, this.NumSS));
        this.e_mail = value;
    }

    public String toString() {
        return NumSS + "->" + DNI_NIE + "//" + Nombre + " " + Apellidos;
    }
}

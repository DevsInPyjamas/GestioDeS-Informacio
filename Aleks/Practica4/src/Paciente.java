
import java.util.*;
import java.text.SimpleDateFormat;

public class Paciente
{
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
            List<Paciente> lista = new ArrayList<Paciente>();

            return lista;
        }

        public Paciente(int nSS) {

        }

        public Paciente(int NumSS, String DNI_NIE, String Nombre, String Apellidos, String Sexo,
            Date FechaNacimiento, String Direccion, String Poblacion, String Provincia,
            String CodigoPostal, Pais miPais, String Telefono, String e_mail) {

        	SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd"); 
            String DateToStr = format.format(FechaNacimiento);
        }

        public List<Cita> getCitas() {

        }
        
        public void BorrarPaciente() {

        }

        public int getNumeroSS_Paciente() {
            return NumSS; 
            // No se permite cambiar el Número de la SS de un paciente
        }


        public String getDNI_NIE_Paciente()
        {
            return DNI_NIE;
        }
        public void setDNI_NIE_Paciente(String value) {

        }

        public String getNombre_Paciente()
        {
            return Nombre;
        }
            
        public void setNombre_Paciente(String value) {

        }

        public String getApellidos_Paciente()
        {
            return Apellidos;
        }
            
        public void setApellidos_Paciente(String value) {

        }

        public String getSexo_Paciente()
        {
            return Sexo;
        }
            
        public void setSexo_Paciente(String value) {

        }

        public Date getFechaNacimiento_Paciente()
        {
            return FechaNacimiento;
        }
            
        public void setFechaNacimiento_Paciente(Date value) {
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
            String DateToStr = format.format(value); 

        }

        public String getDireccion_Paciente()
        {
            return Direccion;
        }
            
        public void setDireccion_Paciente(String value) {

        }

        public String getPoblacion_Paciente()
        {
            return Poblacion;
        }
        
        public void setPoblacion_Paciente(String value) {

        }

        public String getProvincia_Paciente()
        {
            return Provincia;
        }
        
        public void setProvincia_Paciente(String value) {

        }

        public String getCodigoPostal_Paciente()
        {
            return CodigoPostal;
        }
        
        public void setCodigoPostal_Paciente(String value) {

        }

        public Pais getPais_Paciente()
        {
            return miPais;
        }
        
        public void setPais_Paciente(Pais value) {

        }

        public String getTelefono_Paciente()
        {
            return Telefono;
        }
        
        public void setTelefono_Paciente(String value) {

        }

        public String getE_mail_Paciente()
        {
            return e_mail;
        }
        
        public void setE_mail_Paciente(String value) {

        }

        public String toString()
        {
            return NumSS + "->" + DNI_NIE + "//" + Nombre + " " + Apellidos;
        }
}

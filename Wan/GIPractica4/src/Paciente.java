
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

        public static List<Paciente> ListaPacientes()
        {
            BD miBD = new BD(BD_SERVER,BD_NAME);
        	List<Paciente> lista = new ArrayList<Paciente>();
        	
        	for(Object[] tuples: miBD.Select("SELECT * FROM tPaciente;"))
        	{
        		Paciente p = new Paciente((int)tuples[0]);
        		lista.add(p);
        	}
            return lista;
        }

        public Paciente(int nSS)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	
        	Object[] tuples = miBD.Select("SELECT * FROM tPaciente WHERE NumSS = '" + nSS + "';").get(0);
        	NumSS = (Integer)tuples[0];
        	DNI_NIE = (String)tuples[1];
        	Nombre = (String)tuples[2];
        	Apellidos = (String)tuples[3];
        	Sexo = (String)tuples[4];
        	FechaNacimiento = (Date)tuples[5];
        	Direccion = (String)tuples[6];
        	Poblacion = (String)tuples[7];
        	Provincia = (String)tuples[8];
        	CodigoPostal = (String)tuples[9];
        	miPais = new Pais((String)tuples[10]);
        	Telefono = (String)tuples[11];
        	e_mail = (String)tuples[12];
        }

        public Paciente(int NumSS, String DNI_NIE, String Nombre, String Apellidos, String Sexo,
            Date FechaNacimiento, String Direccion, String Poblacion, String Provincia,
            String CodigoPostal, Pais miPais, String Telefono, String e_mail)
        {
        	SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd"); 
            String DateToStr = format.format(FechaNacimiento); 
            
            BD miBD = new BD(BD_SERVER,BD_NAME);
            miBD.Insert("INSERT INTO tPaciente VALUES('" + NumSS + "','" + DNI_NIE + "','" + Nombre + "','" + Apellidos + "','" + Sexo + "','" + DateToStr + "','" + Direccion + "','" + Poblacion + "','" + Provincia + "','" + CodigoPostal + "','" + miPais.getCodigo() + "','" + Telefono + "','" + e_mail + "','");
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

        public List<Cita> getCitas()
        {
        	List<Cita> citas = new ArrayList<Cita>();
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	
        	for(Object[] tuples: miBD.Select("SELECT * FROM tCita"))
        	{
        		Cita c = new Cita((int)tuples[0]);
        		citas.add(c);
        	}
        	return citas;
        }
        
        @SuppressWarnings("null")
		public void BorrarPaciente()
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Delete("DELETE FROM tPaciente WHERE NumSS = '" + NumSS + "';");
        	NumSS = (Integer) null;
        	DNI_NIE = Nombre = Apellidos = Sexo = Direccion = Poblacion = Provincia = CodigoPostal = Telefono = e_mail = null;
        	FechaNacimiento = null;
        	miPais = null;
        	
        }

        public int getNumeroSS_Paciente()
        {
            return NumSS; 
            // No se permite cambiar el Número de la SS de un paciente
        }


        public String getDNI_NIE_Paciente()
        {
            return DNI_NIE;
        }
        public void setDNI_NIE_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET DNI_NIE = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	DNI_NIE = value;
        }

        public String getNombre_Paciente()
        {
            return Nombre;
        }
            
        public void setNombre_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Nombre = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	Nombre = value;
        }

        public String getApellidos_Paciente()
        {
            return Apellidos;
        }
            
        public void setApellidos_Paciente(String value)            
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Apellidos = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	Apellidos = value;
        }

        public String getSexo_Paciente()
        {
            return Sexo;
        }
            
        public void setSexo_Paciente(String value)            
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Sexo = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	Sexo = value;
        }

        public Date getFechaNacimiento_Paciente()
        {
            return FechaNacimiento;
        }
            
        public void setFechaNacimiento_Paciente(Date value)
        {
           	SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd"); 
            String DateToStr = format.format(value); 
            
            BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET FechaNacimiento = '" + DateToStr + "' WHERE NumSS = '" + NumSS + "';");
        	FechaNacimiento = value;
        }

        public String getDireccion_Paciente()
        {
            return Direccion;
        }
            
        public void setDireccion_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Direccion = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	Direccion = value;
        }

        public String getPoblacion_Paciente()
        {
            return Poblacion;
        }
        
        public void setPoblacion_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Poblacion = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	Poblacion = value;
        }

        public String getProvincia_Paciente()
        {
            return Provincia;
        }
        
        public void setProvincia_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Provincia = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	Provincia = value;
        }

        public String getCodigoPostal_Paciente()
        {
            return CodigoPostal;
        }
        
        public void setCodigoPostal_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET CodigoPostal = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	CodigoPostal = value;
        }

        public Pais getPais_Paciente()
        {
            return miPais;
        }
        
        public void setPais_Paciente(Pais value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Pais = '" + value.getCodigo() + "' WHERE NumSS = '" + NumSS + "';");
        	miPais = value;
        }

        public String getTelefono_Paciente()
        {
            return Telefono;
        }
        
        public void setTelefono_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET Telefono = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	Telefono = value;
        }

        public String getE_mail_Paciente()
        {
            return e_mail;
        }
        
        public void setE_mail_Paciente(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPaciente SET e_mail = '" + value + "' WHERE NumSS = '" + NumSS + "';");
        	e_mail = value;
        }

        public String toString()
        {
            return NumSS + "->" + DNI_NIE + "//" + Nombre + " " + Apellidos;
        }
}

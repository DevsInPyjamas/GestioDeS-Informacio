import java.util.*;

public class Pais
{
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    
    private String cod;
    private String des;

        public static List<Pais> ListaPaises()
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	List<Pais> lista = new ArrayList<Pais>();
        	
        	for(Object[] tuples: miBD.Select("SELECT * FROM tPais;")) 
        	{
        		Pais p = new Pais((String)tuples[0]);
        		lista.add(p);
        	}
            return lista;
        }

        public Pais(String cod)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	
        	Object[] tuples = miBD.Select("SELECT * FROM tPais WHERE Codigo = '" + cod + "';").get(0);
        	
        	cod = (String)tuples[0];
        	des = (String)tuples[1];
        }

        public Pais(String cod, String des)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	
        	miBD.Insert("INSERT INTO tPais VALUES('" + cod + "','" + des + "');");
        	
        	this.cod = cod;
        	this.des = des;
        }

        public String getCodigo()
        {
            return cod; 
        }
        
        public void setCodigo(String value)
        {
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPais SET Codigo = '" + value + "' WHERE Codigo = '" + cod + "';");
        	cod = value;
        }

        public String getDescripcion()
        {
            return des; 
        }

        public void setDescripcion(String value)            
        {            	
        	BD miBD = new BD(BD_SERVER,BD_NAME);
        	miBD.Update("UPDATE tPais SET Descripcion = '" + value + "' WHERE Codigo = '" + cod + "';");
        	des = value;
        }

        public String toString()
        {
            return des;
        }
}

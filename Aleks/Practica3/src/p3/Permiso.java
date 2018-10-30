package p3;

import java.util.*;


public class Permiso implements Comparable<Permiso>
{
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    
	private String rolName;
	private String pantalla;
    private boolean acceso;
    private boolean modificacion;


    public static List<Permiso> ListaPermisosRol(String rolName)
    {		
		// Retorna una lista con todos los permisos de un rol determinado

		return null;
    }
    
    public Permiso(String r, String p)
    {
		// Crea el objeto cargando sus valores de la base de datos

    }

    public Permiso(String r, String p, boolean a, boolean m)
    {
		// Crea el objeto y lo inserta en la base de datos

    }
    
	public void setRolName(String value) 
	{
		// Actualiza el atributo en memoria y en la base de datos

	}

	public String getRolName() 
	{
		return rolName;
	}
    
    public String getPantalla() 
    {
    	return pantalla; 
    }
    
    public void setPantalla(String value) 
    {
		// Actualiza el atributo en memoria y en la base de datos

    }
    

    public boolean getAcceso() 
    { 
    	return acceso; 
    }
        
    public void setAcceso(boolean value) 
    { 
		// Actualiza el atributo en memoria y en la base de datos

    }

    
    public boolean getModificacion() 
    { 
    	return modificacion; 
    }
    
    public void setModificacion(boolean value) 
    { 
		// Actualiza el atributo en memoria y en la base de datos

    }

    @Override
	public boolean equals(Object o) 
	{
		boolean res = false;
		if (o instanceof Permiso) 
		{
			Permiso p = (Permiso) o;
			res = this.pantalla.equalsIgnoreCase(p.pantalla) 
				&& this.rolName.equalsIgnoreCase(p.rolName);
		}
		return res;
	}
	
	public int hashCode() 
	{
		return pantalla.toLowerCase().hashCode() 
				+ rolName.toLowerCase().hashCode();
	}

	public int compareTo(Permiso p) 
	{
		int res = this.rolName.compareToIgnoreCase(p.rolName);
		if (res == 0) res = this.pantalla.compareToIgnoreCase(p.pantalla);
		return res;
	}
}

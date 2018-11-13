import java.util.*;


public class Permiso implements Comparable<Permiso>
{
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    
	private String rolName;
	private String pantalla;
    private boolean acceso;
    private boolean modificacion;


    public static List<Permiso> ListaPermisosRol(String r)
    {		
		List<Permiso> lista = new ArrayList<Permiso>();
		BD bd = new BD(BD_SERVER,BD_NAME);
		
		for(Object[] tuples: bd.Select("SELECT * FROM tPermiso WHERE rolName = '" + r + "';"))
		{
			Permiso p = new Permiso((String)tuples[0], (String)tuples[1]);
			lista.add(p);
		}
		return lista;
    }
    
    public Permiso(String r, String p)
    {
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	List<Object[]> queryTuples = bd.Select("SELECT * FROM tPermiso WHERE rolName = '" + r + "' AND pantalla = '" + p + "'");
    	rolName = (String) queryTuples.get(0)[0];
    	pantalla = (String) queryTuples.get(0)[1];
    }

    public Permiso(String r, String p, boolean a, boolean m)
    {
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	rolName = r;
		pantalla = p;
		acceso = a;
		modificacion = m;

		bd.Insert("INSERT INTO tPermiso VALUES ('" + rolName + "','" + pantalla + "','" + acceso + "','" + modificacion + "');");
    }
    
	public void setRolName(String value) 
	{
		BD bd = new BD(BD_SERVER, BD_NAME);
    	bd.Update("UPDATE tPermiso SET rolName = '" + value + "' WHERE rolName = '" + rolName + "';");
    	rolName = value;
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
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	pantalla = value;
    	
    	bd.Update("UPDATE tPermiso SET pantalla = '" + pantalla + "' WHERE rolName = '" + rolName + "';");
    }
    

    public boolean getAcceso() 
    { 
    	return acceso; 
    }
        
    public void setAcceso(boolean value) 
    { 
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	acceso = value;
    	
    	bd.Update("UPDATE tPermiso SET acceso = '" + acceso + "' WHERE rolName = '" + rolName + "';");

    }

    
    public boolean getModificacion() 
    { 
    	return modificacion; 
    }
    
    public void setModificacion(boolean value) 
    { 
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	modificacion = value;
    	
    	bd.Update("UPDATE tPermiso SET modificacion = '" + modificacion + "' WHERE rolName = '" + rolName + "';");

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

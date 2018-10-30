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


    public static List<Permiso> ListaPermisosRol(String rolName) {
		BD bd = new BD(BD_SERVER, BD_NAME);
		List<Object[]> queryTuples = bd.Select("select * from tPermiso where rolName = '" + rolName + "';");
        List<Permiso> allPermissions = new ArrayList<>();
        for(Object[] tuple : queryTuples) {
            allPermissions.add(new Permiso((String) tuple[0], (String) tuple[1]));
        }
        return allPermissions;
    }
    
    public Permiso(String r, String p) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> queryTuples = bd.Select("select * from tPermiso where rolName = '" + r + "' and pantalla = '" + p + "';");
        if (queryTuples.isEmpty()) throw new Error("Uhm...");
        this.rolName = (String) queryTuples.get(0)[0];
        this.pantalla = (String) queryTuples.get(0)[1];
        this.acceso = (boolean) queryTuples.get(0)[2];
        this.modificacion = (boolean) queryTuples.get(0)[3];
    }

    public Permiso(String r, String p, boolean a, boolean m) {
        this.modificacion = m; this.acceso = a;
        this.rolName = r; this.pantalla = p;
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("insert into tPermiso values '" + r + "', '" + p + "', '" + a + "', '" + m + "';" );
    }
    
	public void setRolName(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET rolName = '" + value + "' where rolName = '" + this.rolName + "';");
        this.rolName = value;
	}

	public String getRolName() 
	{
		return rolName;
	}
    
    public String getPantalla() 
    {
    	return pantalla; 
    }
    
    public void setPantalla(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET pantalla = '" + value + "' where rolName = '" + rolName + "';");
        this.pantalla = value;
    }

    public boolean getAcceso() 
    { 
    	return acceso; 
    }
        
    public void setAcceso(boolean value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET acceso = '" + value + "' where rolName = '" + rolName + "';");
        acceso = value;
    }

    
    public boolean getModificacion() 
    { 
    	return modificacion; 
    }
    
    public void setModificacion(boolean value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET modificacion = '" + modificacion + "' where rolName = '" + rolName + "';");
        this.modificacion = value;
    }

    @Override
	public boolean equals(Object o) {
		boolean res = false;
		if (o instanceof Permiso) {
			Permiso p = (Permiso) o;
			res = this.pantalla.equalsIgnoreCase(p.pantalla) 
				&& this.rolName.equalsIgnoreCase(p.rolName);
		}
		return res;
	}
	
	public int hashCode() {
		return pantalla.toLowerCase().hashCode() 
				+ rolName.toLowerCase().hashCode();
	}

	public int compareTo(Permiso p) {
		int res = this.rolName.compareToIgnoreCase(p.rolName);
		if (res == 0) res = this.pantalla.compareToIgnoreCase(p.pantalla);
		return res;
	}
}

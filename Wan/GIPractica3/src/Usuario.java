import java.util.*;

public class Usuario 
{
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    
    private String nombre;
    private String password;
    private Rol rol;

	public static List<Usuario> ListaUsuarios()
	{
		List<Usuario> lista = new ArrayList<Usuario>();
		BD bd = new BD(BD_SERVER,BD_NAME);
		
		for(Object[] tuples: bd.Select("SELECT * FROM tUsuario;"))
		{
			Usuario u = new Usuario((String)tuples[0], (String)tuples[1]);
			lista.add(u);
		}
		return lista;
	}
	
    public Usuario(String n, String p)
    {
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	List<Object[]> queryTuples = bd.Select("SELECT * FROM tUsuario WHERE nombre = '" + n + "'");
    	nombre = (String) queryTuples.get(0)[0];
    	password = (String) queryTuples.get(0)[1];
    	rol = new Rol((String)queryTuples.get(0)[2]);
    	
    	if(!password.equals(p))
    	{
    		throw new Error("La contraseña no coincide.");
    	}
    }
    
    public Usuario(String n, String p, Rol r)
    {
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	nombre = n;
		password = p;
		rol = r;

		bd.Insert("INSERT INTO tUsuario VALUES ('" + nombre + "','" + password + "','" + rol + "');");
    }

    public String getNombre() 
    { 
    	return nombre; 
    }

    public void setNombre(String value) 
    { 
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	bd.Update("UPDATE tUsuario SET nombre = '" + value + "' WHERE nombre = '" + nombre + "';");
    	nombre = value;
    }

    public void borraUsuario() 
    {     	
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	bd.Delete("DELETE FROM tUsuario WHERE nombre = '" + nombre + "' AND password = '" + password + "');");
    	nombre = null;
    	password = null;
    	rol = null;
    }
    public String getPassword() 
    { 
    	return password; 
    }
        
    public void setPassword (String value)
    { 
    	BD bd = new BD(BD_SERVER, BD_NAME);
    	password = value;
    	
    	bd.Update("UPDATE tUsuario SET password = '" + password + "' WHERE nombre = '" + nombre + "';");
    }

    public Rol getRol()
    {
        return rol;
    }
    
    public void setRol()
    {
    	throw new Error("Error: Un usuario no puede cambiar el rol de si mismo.");     
    }

    public void ModiRol(Usuario u, Rol r)
    {
		if(rol.getAdmin() == true)
		{
			BD bd = new BD(BD_SERVER, BD_NAME); 
			u.rol = r;
			bd.Update("UPDATE tUsuario SET rol = '" + u.getRol() + "' WHERE nombre = '" + u.getNombre() + "';");
		}else
		{
			throw new Error("El usuario actual no es administrador.");
		}
    }

    public boolean AccesoPantalla(String p)
    {
        return rol.Acceso(p);
    }

    public boolean ModificaPantalla(String p)
    {
        return rol.Modificacion(p);
    }
	
	public String toString()
	{
	
		return nombre + "\t" + password + "\t" + rol.getRolName();
	}
}

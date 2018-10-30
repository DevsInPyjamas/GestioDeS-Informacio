package p3;

import java.util.*;

public class Usuario {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    
    private String nombre;
    private String password;
    private Rol rol;

	public static List<Usuario> ListaUsuarios() {
		BD bd = new BD(BD_SERVER, BD_NAME);
		List<Object[]> queryTuples = bd.Select("select * from tUsuario");
		List<Usuario> allUsers = new ArrayList<>();
		for(Object[] tuple : queryTuples) {
            allUsers.add(new Usuario((String) tuple[0], (String) tuple[1]));
        }
		return allUsers;
	}
	
    public Usuario(String n, String p) {
	    BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> queryTuples = bd.Select("select * from tUsuario where nombre ='" + n + "';");
	    if(queryTuples.isEmpty()) throw new Error("Oh shit...");
        String userName = (String) queryTuples.get(0)[0], password = (String) queryTuples.get(0)[1];
        Rol rol = new Rol((String) queryTuples.get(0)[2]);
        if(!p.equals(password)) throw new Error("Password does not match...");
        this.rol = rol; this.password = password; this.nombre = userName;
    }
    
    public Usuario(String n, String p, Rol r) {
        this.nombre = n;
        this.password = p;
        this.rol = r;
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("INSERT INTO tUsuario VALUES '" + n +"', '" + p + "', " + r.getRolName() + "';");
    }

    public String getNombre() {
    	return nombre; 
    }

    public void setNombre(String value) {
	    BD bd = new BD(BD_SERVER, BD_NAME);
	    bd.Update("Update tUsuario SET nombre='" + value + "' where nombre = '" + nombre + "';");
	    this.nombre = value;
		// Actualiza el atributo en memoria y en la base de datos

    }

    public void borraUsuario() {
		// Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Delete("DELETE FROM tUsuario where nombre = '" + nombre + "';");
        this.nombre = this.password = null;
        this.rol = null;
    }
    public String getPassword() {
    	return password; 
    }
        
    public void setPassword (String value) {
	    this.password = value;
	    BD bd = new BD(BD_SERVER, BD_NAME);
	    bd.Insert("UPDATE tUsuario SET password='" + value + "' where nombre = '" + nombre + "';");
    }

    public Rol getRol() {
        return rol;
    }
    
    public void setRol() {
    	throw new Error("p3.Error: Un usuario no puede cambiar el rol de si mismo.");
    }

    public void ModiRol(Usuario u, Rol r) {
	    if(!this.getRol().getAdmin()) throw new Error("Eeeepa ande vas tan rápido nen, no eres admin");
	    BD bd = new BD(BD_SERVER, BD_NAME);
	    bd.Update("UPDATE tUsuario set rolName = '" + r.getRolName() + "' where nombre = '" + u.nombre + "';");
    }

    public boolean AccesoPantalla(String p) {
        return rol.Acceso(p);
    }

    public boolean ModificaPantalla(String p) {
        return rol.Modificacion(p);
    }
	
	public String toString() {
		return nombre + "\t" + password + "\t" + rol.getRolName();
	}
}

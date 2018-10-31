package practica;

import java.util.*;

public class Usuario {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    private String nombre;
    private String password;
    private Rol rol;

    public static List<Usuario> ListaUsuarios() {
        // Retorna una lista con todos los objetos de la clase almacenados en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> query = bd.Select("SELECT * FROM tUsuario");
        List<Usuario> list = new ArrayList<>();
        for (Object[] ob : query) {
            list.add(new Usuario(ob[0].toString(), ob[1].toString()));
        }
        return list;
    }

    public Usuario(String n, String p) {
        // Crea el objeto cargando sus valores de la base de datos
        // Si la password almacenada no se corresponde con la suministrada se elevará una excepción
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> query = bd.Select("SELECT password FROM tUsuario WHERE nombre like '" + n + "';");
        if(query.isEmpty()) throw new Error("Ehhhhh...");
        Object[] user = query.get(0);
        String userName = user[0].toString(), password = user[1].toString();
        Rol rol = new Rol(user[2].toString());
        if(!p.equalsIgnoreCase(password)) throw new Error("Passwords doesn't match...");
        this.nombre = userName;
        this.password = password;
        this.rol = rol;
    }

    public Usuario(String n, String p, Rol r) {
        // Crea el objeto y lo inserta en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        this.nombre = n;
        this.password = p;
        this.rol = r;
        bd.Insert("INSERT INTO tUsuario VALUES('" + n + "', '" + p + "', '" + r.getRolName() + "';");
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tUsuario set nombre = '" + value + "' WHERE nombre like '" + nombre + "';");
        this.nombre = value;
    }

    public void borraUsuario() {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Delete("DELETE FROM tUsuario WHERE nombre like '" + this.nombre + "';");
        this.nombre = this.password = null; this.rol = null;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tUsuario set password = '" + value + "' WHERE nombre like '" + nombre + "';");
        this.password = value;
    }

    public Rol getRol() {
        return rol;
    }

    public void setRol() {
        throw new Error("practica.Error: Un usuario no puede cambiar el rol de si mismo.");
    }

    public void ModiRol(Usuario u, Rol r) {
        // Si el objeto actual es administrador
        // Actualiza el atributo rol de u en memoria y en la base de datos
        if(!this.getRol().getAdmin()) throw new Error("Ehh, no tan rápido, tu admin eres no");
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tUsuario SET rolName = '" + r.getRolName() + "' WHERE nombre like '" + u.getNombre() + "';");
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

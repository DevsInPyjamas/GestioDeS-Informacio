import java.util.*;

public class Usuario {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";

    private String nombre;
    private String password;
    private Rol rol;

    public static List<Usuario> ListaUsuarios() {
        // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        ArrayList<Usuario> lista = new ArrayList<Usuario>();

        for (Object[] tupla : miBD.Select("SELECT nombre,password FROM tUsuario;")) {
            String id = (String) tupla[0];
            String p = (String) tupla[1];
            Usuario u = new Usuario(id, p);
            lista.add(u);
        }
        return lista;
    }

    public Usuario(String n, String p) {
        // Crea el objeto cargando sus valores de la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);

        Object[] tupla = miBD.Select("SELECT * FROM tUsuario WHERE nombre='" + n + "';").get(0);

        nombre = (String) tupla[0];
        password = (String) tupla[1];

        if (p.compareTo(password) != 0) {
            nombre = password = null;
            rol = null;
            throw new Error("Usuario o Contrase�a Incorrecta");
        }

        rol = new Rol((String) tupla[2]);

    }

    public Usuario(String n, String p, Rol r) {
        // Crea el objeto y lo inserta en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);

        miBD.Insert("INSERT INTO tUsuario VALUES("
                + "'" + n + "', '" + p + "', '" + r.getRolName() + "');");

        nombre = n;
        password = p;
        rol = r;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String value) {

        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update("UPDATE tUsuario SET nombre = '" + value
                + "' WHERE nombre ='" + this.nombre + "';");

        nombre = value;
    }

    public void borraUsuario() {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Delete("DELETE FROM  tUsuario WHERE nombre ='" + this.nombre + "';");
        nombre = password = null;
        rol = null;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update("UPDATE tUsuario SET password = '" + value
                + "' WHERE nombre ='" + this.nombre + "';");

        password = value;
    }

    public Rol getRol() {
        return rol;
    }

    public void setRol() {
        throw new Error("Error: Un usuario no puede cambiar el rol de si mismo.");
    }

    public void ModiRol(Usuario u, Rol r) {
        if (this.rol.getAdmin()) {
            // Actualiza el atributo rol de u en memoria y en la base de datos
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Update("UPDATE tUsuario SET rolName = '" + r.getRolName()
                    + "' WHERE nombre ='" + u.getNombre() + "';");

            u.rol = r;

        } else throw new Error("El usuario " + this.getNombre()
                + " no puede cambiar el rol del usuario "
                + u.getNombre());
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

import java.util.*;

public class Usuario {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";

    private String nombre;
    private String password;
    private Rol rol;

    public static List<Usuario> ListaUsuarios() {
        // Retorna una lista con todos los objetos de la clase almacenados en la base de datos
        List<Usuario> lista = new ArrayList<Usuario>();
        BD miBD = new BD(BD_SERVER, BD_NAME);

        for (Object[] tupla : miBD.Select("SELECT * FROM tUsuario;")) {
            Usuario u = new Usuario((String) tupla[0], (String) tupla[1]);
            lista.add(u);
        }
        return lista;
    }

    public Usuario(String n, String p) {
        // Crea el objeto cargando sus valores de la base de datos
        // Si la password almacenada no se corresponde con la suministrada se elevara una excepcion
        BD miBD = new BD(BD_SERVER, BD_NAME);
        Object[] tupla = miBD.Select(String.format("Select * from tUsuario where nombre='%s';",
                n)).get(0);
        if(tupla[1].equals(p)){
            this.nombre = (String) tupla[0];
            this.password = (String) tupla[1];
            this.rol = new Rol((String) tupla[2]);
        } else {
            throw new Error("Usuario y contraseña no coinciden");
        }
    }

    public Usuario(String n, String p, Rol r) {
        // Crea el objeto y lo inserta en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert(String.format("Insert into tUsuario(nombre, password, rolName) values ('%s', '%s', '%s');",
                n, p, r.getRolName()));
        this.nombre = n;
        this.password = p;
        this.rol = r;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String value) {

        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tUsuario set nombre = '%s' where nombre = '%s';", value, this.nombre));
        this.nombre = value;

    }

    public void borraUsuario() {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Delete(String.format("delete from tUsuario where nombre = '%s';", this.nombre));
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tUsuario set password = '%s' where nombre = '%s';", value, this.nombre));
        this.password = value;

    }

    public Rol getRol() {
        return rol;
    }

    public void setRol() {
        throw new Error("Error: Un usuario no puede cambiar el rol de si mismo.");
    }

    public void ModiRol(Usuario u, Rol r) {
        // Si el objeto actual es administrador
        if(this.rol.getAdmin()){
            BD miBD = new BD(BD_SERVER, BD_NAME);
            miBD.Update(String.format("update tUsuario set rolName = '%s' where nombre = '%s';", r.getRolName(),
                    u.nombre));
            u.rol = r;
        }

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

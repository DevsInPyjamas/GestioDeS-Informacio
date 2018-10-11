package User;

public class Usuario {
    private String nombre, password;
    private Rol rol;

    public Usuario(String nombre, String password, Rol rol) {
        this.nombre = nombre;
        this.password = password;
        this.rol = rol;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public Rol getRol() {
        return rol;
    }

    public void ModiRol(Usuario user, Rol roll) {
        if (this.rol.isAdmin()) {
            user.rol = roll;
            System.out.println("Rol modificado");
        } else {
            System.out.println("ERROR: el usuario " + nombre +
                    " no puede cambiar el rol del usuario " + user.getNombre());
        }
    }

    public boolean AccesoAPantalla(String pantalla) {
        return rol.acceso(pantalla);
    }

    public boolean ModificarPantalla(String pantalla) {
        return rol.modificacion(pantalla);
    }
}

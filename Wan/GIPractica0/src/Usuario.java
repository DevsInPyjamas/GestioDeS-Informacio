public class Usuario
{
    private String nombre;
    private String password;
    private Rol rol;

    public Usuario(String n, String p, Rol r)
    {
        nombre = n;
        password = p;
        rol = r;
    }

    public String getNombre()
    {
        return nombre;
    }

    public void setNombre(String nombre)
    {
        this.nombre = nombre;
    }

    public String getPassword()
    {
        return password;
    }

    public void setPassword(String password)
    {
        this.password = password;
    }

    public Rol getRol()
    {
        return rol;
    }

    public void ModiRol(Usuario u, Rol r)
    {
        if(rol.admin)
        {
            u.rol = r;
            System.out.println("ROL MODIFICADO\n");
        }else
        {
            System.out.println("ERROR: NO ES ADMIN\n");
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
}

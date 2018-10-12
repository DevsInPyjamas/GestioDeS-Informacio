import java.util.*;

public class Rol
{
    public boolean admin;
    public String rolDes;
    public String rolName;
    public ArrayList<Permiso> permisos;

    public Rol(String name, String des, boolean adm)
    {
        admin = adm;
        rolDes = des;
        rolName = name;
        permisos = new ArrayList<>();
    }

    public boolean isAdmin()
    {
        return admin;
    }

    public String getRolDes()
    {
        return rolDes;
    }

    public void setRolDes(String rolDes)
    {
        this.rolDes = rolDes;
    }

    public String getRolName()
    {
        return rolName;
    }

    public void setRolName(String rolName)
    {
        this.rolName = rolName;
    }

    public boolean Acceso(String pantalla)
    {
        Iterator it = permisos.iterator();
        boolean acceso = false;
        Permiso per;

        while(it.hasNext())
        {
            per = (Permiso) it.next();
            if(per.getPantalla().equals(pantalla))
            {
                acceso = per.isAcceso();
            }
        }
        return acceso;
    }

    public boolean Modificacion(String pantalla)
    {
        Iterator it = permisos.iterator();
        boolean mod = false;
        Permiso per;

        while(it.hasNext())
        {
            per = (Permiso) it.next();
            if(per.getPantalla().equals(pantalla))
            {
                mod = per.isModificacion();
            }
        }
        return mod;
    }

    public void AddPermiso(Permiso p)
    {
        if(!permisos.contains(p))
        {
            permisos.add(p);
        }
    }
}

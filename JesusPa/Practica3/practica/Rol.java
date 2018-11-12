package practica;
import java.util.*;

public class Rol {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";

    private String rolName;
    private String rolDes;
    private boolean admin;
    private List<Permiso> permisos; //Lazzy

    public static List<Rol> ListaRoles() {
        // Retorna una lista con todos los obejtos de la clase almacenados en la base de datos
        List<Rol> lista = new ArrayList<Rol>();
        BD miBD = new BD(BD_SERVER, BD_NAME);

        for (Object[] tupla : miBD.Select("SELECT * FROM tRol;")) {
            Rol r = new Rol((String) tupla[0]);
            lista.add(r);
        }
        return lista;
    }

    public Rol(String name) {
        // Crea el objeto cargando sus valores de la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        Object[] tupla = miBD.Select("SELECT * FROM tRol WHERE rolName = '"
                + name + "';").get(0);

        rolName = (String) tupla[0];
        rolDes = (String) tupla[1];
        admin = (Boolean) tupla[2];
        permisos = null;
    }

    public Rol(String name, String des, boolean adm) {
        // Crea el objeto y lo inserta en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert("INSERT INTO tRol VALUES('" + name +
                "', '" + des + "', " + (adm ? 1 : 0) + ");");
        rolName = name;
        rolDes = des;
        admin = adm;
        permisos = null;
    }

    public String getRolName() {
        return rolName;
    }

    public void setRolName(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update("UPDATE tRol SET rolName = '" + value
                + "' WHERE rolName = '" + this.rolName + "';");
        this.rolName = value;
    }

    public String getRolDes() {
        return rolDes;
    }

    public void setRolDes(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update("UPDATE tRol SET rolDes = '" + value
                + "' WHERE rolName = '" + this.rolName + "';");
        this.rolDes = value;
    }

    public boolean getAdmin() {
        return admin;
    }

    public void setAdmin(boolean value) {
        throw new Error("Un practica.Rol no puede concederse permisos de administraci�n a s� mismo.");
    }

    public void setAdmin(Rol other, boolean value) {
        if (!admin) throw new Error("practica.Rol sin permiso para establecer administradores.");

        // Actualiza el atributo admin de other en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update("UPDATE tRol SET admin = " + (value ? 1 : 0)
                + " WHERE rolName = '" + other.rolName + "';");
        other.admin = value;
    }

    private List<Permiso> getPermisos() {
        if (permisos == null) permisos = Permiso.ListaPermisosRol(this.rolName);
        return permisos;
    }

    public boolean Acceso(String pantalla) {
        for (Permiso p : this.getPermisos()) {
            if (p.getPantalla().compareToIgnoreCase(pantalla) == 0)
                return p.getAcceso();
        }
        return false;
    }

    public boolean Modificacion(String pantalla) {
        for (Permiso p : this.getPermisos()) {
            if (p.getPantalla().compareToIgnoreCase(pantalla) == 0)
                return p.getModificacion();
        }
        return false;
    }

    public void AddPermiso(Permiso p) {
        if (!this.getPermisos().contains(p)) {
            permisos.add(p);
        }
    }

}

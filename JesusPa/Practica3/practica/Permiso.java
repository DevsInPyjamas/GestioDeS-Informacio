package practica;
import java.util.*;

public class Permiso implements Comparable<Permiso> {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    private String rolName;
    private String pantalla;
    private boolean acceso;
    private boolean modificacion;


    public static List<Permiso> ListaPermisosRol(String rolName) {
        // Retorna una lista con todos los permisos de un rol determinado
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> query = bd.Select("SELECT * FROM tPermiso WHERE rolName = '" + rolName + "';");
        List<Permiso> list = new ArrayList<>();

        for (Object[] object : query) {
            list.add(new Permiso(object[0].toString(), object[1]. toString()));
        }

        return list;
    }

    public Permiso(String r, String p) {
        // Crea el objeto cargando sus valores de la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> query = bd.Select("SELECT * FROM tPermiso where rolName = '" + r +
                "' and pantalla = '" + p + "';");
        if(query.isEmpty()) throw new Error("Ehhhh...");
        Object[] tuple = query.get(0);
        this.rolName = tuple[0].toString();
        this.pantalla = tuple[1].toString();
        this.acceso = (Boolean) tuple[2];
        this.modificacion = (Boolean) tuple[3];
    }

    public Permiso(String r, String p, boolean a, boolean m) {
        // Crea el objeto y lo inserta en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        this.rolName = r;
        this.pantalla = p;
        this.acceso = a;
        this.modificacion = m;
        bd.Insert("INSERT INTO tPermiso values (" + this.rolName + ", " + this.pantalla + ", " +
                this.acceso + ", " + this.modificacion + ");");
    }

    public void setRolName(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET rolName = '" + value + "' WHERE rolName = '" + this.rolName + "';");
        this.rolName = value;
    }

    public String getRolName() {
        return rolName;
    }

    public String getPantalla() {
        return pantalla;
    }

    public void setPantalla(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET pantalla = '" + value + "' WHERE rolName = '" + this.rolName + "';");
        this.pantalla = value;
    }


    public boolean getAcceso() {
        return acceso;
    }

    public void setAcceso(boolean value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET acceso = '" + value + "' WHERE rolName = '" + this.rolName + "';");
        this.acceso = value;
    }


    public boolean getModificacion() {
        return modificacion;
    }

    public void setModificacion(boolean value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPermiso SET modificacion = '" + value + "' WHERE rolName = '" + this.rolName + "';");
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

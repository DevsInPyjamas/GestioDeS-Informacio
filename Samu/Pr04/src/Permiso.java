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
        List<Permiso> lista = new ArrayList<Permiso>();
        BD miBD = new BD(BD_SERVER, BD_NAME);

        for (Object[] tupla : miBD.Select("SELECT * FROM tPermiso;")) {
            Permiso p = new Permiso((String) tupla[0], (String) tupla[1]);
            lista.add(p);
        }
        return lista;
    }

    public Permiso(String r, String p) {
        // Crea el objeto cargando sus valores de la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        Object[] tupla = miBD.Select(String.format("select * from tPermiso where rolName = '%s' and pantalla = '%s';",
                r, p)).get(0);

        rolName = (String) tupla[0];
        pantalla = (String) tupla[1];
        acceso = (boolean) tupla[2];
        modificacion = (boolean) tupla[3];

    }

    public Permiso(String r, String p, boolean a, boolean m) {
        // Crea el objeto y lo inserta en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert(String.format("Insert into tPermiso(rolName, pantalla, acceso, modificacion) " +
                        "values ('%s', '%s', %s, %s);",
                r, p, a?1:0, m?1:0));
        this.rolName = r;
        this.pantalla = p;
        this.acceso = a;
        this.modificacion = m;

    }

    public void setRolName(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPermiso set rolName = '%s' where rolName = '%s';", value, this.rolName));
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
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPermiso set acceso = '%s' where pantalla = '%s';", value, this.pantalla));
        this.pantalla = value;

    }


    public boolean getAcceso() {
        return acceso;
    }

    public void setAcceso(boolean value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPermiso set acceso = %s where rolName = '%s' and pantalla = '%s';",
                value?1:0, this.rolName, this.pantalla));
        this.acceso = value;

    }


    public boolean getModificacion() {
        return modificacion;
    }

    public void setModificacion(boolean value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPermiso set modificacion = %s where rolName = '%s' and pantalla = '%s';",
                value?1:0, this.rolName, this.pantalla));
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

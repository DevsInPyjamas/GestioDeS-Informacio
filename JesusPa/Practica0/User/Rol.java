package User;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Rol {
    private String rolName, rolDes;
    private boolean admin;
    private List<Permiso> permisos;

    public Rol(String name, String des, boolean admin) {
        rolName = name;
        rolDes = des;
        this.admin = admin;
        permisos = new ArrayList<>();
    }

    public String getRolName() {
        return rolName;
    }

    public void setRolName(String rolName) {
        this.rolName = rolName;
    }

    public String getRolDes() {
        return rolDes;
    }

    public void setRolDes(String rolDes) {
        this.rolDes = rolDes;
    }

    public boolean isAdmin() {
        return admin;
    }

    public boolean acceso(String pantalla) {
        Permiso permiso;
        Iterator it = permisos.iterator();

        while (it.hasNext()) {
            permiso = (Permiso) it.next();
            if (pantalla.equals(permiso.getPantalla())) {
                return permiso.isAcceso();
            }
        }

        return false;
    }

    public boolean modificacion(String pantalla) {
        Permiso permiso;
        Iterator it = permisos.iterator();

        while (it.hasNext()) {
            permiso = (Permiso) it.next();
            if (pantalla.equals(permiso.getPantalla())) {
                return permiso.isModificacion();
            }
        }

        return false;
    }

    public void addPermiso(Permiso permiso) {
        if (!permisos.contains(permiso)) {
            permisos.add(permiso);
        }
    }
}

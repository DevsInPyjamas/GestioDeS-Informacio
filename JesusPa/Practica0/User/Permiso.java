package User;

public class Permiso {
    public String pantalla;
    public boolean acceso, modificacion;

    public Permiso(String pantalla, boolean acceso, boolean modificacion) {
        this.pantalla = pantalla;
        this.acceso = acceso;
        this.modificacion = modificacion;
    }

    public String getPantalla() {
        return pantalla;
    }

    public void setPantalla(String pantalla) {
        this.pantalla = pantalla;
    }

    public boolean isAcceso() {
        return acceso;
    }

    public void setAcceso(boolean acceso) {
        this.acceso = acceso;
    }

    public boolean isModificacion() {
        return modificacion;
    }

    public void setModificacion(boolean modificacion) {
        this.modificacion = modificacion;
    }
}

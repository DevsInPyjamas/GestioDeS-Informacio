public class Permiso
{
    public String pantalla;
    public boolean acceso;
    public boolean modificacion;

    public Permiso(String p, boolean a, boolean m)
    {
        pantalla = p;
        acceso = a;
        modificacion = m;
    }

    public String getPantalla()
    {
        return pantalla;
    }

    public void setPantalla(String pantalla)
    {
        this.pantalla = pantalla;
    }

    public boolean isAcceso()
    {
        return acceso;
    }

    public void setAcceso(boolean acceso)
    {
        this.acceso = acceso;
    }

    public boolean isModificacion()
    {
        return modificacion;
    }

    public void setModificacion(boolean modificacion)
    {
        this.modificacion = modificacion;
    }
}

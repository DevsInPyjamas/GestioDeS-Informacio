import java.util.*;

public class Pais {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";

    private String cod;
    private String des;

    public static List<Pais> ListaPaises() {
        List<Pais> lista = new ArrayList<Pais>();
        BD miBD = new BD(BD_SERVER, BD_NAME);

        for (Object[] tupla : miBD.Select("SELECT * FROM tPais;")) {
            Pais u = new Pais((String) tupla[0], (String) tupla[1]);
            lista.add(u);
        }
        return lista;
    }

    public Pais(String cod) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        Object[] tupla = miBD.Select(String.format("Select * from tPais where Codigo='%s';", cod)).get(0);
        this.cod = (String) tupla[0];
        this.des = (String) tupla[1];
    }

    public Pais(String cod, String des) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Insert(String.format("insert into tPais(Codigo, Descripcion) values ('%s', '%s')", cod, des));
        this.cod = cod;
        this.des = des;
    }

    public String getCodigo() {
        return cod;
    }

    public void setCodigo(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPais set Codigo = '%s' where Codigo = '%s';", value, this.cod));
        this.cod = value;
    }

    public String getDescripcion() {
        return des;
    }

    public void setDescripcion(String value) {
        BD miBD = new BD(BD_SERVER, BD_NAME);
        miBD.Update(String.format("update tPais set Descripcion = '%s' where Codigo = '%s';", value, this.cod));
        this.des = value;
    }

    public String toString() {
        return des;
    }
}

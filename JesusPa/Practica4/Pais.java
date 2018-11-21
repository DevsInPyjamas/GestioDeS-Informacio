import java.util.*;

public class Pais {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";

    private String cod;
    private String des;

    public static List<Pais> ListaPaises() {
        List<Pais> list = new ArrayList<>();
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Object[]> query = bd.Select("SELECT * FROM tPais");
        for (Object[] ob : query) {
            list.add(new Pais(ob[0].toString(), ob[1].toString()));
        }
        return list;
    }

    public Pais(String cod) {
        BD miBD = new BD(BD_SERVER, BD_NAME);

        Object[] tuples = miBD.Select("SELECT * FROM tPais WHERE Codigo = '" + cod + "';").get(0);

        this.cod = (String) tuples[0];
        this.des = (String) tuples[1];
    }

    public Pais(String cod, String des) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("INSERT INTO tPais VALUES('" + this.cod + "', '" + this.des + "')");
        this.cod = cod;
        this.des = des;
    }

    public String getCodigo() {
        return cod;
    }

    public void setCodigo(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPais set Codigo = '" + this.cod + "';");
        this.cod = value;
    }

    public String getDescripcion() {
        return des;
    }

    public void setDescripcion(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPais set Descripcion = '" + this.des + "' where Codigo like '" + this.cod + "';");
        this.des = value;
    }

    public String toString() {
        return des;
    }
}

import java.util.*;

public class Pais {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "GI1819";
    
    private String cod;
    private String des;

    public static List<Pais> ListaPaises() {
        List<Pais> lista = new ArrayList<Pais>();
        BD bd = new BD(BD_SERVER, BD_NAME);
        for(Object[] tupla: bd.Select("SELECT * FROM tPais;")){
            lista.add(new Pais((String) tupla[0]));
        }
        return lista;
    }

    public Pais(String cod) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        Object[] tupla = bd.Select("SELECT * FROM tPais WHERE codigo = '" + cod + "';").get(0);
        this.cod = (String) tupla[0];
        this.des = (String) tupla[1];
    }

    public Pais(String cod, String des) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("INSERT INTO tPais VALUES('" + cod + "', '" + des + "';");
        this.cod = cod; this.des = des;
    }

    public String getCodigo()
    {
        return cod;
    }

    public void setCodigo(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPais set codigo = '" + value + "' where codigo = '" + this.cod + "';");
        this.cod = value;
    }

    public String getDescripcion()
    {
        return des;
    }

    public void setDescripcion(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tPais set descripcion = '" + value + "' where descripcion = '" + this.cod + "';");
        this.des = value;
    }

    public String toString()
    {
        return des;
    }
}

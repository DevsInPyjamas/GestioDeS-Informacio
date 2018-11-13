import java.util.ArrayList;
import java.util.List;

public class Abeja {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "Abejas";
    private String Nombre_Científico, Nombre_Comun;

    public static List<Abeja> ListaAbejas() {
        //Retorna una lista con todos los objetos de la clase almacenados en la base de datos.
        BD bd = new BD(BD_SERVER, BD_NAME);
        List<Abeja> list = new ArrayList<>();
        for (Object[] query : bd.Select("SELECT * FROM Abejas;")) {
            list.add(new Abeja((String) query[0], (String) query[1]));
        }
        return list;
    }

    public Abeja(String Nombre_Científico) {
        //Crea el objeto cargando sus valores de la base de datos.
        BD bd = new BD(BD_SERVER, BD_NAME);
        Object[] query = bd.Select("SELECT * FROM Abejas WHERE Nombre_Cientifico = '" + Nombre_Científico + "';").get(0);
        this.Nombre_Científico = (String) query[0];
        this.Nombre_Comun = (String) query[1];
    }

    public Abeja(String Nombre_Científico, String Nombre_Comun) {
        //Crea el objeto y lo inserta en la base de datos.
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("INSERT INTO Abejas(Nombre_Cientifico, Nombre_Comun) VALUES('"+
                Nombre_Científico + "', '" + Nombre_Comun + "');");
        this.Nombre_Comun = Nombre_Comun;
        this.Nombre_Científico = Nombre_Científico;
    }

    public String getNombre_Científico() {
        return Nombre_Científico;
    }

    public void setNombre_Científico(String value) {
        //actualiza el nombre científico de la abeja en memoria y en la base de datos.
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("UPDATE Abejas SET Nombre_Cientifico = '" + value + "' WHERE Nombre_Cientifico = '" +
                this.Nombre_Científico +"';");
        this.Nombre_Científico = value;
    }

    public String getNombre_Comun() {
        return Nombre_Comun;
    }

    public void setNombre_Comun(String value) {
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("UPDATE Abejas SET Nombre_Comun = '" + value + "' WHERE Nombre_Cientifico = '" +
                this.Nombre_Científico +"';");
        this.Nombre_Comun = value;
    }

    public void Borrar() {
        //borra la abeja en la base de datos y deja sus atributos a null.
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Delete("DELETE FROM Abejas WHERE Nombre_Cientifico = '" + this.Nombre_Científico + "';");
    }

    public boolean equals(Object p) {
        return p instanceof Abeja
                && ((Abeja) p).Nombre_Científico.equalsIgnoreCase(this.Nombre_Científico);
    }

    public int compareTo(Abeja arg0) {
        return Nombre_Científico.compareToIgnoreCase(arg0.Nombre_Científico);
    }

    public int hashCode() {
        return Nombre_Científico.hashCode();
    }

    public String toString() {
        return this.Nombre_Científico + "\t" + this.Nombre_Comun;
    }
}

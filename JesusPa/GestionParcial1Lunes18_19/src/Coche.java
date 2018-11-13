import java.util.*;

public class Coche implements Comparable<Coche> {
    private static String BD_SERVER = "localhost";
    private static String BD_NAME = "P1L1819";

    private String matricula;
    private String marca;
    private String modelo;
    private int year_matricula;
    private List<Integer> paso_itv;

    public static List<Coche> ListaCoche() {
        ArrayList<Coche> lista = new ArrayList<Coche>();
        // Retorna una lista con todos los objetos de la clase almacenados en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        for(Object[] query : bd.Select("SELECT * FROM tCoche;")){
            Coche car = new Coche((String) query[0]);
            lista.add(car);
        }
        return lista;
    }

    public Coche(String m) {
        // Crea el objeto cargando sus valores de la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        Object[] query = bd.Select("SELECT * FROM tCoche WHERE MATRICULA = '" + m + "';").get(0);
        this.matricula = (String) query[0];
        this.marca = (String) query[1];
        this.modelo = (String) query[2];
        this.year_matricula = (int) query[3];
        this.paso_itv = new ArrayList<>();
        
        for (Object[] query2 : bd.Select("SELECT * FROM tITV WHERE MATRICULA = '" + this.matricula + "';")) {
        	this.paso_itv.add((int) query2[2]);
        }
    }

    public Coche(String m, String ma, String mo, int y) {
        // Crea el objeto y lo inserta en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("INSERT INTO tCoche(MATRICULA, MARCA, MODELO, YEAR_MATRICULA) VALUES ('"
                + m + "', '" + ma + "', '" + mo + "', '" + y + "');");
        this.matricula = m;
        this.marca = ma;
        this.modelo = mo;
        this.year_matricula = y;
    }

    public String getMatricula() {
        return matricula;
    }

    public void setMatricula(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tCoche SET MATRICULA = '" + value + "' WHERE MATRICULA = '" + this.matricula + "';");
        this.matricula = value;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tCoche SET MARCA = '" + value + "' WHERE MATRICULA = '" + this.matricula + "';");
        this.marca = value;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tCoche SET MODELO = '" + value + "' WHERE MATRICULA = '" + this.matricula + "';");
        this.modelo = value;
    }

    public int getYear_matricula() {
        return year_matricula;
    }

    public void setYear_matricula(int value) {
        // Actualiza el atributo en memoria y en la base de datos
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Update("UPDATE tCoche SET YEAR_MATRICULA = '" + value + "' WHERE MATRICULA = '" + this.matricula + "';");
        this.year_matricula = value;
    }

    public List<Integer> getPaso_itv() {
        return paso_itv;
    }

    public void addITV(int y) {
        // Añade un año de inspecciñn de la itv
        BD bd = new BD(BD_SERVER, BD_NAME);
        bd.Insert("INSERT INTO tITV(MATRICULA, YEAR_ITV) VALUES('" + this.matricula +
                "', '" + y + "');");
        paso_itv.add(y);
    }

    @Override
    public boolean equals(Object o) {
        boolean res = false;
        if (o instanceof Coche) {
            Coche c = (Coche) o;
            res = this.matricula.equalsIgnoreCase(c.matricula);
        }
        return res;
    }

    public int hashCode() {
        return matricula.toLowerCase().hashCode();
    }

    public int compareTo(Coche c) {
        return this.matricula.compareToIgnoreCase(c.matricula);
    }

    public String toString() {
        String str = matricula + "\t" + marca + "\t" + modelo + "\t" + year_matricula;
        for (int x : getPaso_itv()) str += ("\n\t" + x);

        return str;
    }
}

import java.util.*;


public class Coche implements Comparable<Coche>
{
	private static String BD_SERVER = "localhost";
	private static String BD_NAME = "P1L1819";

	private String matricula;
	private String marca;
	private String modelo;
	private int year_matricula;
	private List<Integer> paso_itv = new ArrayList<>();


	public static List<Coche> ListaCoche()
	{

		ArrayList<Coche> lista = new ArrayList<Coche>();
		// Retorna una lista con todos los objetos de la clase almacenados en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		for(Object[] tupla : bd.Select("SELECT * FROM tCoche;")) {
			lista.add(new Coche((String) tupla[0]));
		}
		return lista;
	}

	@SuppressWarnings("unchecked")
	public Coche(String m) {
		// Crea el objeto cargando sus valores de la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		Object[] tuple = bd.Select("SELECT * FROM tCoche where matricula = '" + m + "';").get(0);
		if (tuple != null) {
			this.matricula = (String) tuple[0];
			this.marca = (String) tuple[1];
			this.modelo = (String) tuple[2];
			this.year_matricula = (int) tuple[3];
			for(Object[] tupla : bd.Select("select year_itv from tITV where matricula = '" + m + "';")) {
				paso_itv.add((int) tupla[0]);
			}
		} else {
			throw new Error("OOF");
		}
	}

	public Coche(String m, String ma, String mo, int y) {
		// Crea el objeto y lo inserta en la base de datos
		this.matricula = m; this.marca = ma; this.modelo = mo; this.year_matricula = y;
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Insert("Insert into tCoche values ('" + m + "', '" + ma + "', '" + mo + "', '" + y + "';");
	}

	public String getMatricula()
	{
		return matricula;
	}

	public void setMatricula(String value)
	{
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tCoche set matricula = '" + value + "' where matricula = '" + this.matricula + "';");
		this.matricula = value;
	}

	public String getMarca()
	{
		return marca;
	}

	public void setMarca(String value)
	{
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tCoche set marca = '" + value + "' where matricula = '" + this.matricula + "';");
		this.marca = value;
	}

	public String getModelo()
	{
		return modelo;
	}

	public void setModelo(String value)
	{
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tCoche set modelo = '" + value + "' where matricula = '" + this.matricula + "';");
		this.modelo = value;

	}

	public int getYear_matricula()
	{
		return year_matricula;
	}

	public void setYear_matricula(int value)
	{
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tCoche set year_matricula = '" + value + "' where matricula = '" + this.matricula + "';");
		this.year_matricula = value;

	}

	public List<Integer> getPaso_itv()
	{

		return paso_itv;
	}

	public void addITV(int y) {
		// Añade un año de inspección de la itv
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Insert("Insert into tITV (matricula, year_itv) values ('" + this.matricula + "', '" + y + "');");
		paso_itv.add(y);
	}

	@Override
	public boolean equals(Object o)
	{
		boolean res = false;
		if (o instanceof Coche)
		{
			Coche c = (Coche) o;
			res = this.matricula.equalsIgnoreCase(c.matricula);
		}
		return res;
	}

	public int hashCode()
	{
		return matricula.toLowerCase().hashCode();
	}

	public int compareTo(Coche c)
	{
		return this.matricula.compareToIgnoreCase(c.matricula);
	}

	public String toString()
	{
		String str = matricula + "\t" + marca + "\t" + modelo + "\t" + year_matricula;
		for(int x: getPaso_itv()) str += ("\n\t"+x);

		return str;
	}
}

import java.util.*;

public class Libro implements Comparable<Libro> {
	private static String BD_SERVER = "localhost";
	private static String BD_NAME = "P1M1819";

	private String isbn;
	private String titulo;
	private String editorial;
	private int year_isbn;
	private List<Integer> ediciones;

	public static List<Libro> ListaLibros() {
		// Retorna una lista con todos los obejtos de la clase almacenados en la base de
		// datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		ArrayList<Libro> lista = new ArrayList<Libro>();
		for (Object[] query : bd.Select("SELECT * FROM tLibro;")) {
			lista.add(new Libro((String) query[0]));
		}

		return lista;
	}

	public Libro(String m) {
		// Crea el objeto cargando sus valores de la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		Object[] query = bd.Select("SELECT * FROM tLibro WHERE ISBN = '" + m + "';").get(0);
		if (query != null) {
			this.isbn = (String) query[0];
			this.titulo = (String) query[1];
			this.editorial = (String) query[2];
			this.year_isbn = (int) query[3];
			this.ediciones = new ArrayList<>();
			
			for (Object[] query2 : bd.Select("SELECT * FROM tEdiciones WHERE ISBN = '" + this.isbn + "';")) {
				if(query2 != null) {
					this.ediciones.add((Integer) query2[2]);
				}
			}
		} else {
			throw new Error("No hay datos para ese ISBN...");
		}

	}

	public Libro(String isbn, String titulo, String editorial, int year) {
		// Crea el objeto y lo inserta en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Insert("INSERT INTO tLibro VALUES('" + isbn + "', '" + titulo + "', '" + editorial + "', '" + year + "');");
		this.isbn = isbn;
		this.titulo = titulo;
		this.editorial = editorial;
		this.year_isbn = year;
	}

	public String getISBN() {
		return isbn;
	}

	public void setISBN(String value) {
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tEdiciones SET ISBN = '" + value + "' WHERE ISBN = '" + this.isbn + "';");
		this.isbn = value;
	}

	public String getTitulo() {
		return titulo;
	}

	public void setTitulo(String value) {
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tEdiciones SET TITULO = '" + value + "' WHERE ISBN = '" + this.isbn + "';");
		this.titulo = value;
	}

	public String getEditorial() {
		return editorial;
	}

	public void setEditorial(String value) {
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tEdiciones SET EDITORIAL = '" + value + "' WHERE ISBN = '" + this.isbn + "';");
		this.editorial = value;
	}

	public int getYear_ISBN() {
		return year_isbn;
	}

	public void setYear_ISBN(int value) {
		// Actualiza el atributo en memoria y en la base de datos
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Update("UPDATE tEdiciones SET YEATR_ISBN = '" + value + "' WHERE ISBN = '" + this.isbn + "';");
		this.year_isbn = value;
	}

	public List<Integer> getEdiciones() {
		// Devuelve los años de todas las ediciones de un libro

		return ediciones;
	}

	public void addEdicion(int y) {
		// Añade un año de edición de un libro
		BD bd = new BD(BD_SERVER, BD_NAME);
		bd.Insert("INSERT INTO tEdiciones(ISBN, YEAR) VALUES('" + this.isbn + "', '" + y + "');");
		this.ediciones.add(y);
	}

	@Override
	public boolean equals(Object o) {
		boolean res = false;
		if (o instanceof Libro) {
			Libro c = (Libro) o;
			res = this.isbn.equalsIgnoreCase(c.isbn);
		}
		return res;
	}

	public int hashCode() {
		return isbn.toLowerCase().hashCode();
	}

	public int compareTo(Libro c) {
		return this.isbn.compareToIgnoreCase(c.isbn);
	}

	public String toString() {
		String str = isbn + "\t" + titulo + "\t" + editorial + "\t" + year_isbn;
		for (int x : getEdiciones())
			str += ("\n\t" + x);

		return str;
	}
}

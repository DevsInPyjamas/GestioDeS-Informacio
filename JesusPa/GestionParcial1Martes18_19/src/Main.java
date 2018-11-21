import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Main {

	@SuppressWarnings("resource")
	public static void main(String[] args) {
		System.out.println("A�adimos las ediciones a la base de datos.");
		System.out.println("A�adiendo las ediciones a la base de datos... ");
		//A�adimos las ediciones a la base de datos
		try (Scanner sc = new Scanner(new File("ediciones.txt"))){
			while(sc.hasNextLine()) {
				Scanner lineScanner = new Scanner(sc.nextLine());
				lineScanner.useDelimiter(";");
				while(lineScanner.hasNext()) {
					String ISBN = lineScanner.next();
					int year = lineScanner.nextInt();
					Libro libro = new Libro(ISBN);
					libro.addEdicion(year);
					System.out.println("A�o " + year + " a�adido al libro con ISBN: " + ISBN);
				}
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		}
		
		System.out.println("Mostramos por pantalla todos los libros con sus ediciones.");
		for(Libro libro : Libro.ListaLibros()) {
			System.out.println(libro);
		}
	}

}

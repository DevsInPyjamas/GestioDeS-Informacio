import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        System.out.println("AÃ±adiendo todas las ITVs del archivo 'itv.txt'...");
        //AÃ±adir a todos los vehiculos las itv de "itv.txt".
        try (Scanner sc = new Scanner(new File("itv.txt"))){
            while(sc.hasNextLine()){
                Scanner lineScanner = new Scanner(sc.nextLine());
                lineScanner.useDelimiter(";");
                while (lineScanner.hasNext()){
                    String matricula = lineScanner.next();
                    int year = lineScanner.nextInt();
                    System.out.println("Añado el año...");
                    Coche coche = new Coche(matricula);
                    coche.addITV(year);
                }
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }

        System.out.println("ITVs aÃ±adidas correctamente");
        System.out.println("Mostramos todos los vehiculos con sus respectivas ITVs");
        //Mostrar todos los vehiculos con sus itv.
        for (Coche coche : Coche.ListaCoche()){
            System.out.println(coche.toString());
        }
    }
}

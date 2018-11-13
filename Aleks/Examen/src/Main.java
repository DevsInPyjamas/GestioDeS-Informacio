import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // TODO Auto-generated method stub
        List<String> nombreCoches = new ArrayList<>();
        try(Scanner sc = new Scanner(new File("itv.txt"))){
            while(sc.hasNextLine()) {
                try(Scanner sc2 = new Scanner(sc.nextLine())) {
                    sc2.useDelimiter("[;]+");
                    while(sc2.hasNext()) {
                        String nombre = sc2.next();
                        if(!nombreCoches.contains(nombre)) {
                            nombreCoches.add(nombre);
                        }
                        Coche c = new Coche(nombre);
                        c.addITV(sc2.nextInt());
                    }
                }
            }
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        for(String matricula : nombreCoches) {
            Coche c = new Coche(matricula);
            System.out.println(c.getMatricula() + "    " + c.getMarca() + "    " + c.getModelo());
            for(Integer year : c.getPaso_itv()) {
                System.out.println("       " + year);
            }
        }
    }

}

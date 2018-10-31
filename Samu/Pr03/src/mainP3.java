import java.util.*;

public class mainP3 {

    public static void main(String[] args) {
        String[] pantallas = {"LOGIN", "USUARIOS", "PACIENTES", "CITAS"};

        System.out.println("Lista de usuarios");
        System.out.println("=================");
        for (Usuario u : Usuario.ListaUsuarios()) {
            System.out.println(u);
            for (String p : pantallas) {
                System.out.println("\tPuede acceder a    "
                        + p + " -->" + u.AccesoPantalla(p));
                System.out.println("\tPuede modificar en "
                        + p + " -->" + u.ModificaPantalla(p));
            }
        }
    }
}

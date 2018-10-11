import User.*;

public class Main {
    public static void main(String[] args) {
        Rol r1 = new Rol("ADMIN", "ADMINISTRADOR", true);

        r1.addPermiso(new Permiso("PANTALLA1", true, true));
        r1.addPermiso(new Permiso("PANTALLA2", true, true));
        r1.addPermiso(new Permiso("PANTALLA3", true, true));

        Rol r2 = new Rol("USER", "USUARIO", false);

        r2.addPermiso(new Permiso("PANTALLA1", true, false));
        r2.addPermiso(new Permiso("PANTALLA2", true, true));
        r2.addPermiso(new Permiso("PANTALLA3", true, true));

        Rol r3 = new Rol("INVITADO", "INVITADO", false);

        r3.addPermiso(new Permiso("PANTALLA1", false, false));
        r3.addPermiso(new Permiso("PANTALLA2", true, false));
        r3.addPermiso(new Permiso("PANTALLA3", true, false));

        Usuario u1 = new Usuario("U1", "U1", r1);
        Usuario u2 = new Usuario("U2", "U2", r2);
        Usuario u3 = new Usuario("U3", "U3", r3);

        /**
         * Usuario 1 accede las 3 pantallas
         */
        System.out.println("U1 puede acceder a Pantalla 1: " + u1.AccesoAPantalla("PANTALLA1"));
        System.out.println("U1 puede acceder a Pantalla 2: " + u1.AccesoAPantalla("PANTALLA2"));
        System.out.println("U1 puede acceder a Pantalla 3: " + u1.AccesoAPantalla("PANTALLA3"));

        /**
         * Usuario 2 accede las 3 pantallas
         */
        System.out.println("U2 puede acceder a Pantalla 1: " + u2.AccesoAPantalla("PANTALLA1"));
        System.out.println("U2 puede acceder a Pantalla 2: " + u2.AccesoAPantalla("PANTALLA2"));
        System.out.println("U2 puede acceder a Pantalla 3: " + u2.AccesoAPantalla("PANTALLA3"));

        /**
         * Usuario 3 accede las 3 pantallas
         */
        System.out.println("U3 puede acceder a Pantalla 1: " + u3.AccesoAPantalla("PANTALLA1"));
        System.out.println("U3 puede acceder a Pantalla 2: " + u3.AccesoAPantalla("PANTALLA2"));
        System.out.println("U3 puede acceder a Pantalla 3: " + u3.AccesoAPantalla("PANTALLA3"));

        /**
         * Usuario 1 modifica las 3 pantallas
         */
        System.out.println("U1 puede modificar la Pantalla 1: " + u1.ModificarPantalla("PANTALLA1"));
        System.out.println("U1 puede modificar la Pantalla 2: " + u1.ModificarPantalla("PANTALLA2"));
        System.out.println("U1 puede modificar la Pantalla 3: " + u1.ModificarPantalla("PANTALLA3"));

        /**
         * Usuario 2 modifica las 3 pantallas
         */
        System.out.println("U2 puede modificar la Pantalla 1: " + u2.ModificarPantalla("PANTALLA1"));
        System.out.println("U2 puede modificar la Pantalla 2: " + u2.ModificarPantalla("PANTALLA2"));
        System.out.println("U2 puede modificar la Pantalla 3: " + u2.ModificarPantalla("PANTALLA3"));


        /**
         * Usuario 3 modifica las 3 pantallas
         */
        System.out.println("U3 puede modificar la Pantalla 1: " + u3.ModificarPantalla("PANTALLA1"));
        System.out.println("U3 puede modificar la Pantalla 2: " + u3.ModificarPantalla("PANTALLA2"));
        System.out.println("U3 puede modificar la Pantalla 3: " + u3.ModificarPantalla("PANTALLA3"));

        System.out.println("U1 trata de modificar el rol de U2");
        u1.ModiRol(u2, r3);
        System.out.println("U1 trata de modificar el rol de U3");
        u1.ModiRol(u3, r2);

        System.out.println("U2 trata de modificar el rol de U1");
        u2.ModiRol(u1, r3);
        System.out.println("U2 trata de modificar el rol de U3");
        u2.ModiRol(u3, r2);

        System.out.println("U3 trata de modificar el rol de U1");
        u3.ModiRol(u1, r3);
        System.out.println("U3 trata de modificar el rol de U2");
        u3.ModiRol(u2, r3);
    }
}

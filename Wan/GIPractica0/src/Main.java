public class Main
{
    public static void main(String[] args)
    {
        Rol r1 = new Rol("ADMIN", "ADMINISTRADOR", true);
        r1.AddPermiso(new Permiso("PANTALLA1", true, true));
        r1.AddPermiso(new Permiso("PANTALLA2", true, true));
        r1.AddPermiso(new Permiso("PANTALLA3", true, true));

        Rol r2 = new Rol("USER", "USUARIO", false);
        r2.AddPermiso(new Permiso("PANTALLA1", true, false));
        r2.AddPermiso(new Permiso("PANTALLA2", true, true));
        r2.AddPermiso(new Permiso("PANTALLA3", true, true));

        Rol r3 = new Rol("INVITADO", "INVITADO", false);
        r3.AddPermiso(new Permiso("PANTALLA1", false, false));
        r3.AddPermiso(new Permiso("PANTALLA2", true, false));
        r3.AddPermiso(new Permiso("PANTALLA3", true, false));

        Usuario u1 = new Usuario("U1", "U1", r1);
        Usuario u2 = new Usuario("U2", "U2", r2);
        Usuario u3 = new Usuario("U3", "U3", r3);

        System.out.println("U1 puede acceder a PANTALLA 1: " + u1.AccesoPantalla("PANTALLA1") + "\n");
        System.out.println("U1 puede modificar a PANTALLA 1: " + u1.ModificaPantalla("PANTALLA1") + "\n");
        System.out.println("U1 puede acceder a PANTALLA 2: " + u1.AccesoPantalla("PANTALLA2") + "\n");
        System.out.println("U1 puede modificar a PANTALLA 2: " + u1.ModificaPantalla("PANTALLA2") + "\n");
        System.out.println("U1 puede acceder a PANTALLA 3: " + u1.AccesoPantalla("PANTALLA3") + "\n");
        System.out.println("U1 puede modificar a PANTALLA 3: " + u1.ModificaPantalla("PANTALLA3") + "\n");

        System.out.println("U1 trata de modificar el rol de U2");
        u1.ModiRol(u2, r1);
        System.out.println("U1 trata de modificar el rol de U2");
        u1.ModiRol(u2, r3);
        System.out.println("U1 trata de modificar el rol de U2");
        u1.ModiRol(u2, r2);

        System.out.println("U2 puede acceder a PANTALLA 1: " + u2.AccesoPantalla("PANTALLA1") + "\n");
        System.out.println("U2 puede modificar a PANTALLA 1: " + u2.ModificaPantalla("PANTALLA1") + "\n");
        System.out.println("U2 puede acceder a PANTALLA 2: " + u2.AccesoPantalla("PANTALLA2") + "\n");
        System.out.println("U2 puede modificar a PANTALLA 2: " + u2.ModificaPantalla("PANTALLA2") + "\n");
        System.out.println("U2 puede acceder a PANTALLA 3: " + u2.AccesoPantalla("PANTALLA3") + "\n");
        System.out.println("U2 puede modificar a PANTALLA 3: " + u2.ModificaPantalla("PANTALLA3") + "\n");

        System.out.println("U1 trata de modificar el rol de U1");
        u2.ModiRol(u1, r3);
        System.out.println("U1 trata de modificar el rol de U2");
        u2.ModiRol(u2, r3);
        System.out.println("U1 trata de modificar el rol de U3");
        u2.ModiRol(u3, r2);

        System.out.println("U3 puede acceder a PANTALLA 1: " + u3.AccesoPantalla("PANTALLA1") + "\n");
        System.out.println("U3 puede modificar a PANTALLA 1: " + u3.ModificaPantalla("PANTALLA1") + "\n");
        System.out.println("U3 puede acceder a PANTALLA 2: " + u3.AccesoPantalla("PANTALLA2") + "\n");
        System.out.println("U3 puede modificar a PANTALLA 2: " + u3.ModificaPantalla("PANTALLA2") + "\n");
        System.out.println("U3 puede acceder a PANTALLA 3: " + u3.AccesoPantalla("PANTALLA3") + "\n");
        System.out.println("U3 puede modificar a PANTALLA 3: " + u3.ModificaPantalla("PANTALLA3") + "\n");

        System.out.println("U1 trata de modificar el rol de U1");
        u3.ModiRol(u1, r3);
        System.out.println("U1 trata de modificar el rol de U2");
        u3.ModiRol(u2, r3);
        System.out.println("U1 trata de modificar el rol de U3");
        u3.ModiRol(u3, r2);
    }
}

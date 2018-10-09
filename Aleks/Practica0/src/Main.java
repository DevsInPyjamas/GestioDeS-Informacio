import p0.Permission;
import p0.Role;
import p0.User;

public class Main {
    public static void main(String[] args) {
        Role r1 = new Role(true, "ADMIN", "ADMINISTRADOR");
        Role r2 = new Role(false, "USER", "USUARIO");
        r1.addPermission(new Permission("PANTALLA1", true, true));
        r1.addPermission(new Permission("PANTALLA2", true, true));
        r1.addPermission(new Permission("PANTALLA3", true, true));
        r2.addPermission(new Permission("PANTALLA1", true, false));
        r2.addPermission(new Permission("PANTALLA2", true, true));
        r2.addPermission(new Permission("PANTALLA3", true, true));
        Role r3 = new Role(true, "INVITADO", "INVITADO");
        r3.addPermission(new Permission("PANTALLA1", false, false));
        r3.addPermission(new Permission("PANTALLA2", true, false));
        r3.addPermission(new Permission("PANTALLA3", true, false));


        User u1 = new User(r1, "u1", "u1");
        User u2 = new User(r2, "u2", "u2");
        User u3 = new User(r2, "u3", "u3");
    }
}

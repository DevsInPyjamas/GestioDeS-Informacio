import rolebased.Permission;
import rolebased.UserRole;
import rolebased.User;

public class Main {
    public static void main(String[] args) {
        UserRole r1 = new UserRole("ADMINISTRADOR", "ADMIN", true);
        UserRole r2 = new UserRole("USUARIO", "USER", false);
        r1.addPermission(new Permission("PANTALLA1", true, true));
        r1.addPermission(new Permission("PANTALLA2", true, true));
        r1.addPermission(new Permission("PANTALLA3", true, true));
        r2.addPermission(new Permission("PANTALLA1", true, false));
        r2.addPermission(new Permission("PANTALLA2", true, true));
        r2.addPermission(new Permission("PANTALLA3", true, true));
        UserRole r3 = new UserRole("INVITADO", "INVITADO", false);
        r3.addPermission(new Permission("PANTALLA1", false, false));
        r3.addPermission(new Permission("PANTALLA2", true, false));
        r3.addPermission(new Permission("PANTALLA3", true, false));

    }
}

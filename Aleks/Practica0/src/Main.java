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
        r2.addPermission(new Permission("PANTALLA1", false, true));
        r2.addPermission(new Permission("PANTALLA2", true, true));
        r2.addPermission(new Permission("PANTALLA3", true, true));
        Role r3 = new Role(false, "INVITADO", "INVITADO");
        r3.addPermission(new Permission("PANTALLA1", false, false));
        r3.addPermission(new Permission("PANTALLA2", false, false));
        r3.addPermission(new Permission("PANTALLA3", false, false));


        User u1 = new User(r1, "u1", "u1");
        User u2 = new User(r2, "u2", "u2");
        User u3 = new User(r3, "u3", "u3");

        if (u1.hasAccessToScreen("PANTALLA1")) System.out.println("U1 access to Pantalla 1");
        if (u1.isAllowedToModifyScreen("PANTALLA1")) System.out.println("U1 is allowed to modify Pantalla 1");
        else System.out.println("U1 is not allowed to modify Pantalla 1");
        if (u1.hasAccessToScreen("PANTALLA2")) System.out.println("u1 access to pantalla 2");
        else System.out.println("u1 can't access to pantalla 2");
        if (u1.isAllowedToModifyScreen("PANTALLA2")) System.out.println("U1 is allowed to modify Pantalla 2");
        else System.out.println("U1 is not allowed to modify Pantalla 2");
        if (u1.hasAccessToScreen("PANTALLA3")) System.out.println("u1 access to pantalla 3");
        else System.out.println("u1 can't access to pantalla 3");
        if (u1.isAllowedToModifyScreen("PANTALLA3")) System.out.println("U1 is allowed to modify Pantalla 3");
        else System.out.println("U1 is not allowed to modify Pantalla 3");
        if (u2.hasAccessToScreen("PANTALLA1")) System.out.println("u2 access to pantalla 1");
        if (u2.isAllowedToModifyScreen("PANTALLA1")) System.out.println("U2 is allowed to modify Pantalla 1");
        else System.out.println("U2 is not allowed to modify Pantalla 1");
        if (u2.hasAccessToScreen("PANTALLA2")) System.out.println("u2 access to pantalla 2");
        else System.out.println("u2 can't access to pantalla 2");
        if (u2.isAllowedToModifyScreen("PANTALLA2")) System.out.println("U2 is allowed to modify Pantalla 2");
        else System.out.println("U2 is not allowed to modify Pantalla 2");
        if (u2.hasAccessToScreen("PANTALLA3")) System.out.println("u2 access to pantalla 3");
        else System.out.println("u2 can't access to pantalla 3");
        if (u2.isAllowedToModifyScreen("PANTALLA3")) System.out.println("U2 is allowed to modify Pantalla 3");
        else System.out.println("U2 is not allowed to modify Pantalla 3");
        if (u3.hasAccessToScreen("PANTALLA1")) System.out.println("u3 access to pantalla 1");
        else System.out.println("u3 can't access to pantalla 1");
        if (u3.isAllowedToModifyScreen("PANTALLA1")) System.out.println("U3 is allowed to modify Pantalla 1");
        else System.out.println("U3 is not allowed to modify Pantalla 1");
        if (u3.hasAccessToScreen("PANTALLA2")) System.out.println("u3 access to pantalla 2");
        else System.out.println("u3 can't access to pantalla 2");
        if (u3.isAllowedToModifyScreen("PANTALLA2")) System.out.println("U3 is allowed to modify Pantalla 2");
        else System.out.println("U3 is not allowed to modify Pantalla 2");
        if (u3.hasAccessToScreen("PANTALLA3")) System.out.println("u3 access to pantalla 3");
        else System.out.println("u3 can't access to pantalla 3");
        if (u3.isAllowedToModifyScreen("PANTALLA3")) System.out.println("U3 is allowed to modify Pantalla 3");
        else System.out.println("U3 is not allowed to modify Pantalla 3");
        try {
            u1.modifyUserRol(u2, r1);
            System.out.println("U1 changed u2's role from r2 to r1");
        } catch (Exception e) {
            System.err.println("u1 is not allowed to change roles");
        }
        try {
            u2.modifyUserRol(u3, r2);
            System.out.println("U2 changed u3's role from r3 to r2");
        } catch (Exception e) {
            System.err.println("u2 is not allowed to change roles");
        }
        try {
            u3.modifyUserRol(u2, r1);
            System.out.println("U3 changed u2's role from r2 to r1");
        } catch (Exception e) {
            System.err.println("u3 is not allowed to change roles");
        }
    }
}

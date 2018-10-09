package p0;

import java.util.ArrayList;
import java.util.List;

public class Role {
    private List<Permission> permissions;
    private boolean admin;
    private String rolName;
    private String rolDes;

    public Role(boolean admin, String rolName, String rolDes) {
        this.admin = admin;
        this.rolName = rolName;
        this.rolDes = rolDes;
        this.permissions = new ArrayList<>();
    }

    public boolean access(String screen) {
        int i = getScreenPosition(screen);
        return (i < permissions.size()) && permissions.get(i).getAccess();
    }

    private int getScreenPosition(String screen) {
        int i = 0;
        while(screen.equals(permissions.get(i).getScreen()) && i < permissions.size()) {
            i++;
        }
        return i;
    }

    public void addPermission(Permission newPermission) {
        if (!permissions.contains(newPermission)) {
            permissions.add(newPermission);
        }
    }

    public boolean modification(String screen) {
        int i = getScreenPosition(screen);
        return (i < permissions.size()) && permissions.get(i).getModification();
    }

    public void setAdmin(boolean admin) throws Exception {
        throw new Exception("You are not allowed to do this action.");
    }

    public void setRolName(String rolName) {
        this.rolName = rolName;
    }

    public void setRolDes(String rolDes) {
        this.rolDes = rolDes;
    }

    public boolean isAdmin() {
        return admin;
    }

    public String getRolName() {
        return rolName;
    }

    public String getRolDes() {
        return rolDes;
    }
}

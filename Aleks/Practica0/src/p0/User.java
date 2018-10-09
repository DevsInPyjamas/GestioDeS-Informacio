package p0;

public class User {
    private Role role;
    private String name;
    private String password;


    public User(Role role, String name, String password) {
        this.role = role;
        this.name = name;
        this.password = password;
    }

    public void modifyUserRol(User userToModifyRol, Role newUserRole) throws Exception {
        if (this.role.isAdmin()) {
            userToModifyRol.role = newUserRole;
        } else {
            throw new Exception("You are not allowed to do this action.");
        }
    }

    public boolean hasAccessToScreen(String screen) {
        return this.role.access(screen);
    }

    public boolean isAllowedToModifyScreen(String screen) {
        return this.role.modification(screen);
    }

    public void setRole(Role role) throws Exception {
        throw new Exception("You are not allowed to do this action.");
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public Role getRole() {
        return role;
    }

    public String getName() {
        return name;
    }

    public String getPassword() {
        return password;
    }
}

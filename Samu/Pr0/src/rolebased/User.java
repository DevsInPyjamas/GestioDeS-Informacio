package rolebased;

public class User {

    //Attributes
    private String name;
    private String password;

    private UserRole myRole;

    //Constructor
    public User(String name, String password, UserRole myRole) {
        this.name = name;
        this.password = password;
        this.myRole = myRole;
    }

    // Getter and Setters
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public UserRole getMyRole() {
        return myRole;
    }

    //Methods
    public void modifyRole(User user, UserRole role) throws Exception {
        if(this.myRole.isAdmin()){
            user.myRole = role;
        } else {
            throw new Exception("You are not allowed to change the role of user " + user.getName());
        }
    }

    public boolean screenAccess(String screen) {
        return myRole.canAccess(screen);
    }

    public boolean modifyScreen(String screen){
        return myRole.canModify(screen);
    }
}

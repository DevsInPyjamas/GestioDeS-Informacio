package rolebased;

import java.util.ArrayList;
import java.util.List;

public class UserRole {

    //Attributes
    private String roleName;
    private String roleDescription;
    private boolean isAdmin;

    private List<Permission> permissions = new ArrayList<>();

    //Constructor
    public UserRole(String roleName, String roleDescription, boolean isAdmin) {
        this.isAdmin = isAdmin;
        this.roleDescription = roleDescription;
        this.roleName = roleName;
    }

    public String getRoleName() {
        return roleName;
    }

    public void setRoleName(String roleName) {
        this.roleName = roleName;
    }

    public String getRoleDescription() {
        return roleDescription;
    }

    public void setRoleDescription(String roleDescription) {
        this.roleDescription = roleDescription;
    }

    public boolean isAdmin() {
        return isAdmin;
    }

    //Methods
    public boolean canAccess(String screen){
        Permission perm = getPermission(screen);
        return perm != null && perm.isCanAccess();
    }

    public boolean canModify(String screen){
        Permission perm = getPermission(screen);
        return perm != null && perm.isCanModify();
    }

    public void AddPermission(Permission permission){
        if(!permissions.contains(permission)){
            permissions.add(permission);
        }
    }

    private Permission getPermission(String screenName){
        int i = 0;
        while(i<permissions.size() && screenName.equals(permissions.get(i).getScreenName())){
            i++;
        }
        return i<permissions.size() ? permissions.get(i) : null;
    }

}

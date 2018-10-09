package rolebased;

public class Permission {
    //Attributes
    private String screenName;
    private boolean canAccess;
    private boolean canModify;

    //Constructor
    public Permission(String screenName, boolean canAccess, boolean canModify) {
        this.screenName = screenName;
        this.canAccess = canAccess;
        this.canModify = canModify;
    }

    //Getters and Setters

    public String getScreenName() {
        return screenName;
    }

    public void setScreenName(String screenName) {
        this.screenName = screenName;
    }

    public boolean isCanAccess() {
        return canAccess;
    }

    public void setCanAccess(boolean canAccess) {
        this.canAccess = canAccess;
    }

    public boolean isCanModify() {
        return canModify;
    }

    public void setCanModify(boolean canModify) {
        this.canModify = canModify;
    }
}

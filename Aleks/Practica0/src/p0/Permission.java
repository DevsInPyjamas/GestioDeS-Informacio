package p0;

public class Permission {
    private boolean access;
    private boolean modification;
    private String screen;

    public Permission(String screen, boolean modification, boolean access) {
        this.access = access;
        this.modification = modification;
        this.screen = screen;
    }

    public void setAccess(boolean access) {
        this.access = access;
    }

    public void setModification(boolean modification) {
        this.modification = modification;
    }

    public void setScreen(String screen) {
        this.screen = screen;
    }

    public boolean getAccess() {
        return access;
    }

    public boolean getModification() {
        return modification;
    }

    public String getScreen() {
        return screen;
    }
}

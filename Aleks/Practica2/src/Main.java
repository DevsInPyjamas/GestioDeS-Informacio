import p02.DataBaseInserter;

public class Main {
    public static void main(String[] args) {
        DataBaseInserter db = new DataBaseInserter("alkesst",
                "1234", "localhost", 1433, "GI1819", ";");
        db.connectToDB();
        db.resetTables();
        db.addToDBDataFromFile("pais.txt");
        db.addToDBDataFromFile("pacientes.txt");
        db.disconnectFromDB();
    }
}

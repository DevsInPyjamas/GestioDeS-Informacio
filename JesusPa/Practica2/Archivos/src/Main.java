import Pr2.*;

public class Main {
    public static void main(String[] args) {
        DBInserter dbInserter = new DBInserter("jesuspa", "1234", "localhost",
                1433, "GI1819", ";");
        dbInserter.connectToDB();
        dbInserter.resetTables();
        dbInserter.addToDBDataFromFile("pais.txt");
        dbInserter.addToDBDataFromFile("pacientes.txt");
        dbInserter.disconnectToDB();
    }
}

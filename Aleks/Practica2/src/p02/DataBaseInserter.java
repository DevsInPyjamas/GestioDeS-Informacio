package p02;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;

import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.List;

public class DataBaseInserter {
    SQLServerDataSource dataSource;
    Connection dbConnection;
    Statement statement;
    CSVParser csvParser;

    public DataBaseInserter(String user, String password, String host, int port, String dataBaseName, String delimiter) {
        dataSource = new SQLServerDataSource();
        dataSource.setUser(user);
        dataSource.setPassword(password);
        dataSource.setServerName(host);
        dataSource.setPortNumber(port);
        dataSource.setDatabaseName(dataBaseName);
        this.csvParser = new CSVParser(delimiter);
    }

    public void connectToDB() {
        try {
            dbConnection = dataSource.getConnection();
            System.out.println("Connected to the DataBase...");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void disconnectFromDB() {
        try {
            dbConnection.close();
            System.out.println("Disconnected from database...");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void addToDBDataFromFile(String fileName) {
        try {
            statement = dbConnection.createStatement();
            List<List<String>> allFile = this.csvParser.fileReader(fileName);
            StringBuilder sql = new StringBuilder();
            for (List<String> listOfColumns : allFile) {
                if (fileName.equalsIgnoreCase("pacientes.txt")) {
                    sql.setLength(0);
                    sql.append("INSERT INTO tPatient VALUES (");
                } else if(fileName.equalsIgnoreCase("pais.txt")) {
                    sql.setLength(0);
                    sql.append("INSERT INTO tCountry VALUES (");
                }
                for (String element : listOfColumns) {
                    sql.append("'").append(element).append("', ");
                }
                sql.replace(sql.length() - 2, sql.length() - 1, ");");
                System.out.println(sql.toString());
                statement.execute(sql.toString());
            }
            System.out.println("Everything was added to the database...");
            statement.close();

        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void resetTables() {
        try {
            statement = dbConnection.createStatement();
            statement.execute("DELETE FROM tCountry");
            statement.execute("DELETE FROM tPatient");
            statement.close();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}

package Pr2;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;
import com.microsoft.sqlserver.jdbc.SQLServerException;

import java.sql.Connection;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.List;

public class DBInserter {
    private SQLServerDataSource dataSource;
    private Connection dbConnection;
    private Statement statement;
    private Parser parser;

    public DBInserter(String user, String password, String host, int port, String dataBaseName, String delimiter) {
        dataSource = new SQLServerDataSource();
        dataSource.setUser(user);
        dataSource.setPassword(password);
        dataSource.setServerName(host);
        dataSource.setPortNumber(port);
        dataSource.setDatabaseName(dataBaseName);
        this.parser = new Parser(delimiter);
    }

    public void connectToDB(){
        try {
            dbConnection = dataSource.getConnection();
            System.out.println("Connected...");
        } catch (SQLServerException e) {
            e.printStackTrace();
        }
    }

    public void disconnectToDB(){
        try {
            dbConnection.close();
            System.out.println("Disconnected...");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void addToDBDataFromFile(String fileName) {
        try {
            statement = dbConnection.createStatement();
            List<List<String>> attributes = parser.fileReader(fileName);
            StringBuilder stringBuilder = new StringBuilder();
            for (List<String> columns : attributes) {
                if(fileName.equalsIgnoreCase("pacientes.txt")) {
                    stringBuilder.setLength(0);
                    stringBuilder.append("INSERT INTO tPaciente VALUES(");
                } else if (fileName.equalsIgnoreCase("pais.txt")){
                    stringBuilder.setLength(0);
                    stringBuilder.append("INSERT INTO tPais VALUES(");
                }

                for (String element : columns) {
                    stringBuilder.append("'").append(element).append("', ");
                }

                stringBuilder.replace(stringBuilder.length() - 2, stringBuilder.length() - 1, ");");
                System.out.println(stringBuilder.toString());
                statement.execute(stringBuilder.toString());
            }
            System.out.println("Everything added to database...");
            statement.close();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    public void resetTables(){
        try {
            statement = dbConnection.createStatement();
            statement.execute("DELETE FROM tPais");
            statement.execute("DELETE FROM tPaciente");
            statement.close();
            System.out.println("Tables reset correctly...");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

}

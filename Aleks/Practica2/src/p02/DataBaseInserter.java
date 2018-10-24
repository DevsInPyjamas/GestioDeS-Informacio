package p02;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;

import java.sql.Connection;
import java.sql.Statement;

public class DataBaseInserter {
    SQLServerDataSource dataSource;
    Connection dbConnection;
    Statement statement;

    public DataBaseInserter(String user, String password, String host, int port, String dataBaseName) {
        dataSource = new SQLServerDataSource();
        dataSource.setUser(user);
        dataSource.setPassword(password);
        dataSource.setServerName(host);
        dataSource.setPortNumber(port);
        dataSource.setDatabaseName(dataBaseName);
    }


}

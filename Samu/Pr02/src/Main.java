import java.io.File;
import java.io.FileNotFoundException;
import java.nio.file.Path;
import java.sql.*;
import java.util.Scanner;

import com.microsoft.sqlserver.jdbc.*;

public class Main {

    public static void main(String[] args) {
        try {
            SQLServerDataSource dataSource = new SQLServerDataSource();
            dataSource.setIntegratedSecurity(true);
            dataSource.setServerName("localhost");
            dataSource.setDatabaseName("GI1819");
            dataSource.setPortNumber(1433);
            Connection con = dataSource.getConnection();
            // Commented because we just want to read the files and insert the elemnt once
            File patientsFile = new File("./pacientes.txt");
            File countryFile = new File("./pais.txt");
            insertCountries(con, countryFile);
            insertPatients(con, patientsFile);

            Statement stmnt = con.createStatement();
            ResultSet set = stmnt.executeQuery("SELECT * FROM tCountry WHERE tCountry.Description LIKE '%E%';");
            while(set.next()){
                System.out.println(set.getString("Description"));
            }

            con.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static void insertCountries(Connection con, File countryFile) {
        try {
            Scanner sc = new Scanner(countryFile);
            Statement statement = con.createStatement();
            while (sc.hasNext()) {
                String[] data = sc.nextLine().split(";");
                statement.executeUpdate(String.format("INSERT INTO tCountry (Code, Description) VALUES ('%s1', '%s2')",
                        data));
            }
            con.commit();
            statement.close();
            sc.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static void insertPatients(Connection con, File patientsFile) {
        try {
            Scanner sc = new Scanner(patientsFile);
            Statement statement = con.createStatement();
            while (sc.hasNext()) {
                String[] data = sc.nextLine().split(";");
                statement.executeUpdate(String.format("INSERT INTO tPatient (NumSS, DNI_NIE, Name, Surname, Sex, Birthdate, " +
                        "Address, City, Province, Zipcode, Country, Phone, email) " +
                        "VALUES (%s1, %s2, '%s3', '%s4', '%s5', '%s6', '%s7', '%s8', '%s9', %s10, '%s11', %s12, '%s13')", data));
            }
            statement.close();
            sc.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}

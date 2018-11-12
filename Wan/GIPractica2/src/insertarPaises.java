import java.io.BufferedReader;
import java.io.FileReader;
import java.sql.Connection;
import java.sql.Statement;

import com.microsoft.sqlserver.jdbc.SQLServerDataSource;

public class insertarPaises 
{
	public static void main(String[] args) 
	{
		System.out.println("Se va a proceder a insertar la informacion en la base de datos.");
		
		try
		{
			SQLServerDataSource ds = new SQLServerDataSource();
			ds.setIntegratedSecurity(true);
			ds.setServerName("localhost");
			ds.setPortNumber(1433); 
			ds.setDatabaseName("GI1819");
			
			Connection con = ds.getConnection();
			Statement stmt = con.createStatement();
			
			@SuppressWarnings("resource")
			BufferedReader bf = new BufferedReader(new FileReader("pais.txt"));
			String linea;
			
			while((linea = bf.readLine()) != null)
			{
				String[] elem = linea.split(";");
				stmt.executeUpdate("INSERT INTO tPais VALUES ('" + elem[0] + "','" + elem[1] + "');");
			}
			
			System.out.println("Se ha insertado correctamente.");
			
			stmt.close();
			con.close();
			
		}
		catch (Exception ex)
		{
			System.out.println(ex.getMessage());
		}
	}
}

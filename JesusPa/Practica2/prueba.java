import java.sql.*;
import com.microsoft.sqlserver.jdbc.*;

public class prueba {

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		System.out.println("Esta es una Prueba de Conectividad con SQL Server");
		System.out.println("BD demo");
		System.out.println("Tabla Prueba");
		
		try
		{
			SQLServerDataSource ds = new SQLServerDataSource();
			ds.setIntegratedSecurity(true);
			ds.setServerName("localhost");
			ds.setPortNumber(1433); 
			ds.setDatabaseName("demo");
			Connection con = ds.getConnection();
			
			Statement stmt = con.createStatement();
			
			stmt.executeUpdate("INSERT INTO Prueba VALUES(1,'Prueba 1');");
						
			ResultSet res = stmt.executeQuery("SELECT * FROM Prueba;" );
			
			System.out.println("ID\tTexto");
			while(res.next())
			{
				int id = res.getInt("ID");
				String nombre = res.getString("texto");
				
				System.out.println(id + "\t" + nombre);
			}
			
			stmt.executeUpdate("DELETE FROM Prueba WHERE ID=1;");
			
			res.close();
			stmt.close();
			con.close();
			
		}
		catch (Exception ex)
		{
			System.out.println(ex.getMessage());
		}
	}

}

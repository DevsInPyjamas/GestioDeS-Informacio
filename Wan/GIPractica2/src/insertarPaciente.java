import java.io.*;
import java.sql.*;
import com.microsoft.sqlserver.jdbc.*;


public class insertarPaciente 
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
			BufferedReader bf = new BufferedReader(new FileReader("pacientes.txt"));
			String linea;
			
			while((linea = bf.readLine()) != null)
			{
				Object[] elem = linea.split(";");
				stmt.executeUpdate("INSERT INTO tPaciente VALUES ('" + elem[0] + "','" + elem[1] + "','" + elem[2] + "','" + elem[3] + "','" + elem[4] + "','" + elem[5] + "','" + elem[6] + "','" + elem[7] + "','" + elem[8] + "','" + elem[9] + "','" + elem[10] + "','" + elem[11] + "','" + elem[12] + "');");
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

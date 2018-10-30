package p3;

import java.sql.*;
import com.microsoft.sqlserver.jdbc.*;
import java.util.*;

public class BD {
    private SQLServerDataSource ds;
    private Connection con ;

    public BD(String server, String databaseName) {
        try {
            ds = new SQLServerDataSource();
            ds.setUser("alkesst");
            ds.setPassword("1234");
            ds.setServerName(server);
            ds.setPortNumber(1433);
            ds.setDatabaseName(databaseName);
            con = ds.getConnection();
        }
        catch (SQLException ex)
        {
            throw new Error("Error al Conectar con la base de datos." + ex.getMessage());
        }
    }

    protected void finalize () {
        try
        {
            if (con!=null)  con.close();
        }
        catch (SQLException ex)
        {
            throw new Error("p3.Error al Cerrar la Conexión." + ex.getMessage());
        }
    }

    public Object SelectEscalar(String sel) {
        ResultSet rset;
        Object res;
        try
        {
            Statement stmt = con.createStatement();
            rset = stmt.executeQuery(sel);
            rset.next();
            res = rset.getObject(1);
            rset.close();
            stmt.close();
        }
        catch (SQLException ex)
        {
            throw new Error("p3.Error en el SELECT: " + sel + ". " + ex.getMessage());
        }

        return res;
    }

    public List<Object[]> Select(String sel)
    {
        ResultSet resultSet;
        List<Object[]> lista = new ArrayList<Object[]>();
        try
        {
            Statement statement = con.createStatement();
            resultSet = statement.executeQuery(sel);
            ResultSetMetaData meta = resultSet.getMetaData();
            int numCol = meta.getColumnCount();
            while (resultSet.next())
            {
                Object[] tupla = new Object[numCol];
                for(int i=0; i<numCol;++i)
                {
                    tupla[i] = resultSet.getObject(i+1);
                }
                lista.add(tupla);
            }
            resultSet.close();
            statement.close();
        }
        catch (SQLException ex)
        {
            throw new Error("p3.Error en el SELECT: " + sel+ ". " + ex.getMessage());
        }

        return lista;
    }

    public void Insert(String ins) {
        try
        {
            Statement stmt = con.createStatement();
            stmt.execute(ins);
            stmt.close();
        }
        catch (SQLException ex)
        {
            throw new Error("p3.Error en el INSERT: " + ins+ ". " + ex.getMessage());
        }
    }

    public void Delete(String del)
    {
        try
        {
            Statement stmt = con.createStatement();
            stmt.execute(del);
            stmt.close();
        }
        catch (SQLException ex)
        {
            throw new Error("p3.Error en el DELETE: " + del+ ". " + ex.getMessage());
        }
    }

    public void Update(String up)
    {
        try
        {
            Statement stmt = con.createStatement();
            stmt.execute(up);
            stmt.close();
        }
        catch (SQLException ex)
        {
            throw new Error("p3.Error en el UPDATE: " + up+ ". " + ex.getMessage());
        }
    }

}

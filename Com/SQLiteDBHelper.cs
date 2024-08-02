using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

public class SQLiteDBHelper
{
    private string connectionString = string.Empty;

    private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());

    public SQLiteDBHelper(string dbPath)
    {
        connectionString = "Data Source=" + dbPath;
    }

    public void CreateDB(string dbPath)
    {
        if (!File.Exists(dbPath))
        {
            SQLiteConnection.CreateFile(dbPath);
        }
    }

    public void CreateTable(string dbPath, string strSqlite)
    {
        SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(dbPath);
        sQLiteDBHelper.ExecuteNonQuery(strSqlite, null);
    }

    public int ExecuteNonQuery(string sql, SQLiteParameter[] parameters)
    {
        //IL_0009: Unknown result type (might be due to invalid IL or missing references)
        //IL_000f: Expected O, but got Unknown
        //IL_0020: Unknown result type (might be due to invalid IL or missing references)
        //IL_0026: Expected O, but got Unknown
        int result = 0;
        SQLiteConnection val = new SQLiteConnection(connectionString);
        try
        {
            ((DbConnection)val).Open();
            DbTransaction val2 = (DbTransaction)(object)val.BeginTransaction();
            try
            {
                SQLiteCommand val3 = new SQLiteCommand(val);
                try
                {
                    ((DbCommand)val3).CommandText = sql;
                    if (parameters != null)
                    {
                        val3.Parameters.AddRange(parameters);
                    }
                    result = ((DbCommand)val3).ExecuteNonQuery();
                }
                finally
                {
                    ((IDisposable)val3)?.Dispose();
                }
                val2.Commit();
            }
            finally
            {
                ((IDisposable)val2)?.Dispose();
            }
        }
        finally
        {
            ((IDisposable)val)?.Dispose();
        }
        return result;
    }

    public SQLiteDataReader ExecuteReader(string sql, SQLiteParameter[] parameters)
    {
        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
        //IL_000d: Expected O, but got Unknown
        //IL_000f: Unknown result type (might be due to invalid IL or missing references)
        //IL_0015: Expected O, but got Unknown
        SQLiteConnection val = new SQLiteConnection(connectionString);
        SQLiteCommand val2 = new SQLiteCommand(sql, val);
        if (parameters != null)
        {
            val2.Parameters.AddRange(parameters);
        }
        ((DbConnection)val).Open();
        return val2.ExecuteReader((CommandBehavior)32);
    }

    public DataTable ExecuteDataTable(string sql, SQLiteParameter[] parameters)
    {
        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
        //IL_000d: Expected O, but got Unknown
        //IL_0010: Unknown result type (might be due to invalid IL or missing references)
        //IL_0016: Expected O, but got Unknown
        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
        //IL_0037: Expected O, but got Unknown
        //IL_0037: Unknown result type (might be due to invalid IL or missing references)
        //IL_003d: Expected O, but got Unknown
        SQLiteConnection val = new SQLiteConnection(connectionString);
        try
        {
            SQLiteCommand val2 = new SQLiteCommand(sql, val);
            try
            {
                if (parameters != null)
                {
                    val2.Parameters.AddRange(parameters);
                }
                SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
                DataTable val4 = new DataTable();
                ((DbDataAdapter)val3).Fill(val4);
                return val4;
            }
            finally
            {
                ((IDisposable)val2)?.Dispose();
            }
        }
        finally
        {
            ((IDisposable)val)?.Dispose();
        }
    }

    public DataTable ExecuteDataTable(string sql)
    {
        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
        //IL_000d: Expected O, but got Unknown
        //IL_0010: Unknown result type (might be due to invalid IL or missing references)
        //IL_0016: Expected O, but got Unknown
        //IL_0018: Unknown result type (might be due to invalid IL or missing references)
        //IL_001e: Expected O, but got Unknown
        //IL_001e: Unknown result type (might be due to invalid IL or missing references)
        //IL_0024: Expected O, but got Unknown
        SQLiteConnection val = new SQLiteConnection(connectionString);
        try
        {
            SQLiteCommand val2 = new SQLiteCommand(sql, val);
            try
            {
                SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
                DataTable val4 = new DataTable();
                ((DbDataAdapter)val3).Fill(val4);
                return val4;
            }
            finally
            {
                ((IDisposable)val2)?.Dispose();
            }
        }
        finally
        {
            ((IDisposable)val)?.Dispose();
        }
    }

    public object ExecuteScalar(string sql, SQLiteParameter[] parameters)
    {
        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
        //IL_000d: Expected O, but got Unknown
        //IL_0010: Unknown result type (might be due to invalid IL or missing references)
        //IL_0016: Expected O, but got Unknown
        //IL_0031: Unknown result type (might be due to invalid IL or missing references)
        //IL_0037: Expected O, but got Unknown
        //IL_0037: Unknown result type (might be due to invalid IL or missing references)
        //IL_003d: Expected O, but got Unknown
        SQLiteConnection val = new SQLiteConnection(connectionString);
        try
        {
            SQLiteCommand val2 = new SQLiteCommand(sql, val);
            try
            {
                if (parameters != null)
                {
                    val2.Parameters.AddRange(parameters);
                }
                SQLiteDataAdapter val3 = new SQLiteDataAdapter(val2);
                DataTable val4 = new DataTable();
                ((DbDataAdapter)val3).Fill(val4);
                return val4;
            }
            finally
            {
                ((IDisposable)val2)?.Dispose();
            }
        }
        finally
        {
            ((IDisposable)val)?.Dispose();
        }
    }

    public DataTable GetSchema()
    {
        //IL_0007: Unknown result type (might be due to invalid IL or missing references)
        //IL_000d: Expected O, but got Unknown
        SQLiteConnection val = new SQLiteConnection(connectionString);
        try
        {
            ((DbConnection)val).Open();
            DataTable schema = ((DbConnection)val).GetSchema("TABLES");
            ((DbConnection)val).Close();
            return schema;
        }
        finally
        {
            ((IDisposable)val)?.Dispose();
        }
    }

    public static int ExecuteNonQuery(string connectionString, bool IsTrans, CommandType cmdType, string[] cmdText, ArrayList pramsList)
    {
        //IL_000b: Unknown result type (might be due to invalid IL or missing references)
        //IL_0012: Expected O, but got Unknown
        //IL_0034: Unknown result type (might be due to invalid IL or missing references)
        //IL_003a: Invalid comparison between Unknown and I4
        //IL_004d: Unknown result type (might be due to invalid IL or missing references)
        //IL_0054: Expected O, but got Unknown
        //IL_006d: Unknown result type (might be due to invalid IL or missing references)
        int num = 0;
        SQLiteParameter[] array = null;
        SQLiteTransaction val = null;
        int result = 0;
        try
        {
            SQLiteConnection val2 = new SQLiteConnection(connectionString);
            try
            {
                foreach (string cmdText2 in cmdText)
                {
                    array = (SQLiteParameter[])pramsList[num];
                    if ((int)((DbConnection)val2).State != 1)
                    {
                        ((DbConnection)val2).Open();
                    }
                    SQLiteCommand val3 = new SQLiteCommand();
                    if (num == 0)
                    {
                        val = val2.BeginTransaction();
                    }
                    PrepareCommand(val3, val2, val, cmdType, cmdText2, array);
                    result = ((DbCommand)val3).ExecuteNonQuery();
                    ((DbParameterCollection)val3.Parameters).Clear();
                    val3 = null;
                    num++;
                }
                ((DbTransaction)val).Commit();
                return result;
            }
            finally
            {
                ((IDisposable)val2)?.Dispose();
            }
        }
        catch (Exception value)
        {
            result = -1;
            ((DbTransaction)val).Rollback();
            Console.WriteLine(value);
        }
        return result;
    }

    public static int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_0008: Unknown result type (might be due to invalid IL or missing references)
        //IL_000e: Expected O, but got Unknown
        //IL_0012: Unknown result type (might be due to invalid IL or missing references)
        SQLiteCommand val = new SQLiteCommand();
        SQLiteConnection val2 = new SQLiteConnection(connectionString);
        try
        {
            PrepareCommand(val, val2, null, cmdType, cmdText, commandParameters);
            int result = ((DbCommand)val).ExecuteNonQuery();
            ((DbParameterCollection)val.Parameters).Clear();
            ((DbConnection)val2).Close();
            return result;
        }
        finally
        {
            ((IDisposable)val2)?.Dispose();
        }
    }

    public static int ExecuteNonQuery(SQLiteConnection connection, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_000a: Unknown result type (might be due to invalid IL or missing references)
        SQLiteCommand val = new SQLiteCommand();
        PrepareCommand(val, connection, null, cmdType, cmdText, commandParameters);
        int result = ((DbCommand)val).ExecuteNonQuery();
        ((DbParameterCollection)val.Parameters).Clear();
        ((DbConnection)connection).Close();
        return result;
    }

    public static int ExecuteNonQuery(SQLiteTransaction trans, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_000f: Unknown result type (might be due to invalid IL or missing references)
        SQLiteCommand val = new SQLiteCommand();
        PrepareCommand(val, ((SQLiteTransactionBase)trans).Connection, trans, cmdType, cmdText, commandParameters);
        int result = ((DbCommand)val).ExecuteNonQuery();
        ((DbParameterCollection)val.Parameters).Clear();
        ((DbConnection)((SQLiteTransactionBase)trans).Connection).Close();
        return result;
    }

    public static SQLiteDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_0008: Unknown result type (might be due to invalid IL or missing references)
        //IL_000e: Expected O, but got Unknown
        //IL_0012: Unknown result type (might be due to invalid IL or missing references)
        SQLiteCommand val = new SQLiteCommand();
        SQLiteConnection val2 = new SQLiteConnection(connectionString);
        try
        {
            PrepareCommand(val, val2, null, cmdType, cmdText, commandParameters);
            SQLiteDataReader result = val.ExecuteReader((CommandBehavior)32);
            ((DbParameterCollection)val.Parameters).Clear();
            return result;
        }
        catch
        {
            ((DbConnection)val2).Close();
            throw;
        }
    }

    public static SQLiteDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_0008: Unknown result type (might be due to invalid IL or missing references)
        //IL_000e: Expected O, but got Unknown
        //IL_0012: Unknown result type (might be due to invalid IL or missing references)
        SQLiteCommand val = new SQLiteCommand();
        SQLiteConnection val2 = new SQLiteConnection(connectionString);
        try
        {
            PrepareCommand(val, val2, null, cmdType, cmdText);
            SQLiteDataReader result = val.ExecuteReader((CommandBehavior)32);
            ((DbParameterCollection)val.Parameters).Clear();
            return result;
        }
        catch
        {
            ((DbConnection)val2).Close();
            throw;
        }
    }

    public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_0008: Unknown result type (might be due to invalid IL or missing references)
        //IL_000e: Expected O, but got Unknown
        //IL_0012: Unknown result type (might be due to invalid IL or missing references)
        SQLiteCommand val = new SQLiteCommand();
        SQLiteConnection val2 = new SQLiteConnection(connectionString);
        try
        {
            PrepareCommand(val, val2, null, cmdType, cmdText, commandParameters);
            object result = ((DbCommand)val).ExecuteScalar();
            ((DbParameterCollection)val.Parameters).Clear();
            ((DbConnection)val2).Close();
            return result;
        }
        finally
        {
            ((IDisposable)val2)?.Dispose();
        }
    }

    public static object ExecuteScalar(SQLiteConnection connection, CommandType cmdType, string cmdText, params SQLiteParameter[] commandParameters)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_000a: Unknown result type (might be due to invalid IL or missing references)
        SQLiteCommand val = new SQLiteCommand();
        PrepareCommand(val, connection, null, cmdType, cmdText, commandParameters);
        object result = ((DbCommand)val).ExecuteScalar();
        ((DbParameterCollection)val.Parameters).Clear();
        ((DbConnection)connection).Close();
        return result;
    }

    public static DataSet ExecuteDataSet(string connectionString, CommandType cmdType, string cmdText, string tableName, params SQLiteParameter[] commandParameters)
    {
        //IL_0001: Unknown result type (might be due to invalid IL or missing references)
        //IL_0007: Expected O, but got Unknown
        //IL_0008: Unknown result type (might be due to invalid IL or missing references)
        //IL_000e: Expected O, but got Unknown
        //IL_0016: Unknown result type (might be due to invalid IL or missing references)
        //IL_001c: Expected O, but got Unknown
        //IL_001c: Unknown result type (might be due to invalid IL or missing references)
        //IL_0022: Expected O, but got Unknown
        //IL_0026: Unknown result type (might be due to invalid IL or missing references)
        DataSet val = new DataSet();
        SQLiteConnection val2 = new SQLiteConnection(connectionString);
        try
        {
            ((DbConnection)val2).Open();
            SQLiteCommand val3 = new SQLiteCommand();
            SQLiteDataAdapter val4 = new SQLiteDataAdapter();
            try
            {
                PrepareCommand(val3, val2, null, cmdType, cmdText, commandParameters);
                val4.SelectCommand = val3;
                ((DbDataAdapter)val4).Fill(val, tableName);
                ((DbParameterCollection)val3.Parameters).Clear();
                ((DbConnection)val2).Close();
            }
            finally
            {
                ((IDisposable)val4)?.Dispose();
            }
        }
        finally
        {
            ((IDisposable)val2)?.Dispose();
        }
        return val;
    }

    public static void CacheParameters(string cacheKey, params SQLiteParameter[] commandParameters)
    {
        parmCache[cacheKey] = commandParameters;
    }

    public static SQLiteParameter[] GetCachedParameters(string cacheKey)
    {
        //IL_003d: Unknown result type (might be due to invalid IL or missing references)
        //IL_0043: Expected O, but got Unknown
        SQLiteParameter[] array = (SQLiteParameter[])parmCache[cacheKey];
        if (array == null)
        {
            return null;
        }
        SQLiteParameter[] array2 = (SQLiteParameter[])(object)new SQLiteParameter[array.Length];
        int i = 0;
        for (int num = array.Length; i < num; i++)
        {
            array2[i] = (SQLiteParameter)((ICloneable)array[i]).Clone();
        }
        return array2;
    }

    private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, CommandType cmdType, string cmdText, SQLiteParameter[] cmdParms)
    {
        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
        //IL_0008: Invalid comparison between Unknown and I4
        //IL_003a: Unknown result type (might be due to invalid IL or missing references)
        if ((int)((DbConnection)conn).State != 1)
        {
            ((DbConnection)conn).Open();
        }
        cmd.Connection = conn;
        ((DbCommand)cmd).CommandText = cmdText;
        if (trans != null)
        {
            cmd.Transaction = trans;
        }
        ((DbCommand)cmd).CommandType = cmdType;
        if (cmdParms != null)
        {
            foreach (SQLiteParameter val in cmdParms)
            {
                cmd.Parameters.Add(val);
            }
        }
    }

    private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, SQLiteTransaction trans, CommandType cmdType, string cmdText)
    {
        //IL_0002: Unknown result type (might be due to invalid IL or missing references)
        //IL_0008: Invalid comparison between Unknown and I4
        //IL_003a: Unknown result type (might be due to invalid IL or missing references)
        if ((int)((DbConnection)conn).State != 1)
        {
            ((DbConnection)conn).Open();
        }
        cmd.Connection = conn;
        ((DbCommand)cmd).CommandText = cmdText;
        if (trans != null)
        {
            cmd.Transaction = trans;
        }
        ((DbCommand)cmd).CommandType = cmdType;
    }
}

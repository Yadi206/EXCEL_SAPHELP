using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SAP.Middleware.Connector;


public static class RunRFC_READ_TABLE
{
    public static int runfun(RfcDestination SapRfcD, RfcRepository SapRfcR, string TableName)
    {
        string text = "";
        string text2 = "";
        try
        {
            int result = 0;
            IRfcFunction rfcFunction = SapRfcR.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", TableName);
            rfcFunction.SetValue("NO_DATA", "X");
            rfcFunction.SetValue("DELIMITER", "|");
            rfcFunction.Invoke(SapRfcD);
            IRfcTable table = rfcFunction.GetTable("FIELDS");
            int num = 1;
            for (int i = 0; i < table.RowCount; i++)
            {
                num++;
                table.CurrentIndex = i;
                IRfcStructure currentRow = table.CurrentRow;
                text2 = "insert into sys_t_dbfld (tabname, fieldname, offset, length, type, fieldtext)values ('" + TableName + "','" + currentRow.GetValue("FIELDNAME").ToString().Replace("'", "") + "','" + currentRow.GetValue("OFFSET").ToString().Replace("'", "") + "','" + currentRow.GetValue("LENGTH").ToString().Replace("'", "") + "','" + currentRow.GetValue("TYPE").ToString().Replace("'", "") + "','" + currentRow.GetValue("FIELDTEXT").ToString().Replace("'", "") + "');";
                text = text + Environment.NewLine + text2;
            }
            if (!string.IsNullOrEmpty(text))
            {
                text2 = "delete from sys_t_dbfld where tabname = '" + TableName + "';";
                text = text2 + Environment.NewLine + text;
                SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                result = sQLiteDBHelper.ExecuteNonQuery(text, null);
            }
            return result;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message + "，表名：" + TableName + ",SQL:" + text, ex);
        }
    }

    /// <summary>
    /// 读取SAP表数据
    /// </summary>
    /// <param name="SapRfcD">SAP链接对象</param>
    /// <param name="SapRfcR">SAP函数工厂</param>
    /// <param name="TableName">表名称</param>
    /// <param name="cloumns">列集合</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static IRfcTable getTable(RfcDestination SapRfcD, RfcRepository SapRfcR, string TableName, List<string> cloumns)
    {
        IRfcTable table;
        string text = "";
        string text2 = "";
        try
        {
            int result = 0;
            IRfcFunction rfcFunction = SapRfcR.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", TableName);
            rfcFunction.SetValue("NO_DATA", " ");
            if (cloumns != null && cloumns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in cloumns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Insert(rfcs);
                }
            }

            rfcFunction.Invoke(SapRfcD);
            table = rfcFunction.GetTable("DATA");
            return table;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message + "，表名：" + TableName + ",SQL:" + text, ex);
        }
    }

    /// <summary>
    /// 读取SAP表数据
    /// </summary>
    /// <param name="SapRfcD">SAP链接对象</param>
    /// <param name="SapRfcR">SAP函数工厂</param>
    /// <param name="TableName">表名称</param>
    /// <param name="cloumns">列集合</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static DataTable getDataTable(RfcDestination SapRfcD, RfcRepository SapRfcR, string TableName, List<string> cloumns, List<string> options)
    {
        if (cloumns.Count < 0)
        {
            throw new Exception("选择要查询的列");
        }
        DataTable table = new DataTable();
        foreach (string item in cloumns)
        {
            table.Columns.Add(item);
        }

        string text = "";
        string text2 = "";
        try
        {
            int result = 0;
            IRfcFunction rfcFunction = SapRfcR.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", TableName);
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (cloumns != null && cloumns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in cloumns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (options != null && options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in options)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("TEXT", item);
                    rfctColumns.Append(rfcs);
                }
            }


            rfcFunction.Invoke(SapRfcD);
            IRfcTable table1 = rfcFunction.GetTable("DATA");

            for (int i = 0; i < table1.RowCount; i++)
            {
                table1.CurrentIndex = i;
                IRfcStructure currentRow = table1.CurrentRow;
                string a = currentRow.GetValue("WA").ToString();
                string[] strArray = a.Split('|');
                DataRow dr = table.NewRow();
                for (global::System.Int32 j = 0; j < strArray.Length; j++)
                {
                    dr[j] = strArray[j];
                }
                table.Rows.Add(dr);
            }
            return table;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
     

     
}

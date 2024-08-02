using System;
using EXCEL_SAPHELP.EXCEL;
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
}

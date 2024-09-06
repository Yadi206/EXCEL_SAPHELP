using System;
using EXCEL_SAPHELP.EXCEL;
using SAP.Middleware.Connector;
 
/// <summary>
/// 读取表结构
/// </summary>
public static class RunDD_GET_NAMETAB_FOR_RFC
{
	public static int runfun(RfcDestination SapRfcD, RfcRepository SapRfcR, string TableName)
	{
		try
		{
			int result = 0;
			string text = "";
			string text2 = "";
			IRfcFunction rfcFunction = SapRfcR.CreateFunction("DD_GET_NAMETAB_FOR_RFC");
			rfcFunction.SetValue("TABNAME", TableName);
			rfcFunction.Invoke(SapRfcD);
			IRfcTable table = rfcFunction.GetTable("X031L_TAB");
			int num = 1;
			for (int i = 0; i < table.RowCount; i++)
			{
				num++;
				table.CurrentIndex = i;
				IRfcStructure currentRow = table.CurrentRow;
				text2 = "insert into sys_t_x031l (tabname, \"position\", flag1, flag2, flag3, flag4, dbtabpos, fieldtype, offset, dblength,dblength2, exlength, decimals, depth, fldalign, fieldname, rollname, abtype, dtyp, exid,reftable, reffield, precfield, convexit, memoryid, checktable, digits)values ('" + currentRow.GetValue("TABNAME")?.ToString() + "','" + ((byte[])currentRow.GetValue("POSITION"))[0] + ((byte[])currentRow.GetValue("POSITION"))[1] + "','" + ((byte[])currentRow.GetValue("FLAG1"))[0] + "','" + ((byte[])currentRow.GetValue("FLAG2"))[0] + "','" + ((byte[])currentRow.GetValue("FLAG3"))[0] + "','" + ((byte[])currentRow.GetValue("FLAG4"))[0] + "','" + ((byte[])currentRow.GetValue("DBTABPOS"))[0] + ((byte[])currentRow.GetValue("DBTABPOS"))[1] + "','" + ((byte[])currentRow.GetValue("FIELDTYPE"))[0] + "','" + ((byte[])currentRow.GetValue("OFFSET"))[0] + ((byte[])currentRow.GetValue("OFFSET"))[1] + ((byte[])currentRow.GetValue("OFFSET"))[2] + ((byte[])currentRow.GetValue("OFFSET"))[3] + "','" + ((byte[])currentRow.GetValue("DBLENGTH"))[0] + ((byte[])currentRow.GetValue("DBLENGTH"))[1] + "','" + ((byte[])currentRow.GetValue("DBLENGTH2"))[0] + ((byte[])currentRow.GetValue("DBLENGTH2"))[1] + ((byte[])currentRow.GetValue("DBLENGTH2"))[2] + ((byte[])currentRow.GetValue("DBLENGTH2"))[3] + "','" + ((byte[])currentRow.GetValue("EXLENGTH"))[0] + ((byte[])currentRow.GetValue("EXLENGTH"))[1] + "','" + ((byte[])currentRow.GetValue("DECIMALS"))[0] + "','" + ((byte[])currentRow.GetValue("DEPTH"))[0] + "','" + ((byte[])currentRow.GetValue("FLDALIGN"))[0] + "','" + currentRow.GetValue("FIELDNAME")?.ToString() + "','" + currentRow.GetValue("ROLLNAME")?.ToString() + "','" + ((byte[])currentRow.GetValue("ABTYPE"))[0] + "','" + currentRow.GetValue("DTYP")?.ToString() + "','" + currentRow.GetValue("EXID")?.ToString() + "','" + currentRow.GetValue("REFTABLE")?.ToString() + "','" + currentRow.GetValue("REFFIELD")?.ToString() + "','" + ((byte[])currentRow.GetValue("PRECFIELD"))[0] + ((byte[])currentRow.GetValue("PRECFIELD"))[1] + "','" + currentRow.GetValue("CONVEXIT")?.ToString() + "','" + currentRow.GetValue("MEMORYID")?.ToString() + "','" + currentRow.GetValue("CHECKTABLE")?.ToString() + "','" + ((byte[])currentRow.GetValue("DIGITS"))[0] + ((byte[])currentRow.GetValue("DIGITS"))[1] + "');";
				text = text + Environment.NewLine + text2;
			}
			if (!string.IsNullOrEmpty(text))
			{
				text2 = "delete from sys_t_x031l where tabname = '" + TableName + "';";
				text = text2 + Environment.NewLine + text;
				SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
				result = sQLiteDBHelper.ExecuteNonQuery(text, null);
			}
			return result;
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}
}

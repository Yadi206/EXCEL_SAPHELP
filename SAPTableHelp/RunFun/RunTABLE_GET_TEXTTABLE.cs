using System; 
using SAP.Middleware.Connector;

/// <summary>
/// 读取表对应文本表
/// </summary>
public static class RunTABLE_GET_TEXTTABLE
{
    public static int runfun(RfcDestination SapRfcD, RfcRepository SapRfcR, string TableName,ref string txtTableName)
    {
        string text2 = "";
        try
        {
            int result = 0;
            IRfcFunction rfcFunction = SapRfcR.CreateFunction("TABLE_GET_TEXTTABLE");
            rfcFunction.SetValue("CHECKTABLE", TableName);
            rfcFunction.Invoke(SapRfcD);
            txtTableName = rfcFunction.GetValue("TABNAME").ToString(); 
            text2 = "update sys_t_tables set  tabtxtname = '" + txtTableName + "' where tabname = '" + TableName + "';";

            if (!string.IsNullOrEmpty(text2))
            {
                SQLiteDBHelper sQLiteDBHelper = new SQLiteDBHelper(SysConfigInfo.sqlite_path);
                result = sQLiteDBHelper.ExecuteNonQuery(text2, null);
            }
            return result;
        }
        catch (Exception ex)
        {
            if (ex.Message != "TABLE_NOT_FOUND")
            {
                throw new Exception(ex.Message + "，表名：" + TableName + ",SQL:" + text2, ex);
            }
            else
            {
                return 0;
            }
        }
    }
}

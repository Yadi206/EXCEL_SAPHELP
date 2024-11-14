using System; 
using SAP.Middleware.Connector;

/// <summary>
/// 读取字段结构 带主键信息
/// </summary>
public static class RunMDG_TR_NAMETAB_GET_RFC
{
    public static int runfun(RfcDestination SapRfcD, RfcRepository SapRfcR, string TableName,ref IRfcTable table1)
    {
        //读表DD03L
        string text = "";
        string text2 = "";
        try
        {
            int result = 0;
            IRfcFunction rfcFunction = SapRfcR.CreateFunction("MDG_TR_NAMETAB_GET_RFC");
            rfcFunction.SetValue("I_TABNAME", TableName);
            rfcFunction.Invoke(SapRfcD);
            table1 = rfcFunction.GetTable("ET_DFIES");
            IRfcTable table2 = rfcFunction.GetTable("ET_KEY_DFIES");
            int num = 1;
            for (int i = 0; i < table1.RowCount; i++)
            {
                num++;
                table1.CurrentIndex = i;
                IRfcStructure currentRow = table1.CurrentRow;
                text2 = "insert into sys_t_et_dfies (" +
                        "tabname, fieldname, langu, \"position\", offset, domname, rollname, checktable, leng, intlen," +
                        "outputlen, decimals, datatype, inttype, reftable, reffield, precfield, authorid, memoryid," +
                        "logflag, mask, masklen, convexit, headlen, scrlen1, scrlen2, scrlen3, fieldtext, reptext," +
                        "scrtext_s, scrtext_m, scrtext_l, keyflag, lowercase, mac, genkey, noforkey, valexi," +
                        "noauthch, sign, dynpfld, f4availabl, comptype, lfieldname, ltrflddis, bidictrlc," +
                        "outputstyle, nohistory, ampmformat)" +
                        "values ('" +
                        currentRow.GetValue("TABNAME").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("FIELDNAME").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("LANGU").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("POSITION").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("OFFSET").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("DOMNAME").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("ROLLNAME").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("CHECKTABLE").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("LENG").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("INTLEN").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("OUTPUTLEN").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("DECIMALS").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("DATATYPE").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("INTTYPE").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("REFTABLE").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("REFFIELD").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("PRECFIELD").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("AUTHORID").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("MEMORYID").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("LOGFLAG").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("MASK").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("MASKLEN").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("CONVEXIT").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("HEADLEN").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("SCRLEN1").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("SCRLEN2").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("SCRLEN3").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("FIELDTEXT").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("REPTEXT").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("SCRTEXT_S").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("SCRTEXT_M").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("SCRTEXT_L").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("KEYFLAG").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("LOWERCASE").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("MAC").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("GENKEY").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("NOFORKEY").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("VALEXI").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("NOAUTHCH").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("SIGN").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("DYNPFLD").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("F4AVAILABL").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("COMPTYPE").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("LFIELDNAME").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("LTRFLDDIS").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("BIDICTRLC").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("OUTPUTSTYLE").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("NOHISTORY").ToString().Replace("'", "") + "','" +
                        currentRow.GetValue("AMPMFORMAT").ToString().Replace("'", "") + "'"  +
                        ");";  
                text = text + Environment.NewLine + text2;
            }
            if (!string.IsNullOrEmpty(text))
            {
                text2 = "delete from sys_t_et_dfies where tabname = '" + TableName + "';";
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

using System; 
using SAP.Middleware.Connector;

/// <summary>
/// 读取表描述
/// </summary>
public static class RunLTR_MODEL_GET_TABLE_TEXTS
{
    public static int runfun(RfcDestination SapRfcD, RfcRepository SapRfcR, string TableName)
    {
        //读取表内容 通过DD02T 读取表名称
        try
        {
            int result = 0;
            string text = "";
            string text2 = "";
            IRfcFunction rfcFunction = SapRfcR.CreateFunction("LTR_MODEL_GET_TABLE_TEXTS");
            rfcFunction.SetValue("IV_TABLE_NAME", TableName);
            rfcFunction.Invoke(SapRfcD);
            IRfcTable table = rfcFunction.GetTable("TT_DD02T");
            for (int i = 0; i < table.RowCount; i++)
            {
                table.CurrentIndex = i;
                IRfcStructure currentRow = table.CurrentRow;
                string slanguage = currentRow.GetValue("DDLANGUAGE").ToString();
                string sdescribe = currentRow.GetValue("DDTEXT").ToString(); 
                if (slanguage == "0") slanguage = "SR";
                if (slanguage == "1") slanguage = "ZH";
                if (slanguage == "2") slanguage = "TH";
                if (slanguage == "3") slanguage = "KO";
                if (slanguage == "4") slanguage = "RO";
                if (slanguage == "5") slanguage = "SL";
                if (slanguage == "6") slanguage = "HR";
                if (slanguage == "7") slanguage = "MS";
                if (slanguage == "8") slanguage = "UK";
                if (slanguage == "9") slanguage = "ET";
                if (slanguage == "A") slanguage = "AR";
                if (slanguage == "B") slanguage = "HE";
                if (slanguage == "C") slanguage = "CS";
                if (slanguage == "D") slanguage = "DE";
                if (slanguage == "E") slanguage = "EN";
                if (slanguage == "F") slanguage = "FR";
                if (slanguage == "G") slanguage = "EL";
                if (slanguage == "H") slanguage = "HU";
                if (slanguage == "I") slanguage = "IT";
                if (slanguage == "J") slanguage = "JA";
                if (slanguage == "K") slanguage = "DA";
                if (slanguage == "L") slanguage = "PL";
                if (slanguage == "M") slanguage = "ZF";
                if (slanguage == "N") slanguage = "NL";
                if (slanguage == "O") slanguage = "NO";
                if (slanguage == "P") slanguage = "PT";
                if (slanguage == "Q") slanguage = "SK";
                if (slanguage == "R") slanguage = "RU";
                if (slanguage == "S") slanguage = "ES";
                if (slanguage == "T") slanguage = "TR";
                if (slanguage == "U") slanguage = "FI";
                if (slanguage == "V") slanguage = "SV";
                if (slanguage == "W") slanguage = "BG";
                if (slanguage == "X") slanguage = "LT";
                if (slanguage == "Y") slanguage = "LV";
                if (slanguage == "Z") slanguage = "Z1";
                if (slanguage == "a") slanguage = "AF";
                if (slanguage == "b") slanguage = "IS";
                if (slanguage == "c") slanguage = "CA";
                if (slanguage == "d") slanguage = "SH";
                if (slanguage == "i") slanguage = "ID";
                if (slanguage == "묩") slanguage = "HI";
                if (slanguage == "뱋") slanguage = "KK";
                if (slanguage == "쁩") slanguage = "VI";


                if (slanguage == SysConfigInfo.parms["LANG"].ToString())
                {
                    text2 = "insert into sys_t_tables (tabname, tabdescribe, tabtxtname) values ('" + TableName + "','" + sdescribe + "','');";
                    text = text + Environment.NewLine + text2;
                    break;
                }
            }
            if (!string.IsNullOrEmpty(text))
            {
                text2 = "delete from sys_t_tables where tabname = '" + TableName + "';";
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

using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class DD03T
{
    public DD03T()
    {

    }

    public DD03T(string TableName)
    {
        getFirstDD03T(TableName);
    }


    /// <summary>
    /// 读取SAP中表字段属性
    /// </summary>
    /// <param name="TableName"></param>
    /// <returns></returns>
    public List<DD03T> getDD03Ts(string TableName)
    {
        List<DD03T> DD03Ts = new List<DD03T>();

        List<String> DD03T_Columns = new List<string>();
        DD03T_Columns.Add("TABNAME");//表名 
        DD03T_Columns.Add("DDLANGUAGE");//语言代码 
        DD03T_Columns.Add("AS4LOCAL");//资源库对象的激活状态  
        DD03T_Columns.Add("FIELDNAME");//字段名  
        DD03T_Columns.Add("DDTEXT");//资源库对象的简短描述  



        List<String> DD03T_options = new List<string>();
        DD03T_options.Add("TABNAME = '" + TableName + "'");//表名 

        string langu = "1";
        if (SysConfigInfo.parms["LANG"].ToString() == "SR") langu = "0";
        if (SysConfigInfo.parms["LANG"].ToString() == "ZH") langu = "1";
        if (SysConfigInfo.parms["LANG"].ToString() == "TH") langu = "2";
        if (SysConfigInfo.parms["LANG"].ToString() == "KO") langu = "3";
        if (SysConfigInfo.parms["LANG"].ToString() == "RO") langu = "4";
        if (SysConfigInfo.parms["LANG"].ToString() == "SL") langu = "5";
        if (SysConfigInfo.parms["LANG"].ToString() == "HR") langu = "6";
        if (SysConfigInfo.parms["LANG"].ToString() == "MS") langu = "7";
        if (SysConfigInfo.parms["LANG"].ToString() == "UK") langu = "8";
        if (SysConfigInfo.parms["LANG"].ToString() == "ET") langu = "9";
        if (SysConfigInfo.parms["LANG"].ToString() == "AR") langu = "A";
        if (SysConfigInfo.parms["LANG"].ToString() == "HE") langu = "B";
        if (SysConfigInfo.parms["LANG"].ToString() == "CS") langu = "C";
        if (SysConfigInfo.parms["LANG"].ToString() == "DE") langu = "D";
        if (SysConfigInfo.parms["LANG"].ToString() == "EN") langu = "E";
        if (SysConfigInfo.parms["LANG"].ToString() == "FR") langu = "F";
        if (SysConfigInfo.parms["LANG"].ToString() == "EL") langu = "G";
        if (SysConfigInfo.parms["LANG"].ToString() == "HU") langu = "H";
        if (SysConfigInfo.parms["LANG"].ToString() == "IT") langu = "I";
        if (SysConfigInfo.parms["LANG"].ToString() == "JA") langu = "J";
        if (SysConfigInfo.parms["LANG"].ToString() == "DA") langu = "K";
        if (SysConfigInfo.parms["LANG"].ToString() == "PL") langu = "L";
        if (SysConfigInfo.parms["LANG"].ToString() == "ZF") langu = "M";
        if (SysConfigInfo.parms["LANG"].ToString() == "NL") langu = "N";
        if (SysConfigInfo.parms["LANG"].ToString() == "NO") langu = "O";
        if (SysConfigInfo.parms["LANG"].ToString() == "PT") langu = "P";
        if (SysConfigInfo.parms["LANG"].ToString() == "SK") langu = "Q";
        if (SysConfigInfo.parms["LANG"].ToString() == "RU") langu = "R";
        if (SysConfigInfo.parms["LANG"].ToString() == "ES") langu = "S";
        if (SysConfigInfo.parms["LANG"].ToString() == "TR") langu = "T";
        if (SysConfigInfo.parms["LANG"].ToString() == "FI") langu = "U";
        if (SysConfigInfo.parms["LANG"].ToString() == "SV") langu = "V";
        if (SysConfigInfo.parms["LANG"].ToString() == "BG") langu = "W";
        if (SysConfigInfo.parms["LANG"].ToString() == "LT") langu = "X";
        if (SysConfigInfo.parms["LANG"].ToString() == "LV") langu = "Y";
        if (SysConfigInfo.parms["LANG"].ToString() == "Z1") langu = "Z";
        if (SysConfigInfo.parms["LANG"].ToString() == "AF") langu = "a";
        if (SysConfigInfo.parms["LANG"].ToString() == "IS") langu = "b";
        if (SysConfigInfo.parms["LANG"].ToString() == "CA") langu = "c";
        if (SysConfigInfo.parms["LANG"].ToString() == "SH") langu = "d";
        if (SysConfigInfo.parms["LANG"].ToString() == "ID") langu = "i";
        if (SysConfigInfo.parms["LANG"].ToString() ==  "HI") langu  ="묩";
        if (SysConfigInfo.parms["LANG"].ToString() ==  "KK") langu  ="뱋";
        if (SysConfigInfo.parms["LANG"].ToString() ==  "VI") langu  ="쁩";
         
        DD03T_options.Add(" AND DDLANGUAGE = '" + langu + "'");//表名 

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD03T");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD03T_Columns != null && DD03T_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD03T_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD03T_options != null && DD03T_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD03T_options)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("TEXT", item);
                    rfctColumns.Append(rfcs);
                }
            }
            rfcFunction.Invoke(SysConfigInfo.SapRfcDestination);
            IRfcTable table1 = rfcFunction.GetTable("DATA");

            for (int i = 0; i < table1.RowCount; i++)
            {
                table1.CurrentIndex = i;
                IRfcStructure currentRow = table1.CurrentRow;
                string a = currentRow.GetValue("WA").ToString();
                string[] strArray = a.Split('|');

                DD03T obj = new DD03T();

                obj.TABNAME = strArray[0];//表名 
                obj.DDLANGUAGE = strArray[1];//语言代码 
                obj.AS4LOCAL = strArray[2];//资源库对象的激活状态  
                obj.FIELDNAME = strArray[3];//字段名  
                obj.DDTEXT = strArray[4];//资源库对象的简短描述  


                DD03Ts.Add(obj);
            }
            return DD03Ts;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }


    /// <summary>
    /// 读取SAP中文表名
    /// </summary>
    /// <param name="TableName"></param>
    /// <returns></returns>
    public void getFirstDD03T(string TableName)
    {

        List<String> DD03T_Columns = new List<string>();
        DD03T_Columns.Add("TABNAME");//表名 
        DD03T_Columns.Add("DDLANGUAGE");//语言代码 
        DD03T_Columns.Add("AS4LOCAL");//资源库对象的激活状态  
        DD03T_Columns.Add("FIELDNAME");//字段名  
        DD03T_Columns.Add("DDTEXT");//资源库对象的简短描述  


        List<String> DD03T_options = new List<string>();
        DD03T_options.Add("TABNAME = '" + TableName + "'");//表名 

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD03T");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD03T_Columns != null && DD03T_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD03T_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD03T_options != null && DD03T_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD03T_options)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("TEXT", item);
                    rfctColumns.Append(rfcs);
                }
            }
            rfcFunction.Invoke(SysConfigInfo.SapRfcDestination);
            IRfcTable table1 = rfcFunction.GetTable("DATA");
            if (table1.RowCount > 0)
            {
                table1.CurrentIndex = 0;
                IRfcStructure currentRow = table1.CurrentRow;
                string a = currentRow.GetValue("WA").ToString();
                string[] strArray = a.Split('|');

                this.TABNAME = strArray[0];//表名 
                this.DDLANGUAGE = strArray[1];//语言代码 
                this.AS4LOCAL = strArray[2];//资源库对象的激活状态  
                this.FIELDNAME = strArray[3];//字段名  
                this.DDTEXT = strArray[4];//资源库对象的简短描述  

            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
    private string tABNAME;

    /// <summary>
    /// 表名
    /// </summary>
    public string TABNAME
    {
        get { return tABNAME; }
        set { tABNAME = value; }
    }
    private string dDLANGUAGE;

    /// <summary>
    /// 语言代码
    /// </summary>
    public string DDLANGUAGE
    {
        get { return dDLANGUAGE; }
        set { dDLANGUAGE = value; }
    }
    private string aS4LOCAL;

    /// <summary>
    /// 资源库对象的激活状态 
    /// </summary>
    public string AS4LOCAL
    {
        get { return aS4LOCAL; }
        set { aS4LOCAL = value; }
    }
    private string fIELDNAME;

    /// <summary>
    /// 字段名 
    /// </summary>
    public string FIELDNAME
    {
        get { return fIELDNAME; }
        set { fIELDNAME = value; }
    }
    private string dDTEXT;

    /// <summary>
    /// 资源库对象的简短描述 
    /// </summary>
    public string DDTEXT
    {
        get { return dDTEXT; }
        set { dDTEXT = value; }
    }



}

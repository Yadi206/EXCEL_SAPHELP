using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class DD04T
{
    public DD04T()
    {

    }

    public DD04T(string TableName)
    {
        getFirstDD04T(TableName);
    }


    /// <summary>
    /// 读取SAP中表字段属性
    /// </summary>
    /// <param name="TableName"></param>
    /// <returns></returns>
    public List<DD04T> getDD04Ts(string TableName)
    {
        List<DD04T> DD04Ts = new List<DD04T>();

        List<String> DD04T_Columns = new List<string>();
        DD04T_Columns.Add("ROLLNAME");//Data element (semantic domain) 
        DD04T_Columns.Add("DDLANGUAGE");//Language key 
        DD04T_Columns.Add("AS4LOCAL");//Activation status of a Repository object 
        DD04T_Columns.Add("AS4VERS");//Version of the entry (not used) 
        DD04T_Columns.Add("DDTEXT");//Short Text Describing R/3 Repository Objects 
        DD04T_Columns.Add("REPTEXT");//Heading 
        DD04T_Columns.Add("SCRTEXT_S");//Short Field Label 
        DD04T_Columns.Add("SCRTEXT_M");//Medium field label 
        DD04T_Columns.Add("SCRTEXT_L");//Long field label 



        List<String> DD04T_options = new List<string>();
        DD04T_options.Add("TABNAME = '" + TableName + "'");//表名 

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD04T");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD04T_Columns != null && DD04T_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD04T_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD04T_options != null && DD04T_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD04T_options)
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

                DD04T obj = new DD04T();

                obj.ROLLNAME = strArray[0];//Data element (semantic domain) 
                obj.DDLANGUAGE = strArray[1];//Language key 
                obj.AS4LOCAL = strArray[2];//Activation status of a Repository object 
                obj.AS4VERS = strArray[3];//Version of the entry (not used) 
                obj.DDTEXT = strArray[4];//Short Text Describing R/3 Repository Objects 
                obj.REPTEXT = strArray[5];//Heading 
                obj.SCRTEXT_S = strArray[6];//Short Field Label 
                obj.SCRTEXT_M = strArray[7];//Medium field label 
                obj.SCRTEXT_L = strArray[8];//Long field label 


                DD04Ts.Add(obj);
            }
            return DD04Ts;
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
    public void getFirstDD04T(string TableName)
    {

        List<String> DD04T_Columns = new List<string>(); 
        DD04T_Columns.Add("TABNAME");//表名 
        DD04T_Columns.Add("POSITION");//表格中区域的位置 
        DD04T_Columns.Add("FIELDNAME");//字段名 
        DD04T_Columns.Add("KEYFLAG");//标识表格的关键字段 
        DD04T_Columns.Add("MANDATORY");//标记:要求输入字段(不为空) 
        DD04T_Columns.Add("ROLLNAME");//数据元素(语义域) 
        DD04T_Columns.Add("CHECKTABLE");//异型键表名检查 
        DD04T_Columns.Add("INTTYPE");//ABAP数据类型(C,D,N,...) 
        DD04T_Columns.Add("INTLEN");//内部长度（字节） 
        DD04T_Columns.Add("REFTABLE");//字段的参考表 
        DD04T_Columns.Add("DATATYPE");//ABAP字典中的数据类型 
        DD04T_Columns.Add("LENG");//长度（字符数） 
        DD04T_Columns.Add("DECIMALS");//小数位数 
        DD04T_Columns.Add("DOMNAME");//定义域名 

        List<String> DD04T_options = new List<string>();
        DD04T_options.Add("TABNAME = '" + TableName + "'");//表名 

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD04T");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD04T_Columns != null && DD04T_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD04T_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD04T_options != null && DD04T_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD04T_options)
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

                this.ROLLNAME = strArray[0];//Data element (semantic domain) 
                this.DDLANGUAGE = strArray[1];//Language key 
                this.AS4LOCAL = strArray[2];//Activation status of a Repository object 
                this.AS4VERS = strArray[3];//Version of the entry (not used) 
                this.DDTEXT = strArray[4];//Short Text Describing R/3 Repository Objects 
                this.REPTEXT = strArray[5];//Heading 
                this.SCRTEXT_S = strArray[6];//Short Field Label 
                this.SCRTEXT_M = strArray[7];//Medium field label 
                this.SCRTEXT_L = strArray[8];//Long field label 

            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
    private string rOLLNAME;

    /// <summary>
    /// Data element (semantic domain)
    /// </summary>
    public string ROLLNAME
    {
        get { return rOLLNAME; }
        set { rOLLNAME = value; }
    }
    private string dDLANGUAGE;

    /// <summary>
    /// Language key
    /// </summary>
    public string DDLANGUAGE
    {
        get { return dDLANGUAGE; }
        set { dDLANGUAGE = value; }
    }
    private string aS4LOCAL;

    /// <summary>
    /// Activation status of a Repository object
    /// </summary>
    public string AS4LOCAL
    {
        get { return aS4LOCAL; }
        set { aS4LOCAL = value; }
    }
    private string aS4VERS;

    /// <summary>
    /// Version of the entry (not used)
    /// </summary>
    public string AS4VERS
    {
        get { return aS4VERS; }
        set { aS4VERS = value; }
    }
    private string dDTEXT;

    /// <summary>
    /// Short Text Describing R/3 Repository Objects
    /// </summary>
    public string DDTEXT
    {
        get { return dDTEXT; }
        set { dDTEXT = value; }
    }
    private string rEPTEXT;

    /// <summary>
    /// Heading
    /// </summary>
    public string REPTEXT
    {
        get { return rEPTEXT; }
        set { rEPTEXT = value; }
    }
    private string sCRTEXT_S;

    /// <summary>
    /// Short Field Label
    /// </summary>
    public string SCRTEXT_S
    {
        get { return sCRTEXT_S; }
        set { sCRTEXT_S = value; }
    }
    private string sCRTEXT_M;

    /// <summary>
    /// Medium field label
    /// </summary>
    public string SCRTEXT_M
    {
        get { return sCRTEXT_M; }
        set { sCRTEXT_M = value; }
    }
    private string sCRTEXT_L;

    /// <summary>
    /// Long field label
    /// </summary>
    public string SCRTEXT_L
    {
        get { return sCRTEXT_L; }
        set { sCRTEXT_L = value; }
    }



}

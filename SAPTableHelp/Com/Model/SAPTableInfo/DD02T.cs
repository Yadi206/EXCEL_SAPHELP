using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class DD02T
{
    public DD02T()
    {
        this.TABNAME = "";//表名
        this.DDLANGUAGE = "";//语言代码
        this.AS4LOCAL = "";//资源库对象的激活状态
        this.AS4VERS = "";//表目的版本（版本） 
        this.DDTEXT = "";//资源库对象的简短描述 

    }

    public DD02T(string TableName, string language)
    {
        getFirstDD02T(TableName, language);
    }


    /// <summary>
    /// 读取SAP中文表名
    /// </summary>
    /// <param name="TableName"></param>
    /// <returns></returns>
    public List<DD02T> getDD02Ts(string TableName)
    {
        List<DD02T> dD02Ts = new List<DD02T>();

        List<String> DD02T_Columns = new List<string>();
        DD02T_Columns.Add("TABNAME");//表名
        DD02T_Columns.Add("DDLANGUAGE");//语言代码
        DD02T_Columns.Add("AS4LOCAL");//资源库对象的激活状态
        DD02T_Columns.Add("AS4VERS");//表目的版本（版本） 
        DD02T_Columns.Add("DDTEXT");//资源库对象的简短描述 

        List<String> DD02T_options = new List<string>();
        DD02T_options.Add("TABNAME = '" + TableName + "'");//表名
        DD02T_options.Add("AND DDLANGUAGE = '1'");//表名 

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD02T");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD02T_Columns != null && DD02T_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD02T_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD02T_options != null && DD02T_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD02T_options)
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

                DD02T obj = new DD02T();

                obj.TABNAME = strArray[0];//表名
                obj.DDLANGUAGE = strArray[1];//语言代码
                obj.AS4LOCAL = strArray[2];//资源库对象的激活状态
                obj.AS4VERS = strArray[3];//表目的版本（版本） 
                obj.DDTEXT = strArray[4];//资源库对象的简短描述 
                dD02Ts.Add(obj);
            }
            return dD02Ts;
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
    public void getFirstDD02T(string TableName, string language)
    {

        List<String> DD02T_Columns = new List<string>();
        DD02T_Columns.Add("TABNAME");//表名
        DD02T_Columns.Add("DDLANGUAGE");//语言代码
        DD02T_Columns.Add("AS4LOCAL");//资源库对象的激活状态
        DD02T_Columns.Add("AS4VERS");//表目的版本（版本） 
        DD02T_Columns.Add("DDTEXT");//资源库对象的简短描述 

        List<String> DD02T_options = new List<string>();
        DD02T_options.Add("TABNAME = '" + TableName + "'");//表名 
        DD02T_options.Add("AND DDLANGUAGE = '" + language + "'");//语言

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD02T");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD02T_Columns != null && DD02T_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD02T_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD02T_options != null && DD02T_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD02T_options)
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
                this.AS4VERS = strArray[3];//表目的版本（版本） 
                this.DDTEXT = strArray[4];//资源库对象的简短描述 
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }

    private string tAbNAME;

    /// <summary>
    /// 表名
    /// </summary>
    public string TABNAME
    {
        get
        {
            if (string.IsNullOrEmpty(tAbNAME))
            {
                tAbNAME = "";
            }
            return tAbNAME;
        }
        set { tAbNAME = value; }
    }

    private string dDLANGUAGE;

    /// <summary>
    /// 语言代码
    /// </summary>
    public string DDLANGUAGE
    {
        get
        {
            if (string.IsNullOrEmpty(dDLANGUAGE))
            {
                dDLANGUAGE = "";
            }
            return dDLANGUAGE;
        }
        set { dDLANGUAGE = value; }
    }


    private string aS4LOCAL;

    /// <summary>
    /// 资源库对象的激活状态
    /// </summary>
    public string AS4LOCAL
    {
        get
        {
            if (string.IsNullOrEmpty(aS4LOCAL))
            {
                aS4LOCAL = "";
            }
            return aS4LOCAL;
        }
        set { aS4LOCAL = value; }
    }


    private string aS4VERS;

    /// <summary>
    /// 表目的版本（版本）
    /// </summary>
    public string AS4VERS
    {
        get
        {
            if (string.IsNullOrEmpty(aS4VERS))
            {
                aS4VERS = "";
            }
            return aS4VERS;
        }
        set { aS4VERS = value; }
    }

    private string dDTEXT;

    /// <summary>
    /// 资源库对象的简短描述
    /// </summary>
    public string DDTEXT
    {
        get
        {
            if (string.IsNullOrEmpty(dDTEXT))
            {
                dDTEXT = "";
            }
            return dDTEXT;
        }
        set { dDTEXT = value; }
    }

}

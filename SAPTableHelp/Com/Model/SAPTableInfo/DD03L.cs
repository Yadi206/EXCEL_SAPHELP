using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class DD03L
{
    public DD03L()
    {

    }

    public DD03L(string TableName)
    {
        getFirstDD03L(TableName);
    }


    /// <summary>
    /// 读取SAP中表字段属性
    /// </summary>
    /// <param name="TableName"></param>
    /// <returns></returns>
    public List<DD03L> getDD03Ls(string TableName)
    {
        List<DD03L> DD03Ls = new List<DD03L>();

        List<String> DD03L_Columns = new List<string>();
        DD03L_Columns.Add("TABNAME");//表名 
        DD03L_Columns.Add("POSITION");//表格中区域的位置 
        DD03L_Columns.Add("FIELDNAME");//字段名 
        DD03L_Columns.Add("KEYFLAG");//标识表格的关键字段 
        DD03L_Columns.Add("MANDATORY");//标记:要求输入字段(不为空) 
        DD03L_Columns.Add("ROLLNAME");//数据元素(语义域) 
        DD03L_Columns.Add("CHECKTABLE");//异型键表名检查 
        DD03L_Columns.Add("INTTYPE");//ABAP数据类型(C,D,N,...) 
        DD03L_Columns.Add("INTLEN");//内部长度（字节） 
        DD03L_Columns.Add("REFTABLE");//字段的参考表 
        DD03L_Columns.Add("PRECFIELD");//参考字段
        DD03L_Columns.Add("DATATYPE");//ABAP字典中的数据类型 
        DD03L_Columns.Add("LENG");//长度（字符数） 
        DD03L_Columns.Add("DECIMALS");//小数位数 
        DD03L_Columns.Add("DOMNAME");//定义域名 


        List<String> DD03L_options = new List<string>();
        DD03L_options.Add("TABNAME = '" + TableName + "'");//表名 
        DD03L_options.Add(" AND AS4LOCAL <> 'N'");//表名 



        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD03L");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD03L_Columns != null && DD03L_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD03L_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD03L_options != null && DD03L_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD03L_options)
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

                DD03L obj = new DD03L();

                obj.TABNAME = strArray[0];//表名 
                obj.POSITION = strArray[1];//表格中区域的位置 
                obj.FIELDNAME = strArray[2];//字段名 
                obj.KEYFLAG = strArray[3];//标识表格的关键字段 
                obj.MANDATORY = strArray[4];//标记:要求输入字段(不为空) 
                obj.ROLLNAME = strArray[5];//数据元素(语义域) 
                obj.CHECKTABLE = strArray[6];//异型键表名检查 
                obj.INTTYPE = strArray[7];//ABAP数据类型(C,D,N,...) 
                obj.INTLEN = strArray[8];//内部长度（字节） 
                obj.REFTABLE = strArray[9];//字段的参考表 
                obj.PRECFIELD = strArray[10];//字段的参考表  
                obj.DATATYPE = strArray[11];//ABAP字典中的数据类型 
                obj.LENG = strArray[12];//长度（字符数） 
                obj.DECIMALS = strArray[13];//小数位数 
                obj.DOMNAME = strArray[14];//定义域名 

                if (!string.IsNullOrEmpty(obj.FIELDNAME) && (obj.FIELDNAME.Replace(" ", "") == ".INCLU--AP" || obj.FIELDNAME.Replace(" ", "") == ".INCLUDE"))
                {
                    obj.ROLLNAME = obj.PRECFIELD;
                }

                DD03Ls.Add(obj);
            }
            return DD03Ls;
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
    public void getFirstDD03L(string TableName)
    {
        List<String> DD03L_Columns = new List<string>();
        DD03L_Columns.Add("TABNAME");//表名 
        DD03L_Columns.Add("POSITION");//表格中区域的位置 
        DD03L_Columns.Add("FIELDNAME");//字段名 
        DD03L_Columns.Add("KEYFLAG");//标识表格的关键字段 
        DD03L_Columns.Add("MANDATORY");//标记:要求输入字段(不为空) 
        DD03L_Columns.Add("ROLLNAME");//数据元素(语义域) 
        DD03L_Columns.Add("CHECKTABLE");//异型键表名检查 
        DD03L_Columns.Add("INTTYPE");//ABAP数据类型(C,D,N,...) 
        DD03L_Columns.Add("INTLEN");//内部长度（字节） 
        DD03L_Columns.Add("REFTABLE");//字段的参考表 
        DD03L_Columns.Add("PRECFIELD");//参考字段
        DD03L_Columns.Add("DATATYPE");//ABAP字典中的数据类型 
        DD03L_Columns.Add("LENG");//长度（字符数） 
        DD03L_Columns.Add("DECIMALS");//小数位数 
        DD03L_Columns.Add("DOMNAME");//定义域名 

        List<String> DD03L_options = new List<string>();
        DD03L_options.Add("TABNAME = '" + TableName + "'");//表名 
        DD03L_options.Add(" AND AS4LOCAL <> 'N'");//表名 

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD03L");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD03L_Columns != null && DD03L_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD03L_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD03L_options != null && DD03L_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD03L_options)
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
                this.POSITION = strArray[1];//表格中区域的位置 
                this.FIELDNAME = strArray[2];//字段名 
                this.KEYFLAG = strArray[3];//标识表格的关键字段 
                this.MANDATORY = strArray[4];//标记:要求输入字段(不为空) 
                this.ROLLNAME = strArray[5];//数据元素(语义域) 
                this.CHECKTABLE = strArray[6];//异型键表名检查 
                this.INTTYPE = strArray[7];//ABAP数据类型(C,D,N,...) 
                this.INTLEN = strArray[8];//内部长度（字节） 
                this.REFTABLE = strArray[9];//字段的参考表 
                this.PRECFIELD = strArray[10];//字段的参考表  
                this.DATATYPE = strArray[11];//ABAP字典中的数据类型 
                this.LENG = strArray[12];//长度（字符数） 
                this.DECIMALS = strArray[13];//小数位数 
                this.DOMNAME = strArray[14];//定义域名 
                if (!string.IsNullOrEmpty(this.FIELDNAME) && (this.FIELDNAME.Replace(" ", "") == ".INCLU--AP" || this.FIELDNAME.Replace(" ", "") == ".INCLUDE"))
                {
                    this.ROLLNAME = this.PRECFIELD;
                }
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
    private string pOSITION;

    /// <summary>
    /// 表格中区域的位置
    /// </summary>
    public string POSITION
    {
        get { return pOSITION; }
        set { pOSITION = value; }
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
    private string kEYFLAG;

    /// <summary>
    /// 标识表格的关键字段
    /// </summary>
    public string KEYFLAG
    {
        get { return kEYFLAG; }
        set { kEYFLAG = value; }
    }
    private string mANDATORY;

    /// <summary>
    /// 标记:要求输入字段(不为空)
    /// </summary>
    public string MANDATORY
    {
        get { return mANDATORY; }
        set { mANDATORY = value; }
    }
    private string rOLLNAME;

    /// <summary>
    /// 数据元素(语义域)
    /// </summary>
    public string ROLLNAME
    {
        get { return rOLLNAME; }
        set { rOLLNAME = value; }
    }
    private string cHECKTABLE;

    /// <summary>
    /// 异型键表名检查
    /// </summary>
    public string CHECKTABLE
    {
        get { return cHECKTABLE; }
        set { cHECKTABLE = value; }
    }
    private string iNTTYPE;

    /// <summary>
    /// ABAP数据类型(C,D,N,...)
    /// </summary>
    public string INTTYPE
    {
        get { return iNTTYPE; }
        set { iNTTYPE = value; }
    }
    private string iNTLEN;

    /// <summary>
    /// 内部长度（字节）
    /// </summary>
    public string INTLEN
    {
        get { return iNTLEN; }
        set { iNTLEN = value; }
    }
    private string rEFTABLE;

    /// <summary>
    /// 字段的参考表
    /// </summary>
    public string REFTABLE
    {
        get { return rEFTABLE; }
        set { rEFTABLE = value; }
    }

    private string pRECFIELD;

    /// <summary>
    /// 字段的参考字段
    /// </summary>
    public string PRECFIELD
    {
        get { return pRECFIELD; }
        set { pRECFIELD = value; }
    }

    private string dATATYPE;
    /// <summary>
    /// ABAP字典中的数据类型
    /// </summary>
    public string DATATYPE
    {
        get { return dATATYPE; }
        set { dATATYPE = value; }
    }
    private string lENG;

    /// <summary>
    /// 长度（字符数）
    /// </summary>
    public string LENG
    {
        get { return lENG; }
        set { lENG = value; }
    }
    private string dECIMALS;

    /// <summary>
    /// 小数位数
    /// </summary>
    public string DECIMALS
    {
        get { return dECIMALS; }
        set { dECIMALS = value; }
    }
    private string dOMNAME;

    /// <summary>
    /// 定义域名
    /// </summary>
    public string DOMNAME
    {
        get { return dOMNAME; }
        set { dOMNAME = value; }
    }


}

using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class DD08L
{
    public DD08L()
    {

    }

    public DD08L(string TableName)
    {
        getFirstDD08L(TableName);
    }


    /// <summary>
    /// 读取SAP中表字段属性
    /// </summary>
    /// <param name="TableName"></param>
    /// <returns></returns>
    public List<DD08L> getDD08Ls(string TableName)
    {
        List<DD08L> DD08Ls = new List<DD08L>();

        List<String> DD08L_Columns = new List<string>();
        DD08L_Columns.Add("TABNAME");//表名    

        List<String> DD08L_options = new List<string>();
        DD08L_options.Add("CHECKTABLE = '" + TableName + "'");//异型键表名检查 
        DD08L_options.Add(" AND FRKART = 'TEXT'");//异型键表名检查 
        DD08L_options.Add(" AND AS4LOCAL = 'A'");//异型键表名检查  

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD08L");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD08L_Columns != null && DD08L_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD08L_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD08L_options != null && DD08L_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD08L_options)
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

                DD08L obj = new DD08L();

                obj.TABNAME = strArray[0];//表名  

                DD08Ls.Add(obj);
            }
            return DD08Ls;
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
    public void getFirstDD08L(string TableName)
    {

        List<String> DD08L_Columns = new List<string>(); 
        DD08L_Columns.Add("TABNAME");//表名  

        List<String> DD08L_options = new List<string>();
        DD08L_options.Add("CHECKTABLE = '" + TableName + "'");//异型键表名检查 
        DD08L_options.Add(" AND FRKART = 'TEXT'");//异型键表名检查 
        DD08L_options.Add(" AND AS4LOCAL = 'A'");//异型键表名检查  

        try
        {
            //SysConfigInfo.SapRfcDestination
            //SysConfigInfo.SapRfcRepository
            int result = 0;
            IRfcFunction rfcFunction = SysConfigInfo.SapRfcRepository.CreateFunction("RFC_READ_TABLE");
            rfcFunction.SetValue("QUERY_TABLE", "DD08L");
            rfcFunction.SetValue("NO_DATA", " ");
            rfcFunction.SetValue("DELIMITER", "|");
            if (DD08L_Columns != null && DD08L_Columns.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("FIELDS");
                foreach (string item in DD08L_Columns)
                {
                    RfcTableMetadata tm1 = rfctColumns.Metadata;
                    RfcStructureMetadata sm1 = tm1.LineType;
                    IRfcStructure rfcs = sm1.CreateStructure();
                    rfcs.SetValue("FIELDNAME", item);
                    rfctColumns.Append(rfcs);
                }
            }

            if (DD08L_options != null && DD08L_options.Count > 0)
            {
                IRfcTable rfctColumns = rfcFunction.GetTable("OPTIONS");
                foreach (string item in DD08L_options)
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
     

}

 
using SAP.Middleware.Connector;
using System;
using System.Data;
using System.IO;
 

public static class SysConfigInfo
{ 
    public static string current_path = AppDomain.CurrentDomain.BaseDirectory;

    public static string config_file_path = Path.GetTempPath();
    //public static string config_file_path = Path.GetTempPath();

    public static string sqlite_path = current_path + "Excel_SapHelp.db";

	public static DataTable saploginfo = null;

    public static RfcDestination SapRfcDestination;

    public static RfcRepository SapRfcRepository;

    public static IRfcFunction myfun;

    public static RfcConfigParameters parms = new RfcConfigParameters();

    public static string sConnectFlag = ConnectFlag.未连接.ToString(); 
}
public enum ConnectFlag
{
    未连接 = 10,
    已连接 = 20
}

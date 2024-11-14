 
using System;
using System.Data;
using System.IO;
using SAP.Middleware.Connector;


public static class SysConfigInfo
{
    public static string current_path = AppDomain.CurrentDomain.BaseDirectory;
    public static string current_path_f32 = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\').TrimEnd('6').TrimEnd('8').TrimEnd('x');
    public static string current_path_f64 = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\').TrimEnd('4').TrimEnd('6').TrimEnd('x');
    public static string current_path_32 = AppDomain.CurrentDomain.BaseDirectory + @"x86\";
    public static string current_path_64 = AppDomain.CurrentDomain.BaseDirectory + @"x64\";

    public static string config_file_path = Path.GetTempPath();

    public static string sqlite_path = current_path_f32 + "Excel_SapHelp.db";
      

    public static DataTable saploginfo = null;
      
    public static RfcDestination SapRfcDestination;

    public static RfcRepository SapRfcRepository;

    public static IRfcFunction myfun;

    public static RfcConfigParameters parms = new RfcConfigParameters();
      
    public static string sConnectFlag = ConnectFlag.未连接.ToString();

    public static string sFunExist = "";
}
public enum ConnectFlag
{
    未连接 = 10,
    已连接 = 20
}

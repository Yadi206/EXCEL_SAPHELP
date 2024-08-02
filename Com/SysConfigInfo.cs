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

}

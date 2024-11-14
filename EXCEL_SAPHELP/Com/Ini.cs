using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
 

public class Ini
{
	private string sPath = null;

	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string section, string key, string def, byte[] retVal, int size, string filePath);

	public Ini(string path)
	{
		sPath = path;
	}

	public void Writue(string section, string key, string value)
	{
		WritePrivateProfileString(section, key, value, sPath);
	}

	public string ReadValue(string section, string key)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		int privateProfileString = GetPrivateProfileString(section, key, "", stringBuilder, 255, sPath);
		return stringBuilder.ToString();
	}

	public List<string> GetSectionNames(string filePath)
	{
		byte[] array = new byte[2048];
		StringBuilder stringBuilder = new StringBuilder(255);
		int privateProfileString = GetPrivateProfileString("Configuration", "", "", array, 999, filePath);
		string[] source = Encoding.Default.GetString(array, 0, privateProfileString).Split(new string[1] { "\0" }, StringSplitOptions.RemoveEmptyEntries);
		return source.ToList();
	}
}

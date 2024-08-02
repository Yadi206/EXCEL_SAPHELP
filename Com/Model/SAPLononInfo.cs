using System.Collections.Generic;
 

public class SAPLononInfo
{
	private List<SAPLJXX> sAPLJXXes;

	private List<SAPKJFS> sAPKJFSes;

	public List<SAPLJXX> SAPLJXXes
	{
		get
		{
			return sAPLJXXes;
		}
		set
		{
			sAPLJXXes = value;
		}
	}

	public List<SAPKJFS> SAPKJFSes
	{
		get
		{
			return sAPKJFSes;
		}
		set
		{
			sAPKJFSes = value;
		}
	}

	public SAPLononInfo()
	{
		sAPLJXXes = new List<SAPLJXX>();
		SAPKJFSes = new List<SAPKJFS>();
	}
}

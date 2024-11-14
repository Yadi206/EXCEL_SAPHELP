public class ShaiXuan
{
	private string _ZiDuan = "";

	private string _Zhi = "";

	public string ZiDuan
	{
		get
		{
			return _ZiDuan;
		}
		set
		{
			_ZiDuan = value;
		}
	}

	public string Zhi
	{
		get
		{
			return _Zhi;
		}
		set
		{
			_Zhi = value;
		}
	}

	public ShaiXuan(string sZiDuan, string sZhi)
	{
		ZiDuan = sZiDuan;
		Zhi = sZhi;
	}
}

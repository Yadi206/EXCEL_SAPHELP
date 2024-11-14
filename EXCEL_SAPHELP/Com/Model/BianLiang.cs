public class BianLiang
{
	private object _DuiXiang = new object();

	private string _LeiXing = "";

	public object DuiXiang
	{
		get
		{
			return _DuiXiang;
		}
		set
		{
			_DuiXiang = value;
		}
	}

	public string LeiXing
	{
		get
		{
			return _LeiXing;
		}
		set
		{
			_LeiXing = value;
		}
	}

	public BianLiang(object sDuiXiang, string sLeiXing)
	{
		_DuiXiang = sDuiXiang;
		_LeiXing = sLeiXing;
	}
}

 

public class SAPKJFS
{
	public string uuid { get; set; }

	public string name { get; set; }

	public string description { get; set; }

	public string systemid { get; set; }

	public string client { get; set; }

	public string user { get; set; }

	public string language { get; set; }

	public string work_dir { get; set; }

	public string link { get; set; }

	public string shortcut { get; set; }

	public string reuse { get; set; }

	public SAPLJXX ljxx { get; set; }

	public SAPKJFS()
	{
		uuid = "";
		name = "";
		description = "";
		systemid = "";
		client = "";
		user = "";
		language = "";
		work_dir = "";
		link = "";
		shortcut = "";
		reuse = "";
		ljxx = new SAPLJXX();
	}
}

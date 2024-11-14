using System.Collections.Generic;
 
public class MiMaHang
{
	public string WeiZhi { get; set; }

	public List<MiMa> MiMas { get; set; }

	public MiMaHang()
	{
		WeiZhi = "";
		MiMas = new List<MiMa>();
	}
}

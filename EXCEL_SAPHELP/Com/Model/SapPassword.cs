using System.Collections.Generic;

 

public class SapPassword
{
	public List<MiMaHang> MiMaBiao = new List<MiMaHang>();

	public SapPassword()
	{
		MiMaHang miMaHang = new MiMaHang();
		MiMa miMa = new MiMa();
		miMaHang.WeiZhi = "1";
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "2"
		};
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "3"
		};
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "4"
		};
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "5"
		};
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "6"
		};
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "7"
		};
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "8"
		};
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "9"
		};
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "10"
		};
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "11"
		};
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "12"
		};
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "13"
		};
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "14"
		};
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "15"
		};
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "16"
		};
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "17"
		};
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "18"
		};
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "19"
		};
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "20"
		};
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "21"
		};
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "22"
		};
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang.WeiZhi = "23";
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "24"
		};
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "25"
		};
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "26"
		};
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "27"
		};
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "28"
		};
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "29"
		};
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "30"
		};
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "31"
		};
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "32"
		};
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "33"
		};
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "34"
		};
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "35"
		};
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "36"
		};
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "37"
		};
		miMa = new MiMa
		{
			MiWen = "53",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "52",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "51",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "50",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "57",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "56",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "55",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "54",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5B",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5A",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "59",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "58",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5F",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5E",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5D",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "5C",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "43",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "42",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "41",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "40",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "47",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "46",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "45",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "44",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4B",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4A",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "49",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "48",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4F",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4E",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4D",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "4C",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "73",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "72",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "71",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "70",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "77",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "76",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "75",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "74",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7B",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7A",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "79",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "78",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7F",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7E",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7D",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "7C",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "63",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "62",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "61",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "60",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "67",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "66",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "65",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "64",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6B",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6A",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "69",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "68",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6F",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6E",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6D",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "6C",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "13",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "12",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "11",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "10",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "17",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "16",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "15",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "14",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1B",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1A",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "19",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "18",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1F",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1E",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1D",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "1C",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "03",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "02",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "01",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "00",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "07",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "06",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "05",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "04",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0B",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0A",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "09",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "08",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0F",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0E",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0D",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "0C",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "33",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "32",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "31",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "30",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "37",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "36",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "35",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "34",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3B",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3A",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "39",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "38",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3F",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3E",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3D",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "3C",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "23",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "22",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "21",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "20",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "27",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "26",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "25",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "24",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2B",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2A",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "29",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "28",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2F",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2E",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2D",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "2C",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "38"
		};
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang
		{
			WeiZhi = "39"
		};
		miMa = new MiMa
		{
			MiWen = "98",
			MingWen = "NUL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "99",
			MingWen = "SOH"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9A",
			MingWen = "STX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9B",
			MingWen = "ETX"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9C",
			MingWen = "EOT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9D",
			MingWen = "ENQ"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9E",
			MingWen = "ACK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "9F",
			MingWen = "BEL"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "90",
			MingWen = "BS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "91",
			MingWen = "HT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "92",
			MingWen = "LF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "93",
			MingWen = "VT"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "94",
			MingWen = "FF"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "95",
			MingWen = "CR"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "96",
			MingWen = "SO"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "97",
			MingWen = "SI"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "88",
			MingWen = "DLE"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "89",
			MingWen = "DC1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8A",
			MingWen = "DC2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8B",
			MingWen = "DC3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8C",
			MingWen = "DC4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8D",
			MingWen = "NAK"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8E",
			MingWen = "SYN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "8F",
			MingWen = "ETB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "80",
			MingWen = "CAN"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "81",
			MingWen = "EM"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "82",
			MingWen = "SUB"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "83",
			MingWen = "ESC"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "84",
			MingWen = "FS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "85",
			MingWen = "GS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "86",
			MingWen = "RS"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "87",
			MingWen = "US"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B8",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B9",
			MingWen = "!"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BA",
			MingWen = "\""
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BB",
			MingWen = "#"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BC",
			MingWen = "$"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BD",
			MingWen = "%"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BE",
			MingWen = "&"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "BF",
			MingWen = "'"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B0",
			MingWen = "("
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B1",
			MingWen = ")"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B2",
			MingWen = "*"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B3",
			MingWen = "+"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B4",
			MingWen = ","
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B5",
			MingWen = "-"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B6",
			MingWen = "."
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "B7",
			MingWen = "/"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A8",
			MingWen = "0"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A9",
			MingWen = "1"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AA",
			MingWen = "2"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AB",
			MingWen = "3"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AC",
			MingWen = "4"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AD",
			MingWen = "5"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AE",
			MingWen = "6"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "AF",
			MingWen = "7"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A0",
			MingWen = "8"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A1",
			MingWen = "9"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A2",
			MingWen = ":"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A3",
			MingWen = ";"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A4",
			MingWen = "<"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A5",
			MingWen = "="
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A6",
			MingWen = ">"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "A7",
			MingWen = "?"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D8",
			MingWen = "@"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D9",
			MingWen = "A"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DA",
			MingWen = "B"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DB",
			MingWen = "C"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DC",
			MingWen = "D"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DD",
			MingWen = "E"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DE",
			MingWen = "F"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "DF",
			MingWen = "G"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D0",
			MingWen = "H"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D1",
			MingWen = "I"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D2",
			MingWen = "J"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D3",
			MingWen = "K"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D4",
			MingWen = "L"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D5",
			MingWen = "M"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D6",
			MingWen = "N"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "D7",
			MingWen = "O"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C8",
			MingWen = "P"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C9",
			MingWen = "Q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CA",
			MingWen = "R"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CB",
			MingWen = "S"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CC",
			MingWen = "T"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CD",
			MingWen = "U"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CE",
			MingWen = "V"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "CF",
			MingWen = "W"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C0",
			MingWen = "X"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C1",
			MingWen = "Y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C2",
			MingWen = "Z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C3",
			MingWen = "["
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C4",
			MingWen = "\\"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C5",
			MingWen = "]"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C6",
			MingWen = "^"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "C7",
			MingWen = "_"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F8",
			MingWen = "`"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F9",
			MingWen = "a"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FA",
			MingWen = "b"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FB",
			MingWen = "c"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FC",
			MingWen = "d"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FD",
			MingWen = "e"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FE",
			MingWen = "f"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "FF",
			MingWen = "g"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F0",
			MingWen = "h"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F1",
			MingWen = "i"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F2",
			MingWen = "j"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F3",
			MingWen = "k"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F4",
			MingWen = "l"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F5",
			MingWen = "m"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F6",
			MingWen = "n"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "F7",
			MingWen = "o"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E8",
			MingWen = "p"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E9",
			MingWen = "q"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EA",
			MingWen = "r"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EB",
			MingWen = "s"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EC",
			MingWen = "t"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "ED",
			MingWen = "u"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EE",
			MingWen = "v"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "EF",
			MingWen = "w"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E0",
			MingWen = "x"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E1",
			MingWen = "y"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E2",
			MingWen = "z"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E3",
			MingWen = "{"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E4",
			MingWen = "|"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E5",
			MingWen = "}"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E6",
			MingWen = "~"
		};
		miMaHang.MiMas.Add(miMa);
		miMa = new MiMa
		{
			MiWen = "E7",
			MingWen = ""
		};
		miMaHang.MiMas.Add(miMa);
		MiMaBiao.Add(miMaHang);
		miMaHang = new MiMaHang();
	}

	public string getMiWen(string strPas)
	{
		string text = "";
		if (string.IsNullOrEmpty(strPas))
		{
			return text;
		}
		for (int i = 1; i <= strPas.Length; i++)
		{
			string weizhi = i.ToString();
			string mingwen = strPas.Substring(i - 1, 1);
			string miWen = MiMaBiao.Find((MiMaHang x) => x.WeiZhi == weizhi).MiMas.Find((MiMa y) => y.MingWen == mingwen).MiWen;
			text += miWen;
		}
		return "PW_" + text;
	}

	public string getMingWen(string strPas)
	{
		string text = "";
		if (string.IsNullOrEmpty(strPas))
		{
			return text;
		}
		if (strPas.Length > 3 && strPas.Substring(0, 3) == "PW_")
		{
			strPas = strPas.Substring(3, strPas.Length - 3);
		}
		for (int i = 2; i <= strPas.Length; i += 2)
		{
			string weizhi = (i / 2).ToString();
			string miwen = strPas.Substring(i - 2, 2);
			string mingWen = MiMaBiao.Find((MiMaHang x) => x.WeiZhi == weizhi).MiMas.Find((MiMa y) => y.MiWen == miwen).MingWen;
			text += mingWen;
		}
		return text;
	}
}

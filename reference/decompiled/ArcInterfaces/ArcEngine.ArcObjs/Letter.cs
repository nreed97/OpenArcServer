using System;
using System.Xml.Serialization;

namespace ArcEngine.ArcObjs;

[Serializable]
public sealed class Letter
{
	public long MsgNum { get; set; }

	public string To { get; set; }

	public string From { get; set; }

	public string ToNode { get; set; }

	public string FromNode { get; set; }

	public bool ReadFlag { get; set; }

	public bool PvtFlag { get; set; }

	public bool RtnRcptFlag { get; set; }

	public string Subject { get; set; }

	public string Body { get; set; }

	public long Size { get; set; }

	public DateTime Dts { get; set; }

	public string Status { get; set; }

	public string ToHomeNode { get; set; }

	[XmlIgnore]
	public int Attempts { get; set; }

	[XmlIgnore]
	public static string Date => string.Empty;

	[XmlIgnore]
	public static string Time => string.Empty;

	[XmlIgnore]
	public string Unknown1 { get; set; }

	[XmlIgnore]
	public string Unknown2 { get; set; }

	public Letter()
	{
		Unknown2 = string.Empty;
		Unknown1 = string.Empty;
		ToHomeNode = string.Empty;
		Status = string.Empty;
		Dts = DateTime.MinValue;
		Body = string.Empty;
		Subject = string.Empty;
		FromNode = string.Empty;
		ToNode = string.Empty;
		From = string.Empty;
		To = string.Empty;
	}
}

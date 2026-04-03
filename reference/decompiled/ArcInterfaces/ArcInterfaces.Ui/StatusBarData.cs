using System;

namespace ArcInterfaces.Ui;

public sealed class StatusBarData
{
	public TimeSpan Uptime { get; set; }

	public int DxRate { get; set; }

	public int NodeCnt { get; set; }

	public int UserCnt { get; set; }

	public bool AlertDxRate { get; set; }

	public bool AlertNodeCnt { get; set; }

	public bool AlertUserCnt { get; set; }
}

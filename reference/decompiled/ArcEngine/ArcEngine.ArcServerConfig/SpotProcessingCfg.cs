using System;
using System.ComponentModel;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using Common.Logging;
using Ⴈ;

namespace ArcEngine.ArcServerConfig;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class SpotProcessingCfg
{
	private static readonly ILog Ⴄ = NodeUserCmd.Ⴗ(ReplyMail.Ⴅ(6, 5, 1217942139), 565, 600);

	private int Ⴀ;

	private int Ⴈ;

	private ulong Ⴄ;

	private bool Ⴄ;

	private qslinfoRequest.Ⴈ Ⴅ = new qslinfoRequest.Ⴈ();

	[Description("Maximum number of announce spots that can be displayed to the user")]
	public int MaxNmbrAnnSpots
	{
		get
		{
			int ⴈ = Ⴅ.Ⴈ;
			IpLockoutCacheCfg.ႭႭ[28] = (char)((IpLockoutCacheCfg.ႭႭ[28] * SetTalkCountHelp.Ⴅ[172]) & 0xE6);
			return ⴈ;
		}
		set
		{
			Ⴅ.Ⴈ = value;
			SetDxCountHelp.ႭႤ[25] = (SetDxCountHelp.ႭႤ[25] - ShowSunHelp.ႣႠ[286]) & 0x75;
		}
	}

	[Description("Maximum number of DX spots that can be displayed to the user")]
	public int MaxNmbrDxSpots
	{
		get
		{
			byte[] ⴄႭ = SetAnnMode.ႤႭ;
			return Ⴀ;
		}
		set
		{
			Ⴀ = value;
		}
	}

	[Description("Maximum number of Talk spots that can be displayed to the user")]
	public int MaxNmbrTalkSpots
	{
		get
		{
			int ⴈ = Ⴈ;
			BandModeCacheCfg.ႠႳ[220] = (char)((BandModeCacheCfg.ႠႳ[220] ^ BandModeCacheCfg.ႠႳ[324]) & 0x16);
			return ⴈ;
		}
		set
		{
			Ⴈ = value;
		}
	}

	[Description("Maximum number of WWV spots that can be displayed to the user")]
	public int MaxNmbrWwvSpots
	{
		get
		{
			return Ⴅ.Ⴄ;
		}
		set
		{
			Ⴅ.Ⴄ = value;
			ShowQrzHelp.ႤႤ[304] = (byte)((ShowQrzHelp.ႤႤ[304] ^ value) & 0x7C);
		}
	}

	[Description("Maximum number of WX spots that can be displayed to the user")]
	public int MaxNmbrWxSpots
	{
		get
		{
			return Ⴅ.Ⴀ;
		}
		set
		{
			Ⴅ.Ⴀ = value;
		}
	}

	[ReadOnly(true)]
	[Description("Number of DX spots processed by the node")]
	public ulong DxSpotCount
	{
		get
		{
			return this.Ⴄ;
		}
		set
		{
			this.Ⴄ = value;
		}
	}

	[Description("Enable CT1BOH Skimmer Spot Processing")]
	public bool EnableCt1bohProcessing
	{
		get
		{
			return Ⴄ;
		}
		set
		{
			Ⴄ = value;
		}
	}

	public SpotProcessingCfg()
	{
		MaxNmbrWxSpots = 100;
		MaxNmbrWwvSpots = 100;
		MaxNmbrTalkSpots = 100;
		MaxNmbrDxSpots = 100;
		MaxNmbrAnnSpots = 100;
		EnableCt1bohProcessing = true;
	}

	public void LoadDefaults()
	{
	}

	public override string ToString()
	{
		return ႰႥ.Ⴅ(5, 'Ï', 952621837);
	}

	public void BumpDxSpotCount()
	{
		try
		{
			DxSpotCount++;
		}
		catch (Exception ex)
		{
			SpotProcessingCfg.Ⴄ.Error(SkimmerSpotBins.Ⴈ(ex, 996, 970));
		}
	}
}

using System;
using System.ComponentModel;
using System.Security;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wx;
using ArcInterfaces.Spots;

namespace ArcEngine.ArcServerConfig.Caches;

[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class NodeCacheCfg
{
	private bool Ⴃ;

	private int Ⴍ;

	[Description("Flag to activate the automatic compacting of the database")]
	public bool AutoDbCompact
	{
		get
		{
			return Ⴃ;
		}
		set
		{
			Ⴃ = value;
		}
	}

	[Description("Number of years of data to keep in the database after purge operations")]
	public int DbYears
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = value;
		}
	}

	public NodeCacheCfg()
	{
		AutoDbCompact = true;
		DbYears = 3;
	}

	public override string ToString()
	{
		return ReplyMailHelp.Ⴄ(25, null, 1057162180, 8);
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, DateTime P_1, int P_2, short P_3) where _0021_00210 : DxSpot
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႰ[6] - 7768;
				break;
			case 8:
				num = (((P_2 ^ P_3) - 7) ^ num3) switch
				{
					0 => 1, 
					_ => 9, 
				};
				break;
			case 9:
				num = 6;
				break;
			case 1:
				P_0.DtsRx = P_1;
				goto case 3;
			case 3:
			case 6:
				num3++;
				goto case 7;
			case 7:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				goto case 4;
			case 4:
				num = 0;
				break;
			case 0:
				num = ((num2 % 2 != 0) ? 8 : (ⴀႨ[53] - 8348));
				break;
			case 2:
				return;
			}
		}
	}
}

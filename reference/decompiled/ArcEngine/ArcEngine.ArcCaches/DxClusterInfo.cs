using System;
using System.Runtime.CompilerServices;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcCaches;

public class DxClusterInfo
{
	private static readonly ILog m_Ⴅ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687352304, 5, 3), 1014, 1003);

	private SetStationBeepHelp.Ⴍ m_Ⴈ = new SetStationBeepHelp.Ⴍ();

	[SpecialName]
	internal string Ⴐ()
	{
		return this.m_Ⴈ.Ⴐ;
	}

	[SpecialName]
	internal void Ⴗ(string P_0)
	{
		this.m_Ⴈ.Ⴐ = P_0;
		SetWxOutput.ႣႰ[194] = (char)((SetWxOutput.ႣႰ[194] ^ TxNodeUserCmd.ႤႷ[111]) & 0x78);
	}

	[SpecialName]
	internal string Ⴓ()
	{
		string ⴅ = this.m_Ⴈ.Ⴅ;
		ShowQrzHelp.ႤႤ[116] = (byte)((ShowQrzHelp.ႤႤ[116] - BandModeCacheCfg.ႠႳ[258]) & 0x9A);
		return ⴅ;
	}

	[SpecialName]
	internal void Ⴍ(string P_0)
	{
		this.m_Ⴈ.Ⴅ = P_0;
		AnnCacheCfg.ႠႼ[73] = (byte)((AnnCacheCfg.ႠႼ[73] | AnnCacheCfg.ႠႼ[129]) & 0xF2);
	}

	[SpecialName]
	internal string Ⴍ()
	{
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		return this.m_Ⴈ.Ⴃ;
	}

	[SpecialName]
	internal void Ⴈ(string P_0)
	{
		this.m_Ⴈ.Ⴃ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴅ()
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		return this.m_Ⴈ.Ⴈ;
	}

	[SpecialName]
	internal void Ⴃ(string P_0)
	{
		this.m_Ⴈ.Ⴈ = P_0;
	}

	public static DxClusterInfo GetDxClusterInfo(string line)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		object obj4 = default(object);
		try
		{
			int num = 3;
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = ((CallBlockCacheCfg.Ⴜ(line, 680, 713) <= 0) ? (ⴀႳ[179] - 2232) : 4);
					continue;
				case 4:
					line = ShowContestStationHelp.Ⴅ(line, ႨႨ.Ⴀ(8, 8, 1157904262), string.Empty, 756, 'ʬ');
					num = 6;
					continue;
				case 6:
				{
					obj = new DxClusterInfo();
					string text = line;
					object obj3 = new char[1];
					(obj3 as char[])[0] = ',';
					obj2 = Directory.Ⴓ(text, obj3 as char[], 861, 779);
					num = ⴀႳ[135] - 41062;
					continue;
				}
				case 0:
				case 5:
					num = ((((string[])obj2).Length != 4) ? (ⴍႭ[336] - 32773) : (ⴃႰ[201] - 21668));
					continue;
				case 7:
					(obj as DxClusterInfo).Ⴗ((obj2 as string[])[0]);
					goto case 1;
				case 1:
					(obj as DxClusterInfo).Ⴍ((obj2 as string[])[1]);
					num = ⴃႠ[177] - 5201;
					continue;
				case 2:
					(obj as DxClusterInfo).Ⴈ((obj2 as string[])[2]);
					(obj as DxClusterInfo).Ⴃ((obj2 as string[])[3]);
					break;
				case 11:
					break;
				case 9:
					goto end_IL_001f;
				}
				obj4 = obj as DxClusterInfo;
				goto IL_021d;
				continue;
				end_IL_001f:
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴅ = DxClusterInfo.m_Ⴅ;
			object obj5 = new object[4];
			((object[])obj5)[0] = CallBlockCacheCfg.Ⴅ(null, 3, 62056571, null);
			((object[])obj5)[1] = line;
			(obj5 as object[])[2] = ႰႥ.Ⴅ(7, 'Ê', 952620213);
			(obj5 as object[])[3] = ex;
			ⴅ.Warn(string.Concat((object[])obj5));
		}
		switch (5)
		{
		default:
			return null;
		case 0:
		case 1:
			break;
		}
		goto IL_021d;
		IL_021d:
		return (DxClusterInfo)obj4;
	}
}

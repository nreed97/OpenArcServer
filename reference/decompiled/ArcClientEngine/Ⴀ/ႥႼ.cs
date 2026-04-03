using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Io;
using ArcShared.ArcUtils;
using log4net;

namespace Ⴀ;

internal sealed class ႥႼ
{
	private static readonly ILog m_Ⴃ;

	private static int m_Ⴗ;

	private ArcClientObjMgr m_Ⴍ;

	private string m_Ⴈ;

	private bool m_Ⴍ;

	private IIoClient m_Ⴍ;

	private DxCommentExtCfg m_Ⴐ;

	private ႥႠ.ႭႷ m_Ⴓ;

	[SpecialName]
	internal ArcClientObjMgr Ⴃ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		return this.m_Ⴍ;
	}

	[SpecialName]
	internal void Ⴓ(ArcClientObjMgr P_0)
	{
		this.m_Ⴍ = P_0;
	}

	[SpecialName]
	internal string Ⴅ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		return this.m_Ⴓ.Ⴅ;
	}

	[SpecialName]
	internal void Ⴃ(string P_0)
	{
		this.m_Ⴓ.Ⴅ = P_0;
	}

	[SpecialName]
	internal string Ⴓ()
	{
		string ⴄ = this.m_Ⴓ.Ⴄ;
		UserCmd.Ⴅ[386] = (byte)((UserCmd.Ⴅ[386] | UserCmd.Ⴅ[181]) & 0x25);
		return ⴄ;
	}

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		this.m_Ⴓ.Ⴄ = P_0 as string;
	}

	[SpecialName]
	internal string Ⴍ()
	{
		string ⴗ = this.m_Ⴓ.Ⴗ;
		ႥႰ.Ⴗ[139] = (char)(ႥႰ.Ⴗ[139] & ႥႰ.Ⴗ[44] & 0x7D);
		return ⴗ;
	}

	[SpecialName]
	internal void Ⴀ(string P_0)
	{
		this.m_Ⴓ.Ⴗ = P_0;
	}

	[SpecialName]
	internal string Ⴐ()
	{
		char[] ⴄ = Bye.Ⴄ;
		string ⴈ = this.m_Ⴓ.Ⴈ;
		HighlightCtyCfg.ႠႠ[3] = (char)(HighlightCtyCfg.ႠႠ[3] & Bye.Ⴄ[79] & 0xCB);
		return ⴈ;
	}

	[SpecialName]
	internal void Ⴅ(string P_0)
	{
		this.m_Ⴓ.Ⴈ = P_0 as string;
		ႥႰ.Ⴗ[67] = (char)((ႥႰ.Ⴗ[67] - HighlightCtyCfg.ႠႠ[5]) & 0x73);
	}

	[SpecialName]
	internal string Ⴗ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		return this.m_Ⴈ;
	}

	[SpecialName]
	internal void Ⴐ(string P_0)
	{
		this.m_Ⴈ = P_0;
	}

	[SpecialName]
	internal bool Ⴀ()
	{
		return this.m_Ⴍ;
	}

	[SpecialName]
	internal void Ⴈ(bool P_0)
	{
		this.m_Ⴍ = P_0;
	}

	[SpecialName]
	internal IIoClient Ⴈ()
	{
		return this.m_Ⴍ;
	}

	[SpecialName]
	internal void Ⴍ(IIoClient P_0)
	{
		this.m_Ⴍ = P_0;
	}

	[SpecialName]
	internal DxCommentExtCfg Ⴄ()
	{
		return this.m_Ⴐ;
	}

	[SpecialName]
	internal void Ⴜ(DxCommentExtCfg P_0)
	{
		this.m_Ⴐ = P_0;
	}

	internal ႥႼ(string P_0, ArcClientObjMgr P_1)
	{
		Ⴅ(P_0);
		Ⴓ(P_1);
		Ⴐ(ႥႭ.ႳႭ((object)ႥႥ.Ⴅ(1673506969, null, 0), (object)(++ႥႼ.m_Ⴗ), (short)765, 720));
		Ⴃ(TelnetServerCfg.Ⴗ(P_1.Cfg.Filters.Dx.DefaultFilter, SqlFilterType.Dx, '\u02d6', 756));
		Ⴄ(TelnetServerCfg.Ⴗ(P_1.Cfg.Filters.Ann.DefaultFilter, SqlFilterType.AnnWx, '\u0345', 871));
		Ⴀ(UtilsSql.FormatSqlFilter(P_1.Cfg.Filters.Wx.DefaultFilter, SqlFilterType.AnnWx));
		Ⴜ(new DxCommentExtCfg());
	}

	internal void ႳႷ(string P_0)
	{
		Ⴈ().Send(DxFilters.Ⴈ(P_0, ClientCty.Ⴗ('ð', 2, 307011830), 837, 797));
		UserCmd.Ⴅ[218] = (byte)((UserCmd.Ⴅ[218] - UserCmd.Ⴅ[391]) & 0x39);
	}

	public void ႳႳ(string P_0)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 5;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = HighlightArrlSectionCfg.Ⴀ(P_0, ClientCty.Ⴗ('c', 1, 307011822), string.Empty, 'ɐ', 603);
				num = ⴗ[114] - 15473;
				break;
			case 2:
			case 6:
				if (!Ⴀ())
				{
					char num2 = ⴀႠ[103];
					ႥႰ.Ⴗ[157] = (char)((ႥႰ.Ⴗ[157] | ႥႰ.Ⴗ[24]) & 0x5F);
					num = num2 - 38472;
					break;
				}
				Ⴃ().Ⴀ().Ⴍ(P_0, this);
				return;
			case 7:
				convertible = ShowDxFilter.Ⴍ(FilterViewer.ႨႷ(P_0, 11, 39), 'N', 99);
				num = ⴗ[37] - 54918;
				break;
			case 3:
				convertible = HighlightCfg.ႳႳ(convertible as string, 'Δ', 1018);
				if (DxSpotRates.ႠႼ((string)convertible, 'ƣ', 'ƿ'))
				{
					num = ⴅ[115];
					break;
				}
				ႳႷ(ႥႥ.Ⴅ(1673507660, null, 3));
				return;
			case 4:
				Ⴐ(convertible as string);
				Ⴈ(true);
				goto case 8;
			case 8:
				ႳႤ(ႥႥ.Ⴅ(1673506962, null, 1));
				num = ⴀႠ[90] - 47371;
				break;
			case 0:
				ႥႣ();
				return;
			case 1:
				return;
			}
		}
	}

	public void ႳႣ(string P_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				ႳႷ(DxFilters.Ⴈ(ႥႥ.Ⴅ(1673507681, null, 3), Ⴐ(), 736, 696));
				goto IL_0043;
			case 1:
			case 2:
				goto IL_0043;
			case 0:
				UserInfo.ႥႷ(100, 450, 479);
				break;
			case 3:
				break;
			}
			break;
			IL_0043:
			num = 0;
		}
		Ⴈ().Disconnect();
		Ⴃ().Io.TelnetServer.Ⴈ().Remove(this);
	}

	public void Ⴜ()
	{
		ႳႤ(ႥႥ.Ⴍ(6, 1580608292, '¬', null));
	}

	private void ႳႤ(string P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		try
		{
			int num = 10;
			IEnumerable<char> enumerable = default(IEnumerable<char>);
			TextReader textReader = default(TextReader);
			IComparable<string> comparable = default(IComparable<string>);
			while (true)
			{
				switch (num)
				{
				default:
				{
					object obj = WxFilters.ႭႭ(712, 739);
					enumerable = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ(obj as Assembly, 159, 163), '\u0313', 895), P_0, 303, 375);
					goto case 4;
				}
				case 4:
				case 8:
					num = 3;
					continue;
				case 3:
				case 5:
				{
					Stream stream = new FileStream((string)enumerable, FileMode.Open, FileAccess.Read);
					textReader = new StreamReader(stream as FileStream);
					num = ⴅ[75] - 236;
					continue;
				}
				case 2:
					comparable = HighlightItuZoneCfg.Ⴜ((TextReader)(StreamReader)textReader, (short)68, (short)17);
					num = ⴄ[110] - 60795;
					continue;
				case 0:
					num = (ႥႤ.Ⴍ(comparable as string, WxFilters.Ⴀ(null, 5, 103387684), 276, 302) ? (ⴄ[174] - 46410) : (ⴅ[215] - ⴅ[138]));
					continue;
				case 11:
					ႳႷ(ႳႠ(comparable as string));
					goto case 9;
				case 9:
					comparable = (textReader as StreamReader).ReadLine();
					num = 1;
					continue;
				case 1:
				{
					int num3;
					if ((string)comparable == null)
					{
						char num2 = ⴗ[59];
						Bye.Ⴄ[42] = (char)((Bye.Ⴄ[42] ^ ႥႰ.Ⴗ[93]) & 0x9E);
						num3 = num2 - 33048;
					}
					else
					{
						num3 = ⴅ[17];
					}
					num = num3;
					continue;
				}
				case 7:
					(textReader as StreamReader).Close();
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ႥႼ.m_Ⴃ.Error(ex.Message);
		}
		switch (1)
		{
		}
	}

	public string ႳႠ(string P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			P_0 = HighlightArrlSectionCfg.Ⴀ(P_0, ClientCty.Ⴗ('\u001d', 5, 307011822), ClientCty.Ⴗ('Ð', 1, 307011829), 'α', 954);
			while (true)
			{
				IL_006d:
				int num = 4;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 2;
						continue;
					case 2:
						break;
					case 5:
						goto IL_006d;
					case 4:
						P_0 = HighlightArrlSectionCfg.Ⴀ(P_0, WxFilters.Ⴀ(null, 7, 103388427), HighlightCountyCfg.ႷႥ('ğ', 335), '\u0338', 819);
						goto case 1;
					case 1:
						num = 6;
						continue;
					case 6:
						P_0 = HighlightArrlSectionCfg.Ⴀ(P_0, ႥႥ.Ⴍ(8, 1580608463, '\u001c', null), Ⴗ(), '{', 112);
						num = ⴅ[0] - ⴅ[106];
						continue;
					case 7:
					case 8:
						P_0 = P_0.Replace(ႥႥ.Ⴅ(1673507704, null, 2), Ⴐ());
						num = 3;
						continue;
					case 3:
						return P_0;
					}
					break;
				}
				break;
			}
		}
	}

	public void ႥႣ()
	{
		IEnumerable enumerable = AnnFilters.ႰႥ(Ⴗ(), Ⴐ(), 'R', 63);
		ႳႷ(enumerable as string);
	}

	[SecuritySafeCritical]
	static ႥႼ()
	{
		ArcClientConnectDat.Ⴍ();
		ႥႼ.m_Ⴃ = HighlightItuZoneCfg.Ⴓ(WxFilters.Ⴀ(null, 1, 103388478), 703, 655);
	}
}

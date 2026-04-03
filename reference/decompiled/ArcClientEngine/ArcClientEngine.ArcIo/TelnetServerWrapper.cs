using System;
using System.Collections;
using System.Collections.Generic;
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
using ArcInterfaces.Spots;
using ArcShared;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcIo;

public sealed class TelnetServerWrapper : TelnetServer
{
	private static readonly ILog m_Ⴍ;

	private string m_Ⴅ;

	private List<ႥႼ> m_Ⴈ;

	private HighlightStateCfg.Ⴄ m_Ⴀ = new HighlightStateCfg.Ⴄ();

	[SpecialName]
	private ArcClientObjMgr Ⴄ()
	{
		return this.m_Ⴀ.Ⴓ;
	}

	[SpecialName]
	private void Ⴅ(ArcClientObjMgr P_0)
	{
		this.m_Ⴀ.Ⴓ = P_0 as ArcClientObjMgr;
	}

	[SpecialName]
	internal string Ⴐ()
	{
		char[] ⴄ = Bye.Ⴄ;
		return this.m_Ⴅ;
	}

	[SpecialName]
	internal void Ⴄ(string P_0)
	{
		this.m_Ⴅ = P_0;
	}

	[SpecialName]
	internal List<ႥႼ> Ⴈ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		return this.m_Ⴈ;
	}

	[SpecialName]
	internal void Ⴈ(List<ႥႼ> P_0)
	{
		this.m_Ⴈ = P_0;
	}

	public TelnetServerWrapper(ServerIoCfg serverDevice, string hostCall, ArcClientObjMgr om)
		: base(serverDevice)
	{
		Ⴅ(om);
		base.OnConnectEvent += Ⴃ;
		Ⴈ(new List<ႥႼ>());
		base.EofChar = ႥႥ.Ⴍ(3, 1580609502, 'Ü', null);
		Ⴄ(hostCall);
	}

	private void Ⴃ(IIoClient P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 2;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new ႥႼ(Ⴐ(), Ⴄ());
				(obj as ႥႼ).Ⴍ(P_0);
				num = 3;
				break;
			case 0:
			case 3:
				P_0.OnRxEvent += (obj as ႥႼ).ႳႳ;
				P_0.OnDisconnectEvent += ((ႥႼ)obj).ႳႣ;
				goto case 5;
			case 5:
				num = ⴄ[74] - 30096;
				break;
			case 1:
			case 4:
				((ႥႼ)obj).Ⴜ();
				Ⴈ().Add(obj as ႥႼ);
				return;
			}
		}
	}

	internal void Ⴐ(string P_0, DxSpot P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 0;
		object current = default(object);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				if (Ⴄ().Cfg.TelnetServer.Enabled)
				{
					goto IL_003f;
				}
				break;
			case 1:
			case 3:
			{
				List<ႥႼ>.Enumerator enumerator = Ⴈ().GetEnumerator();
				try
				{
					int num2 = 3;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ⴅ[102];
							continue;
						case 2:
						case 6:
							current = enumerator.Current;
							flag = Ⴄ().Caches.Dx.Ⴓ((current as ႥႼ).Ⴅ());
							num2 = ⴅ[352] - 1;
							continue;
						case 9:
							num2 = ((!(current as ႥႼ).Ⴀ()) ? 10 : 7);
							continue;
						case 7:
						{
							bool num3 = flag;
							Bye.Ⴄ[115] = (char)((Bye.Ⴄ[115] - Bye.Ⴄ[61]) & 0x90);
							num2 = (num3 ? 1 : 10);
							continue;
						}
						case 1:
						{
							ICloneable cloneable = Ⴍ(P_0, ((ႥႼ)current).Ⴄ(), P_1);
							((ႥႼ)current).ႳႷ(cloneable as string);
							break;
						}
						case 10:
							break;
						case 8:
							goto end_IL_0053;
						}
						num2 = (enumerator.MoveNext() ? 6 : 8);
						continue;
						end_IL_0053:
						break;
					}
				}
				finally
				{
					switch (0)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 1:
						break;
					}
				}
				break;
			}
			}
			break;
			IL_003f:
			num = 1;
		}
		switch (3)
		{
		}
	}

	private string Ⴍ(string P_0, DxCommentExtCfg P_1, DxSpot P_2)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		IComparable<string> comparable = default(IComparable<string>);
		while (true)
		{
			IConvertible convertible = string.Empty;
			int num = ((!P_1.Lotw) ? 16 : (ⴗ[106] - 22822));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[13] - 41451;
					continue;
				case 47:
					break;
				case 41:
					num = ((!FilterPicker.ႥႤ(P_2, 870, 782)) ? 16 : 49);
					continue;
				case 49:
					convertible = ႥႥ.Ⴍ(7, 1580609502, '#', P_0);
					num = 16;
					continue;
				case 16:
					num = ((!P_1.Cty) ? 19 : 46);
					continue;
				case 46:
					convertible = DxFilters.Ⴈ((string)convertible, ႳႥ.ႥႥ(P_2, 315, 256), 607, 519);
					num = 19;
					continue;
				case 19:
					num = ((!P_1.State) ? (ⴗ[130] - 30799) : 18);
					continue;
				case 18:
					convertible = Ⴐ(convertible as string);
					convertible = DxFilters.Ⴈ((string)convertible, FilterViewer.ႨႥ(P_2, 30, '\0'), 569, 609);
					num = 33;
					continue;
				case 9:
				case 33:
					num = ((!P_1.Loc) ? (ⴗ[103] - 55670) : 29);
					continue;
				case 29:
					convertible = Ⴐ(convertible as string);
					num = ((ႳႳ.Ⴓ(FilterViewer.ႨႥ(P_2, 126, '`'), 'ʬ', 650) <= 0) ? (ⴅ[115] + 0) : (ⴄ[101] - 33649));
					continue;
				case 0:
					convertible = DxFilters.Ⴈ(convertible as string, FilterViewer.ႨႥ(P_2, 324, 'Ś'), 198, 158);
					num = 21;
					continue;
				case 4:
					convertible = DxFilters.Ⴈ(convertible as string, ႳႥ.ႥႥ(P_2, 337, 362), 1015, 943);
					num = 21;
					continue;
				case 21:
					num = ((!P_1.Section) ? 20 : 13);
					continue;
				case 13:
					num = ((!DxCommentExtCfg.ႤႰ(ႳႥ.ႥႥ(P_2, 376, 323), ႥႥ.Ⴅ(1673508809, null, 0), 'Ȥ', 514)) ? (ⴅ[98] - 57) : 51);
					continue;
				case 51:
					convertible = Ⴐ((string)convertible);
					convertible = DxFilters.Ⴈ(convertible as string, ႳႰ.Ⴈ(P_2, 854, 773), 290, 378);
					num = ⴅ[102] + ⴅ[102];
					continue;
				case 20:
					num = ((!P_1.County) ? 42 : (ⴗ[136] - 30463));
					continue;
				case 1:
					num = ((!DxCommentExtCfg.ႤႰ(ႳႥ.ႥႥ(P_2, 829, 774), ႥႥ.Ⴅ(1673508810, null, 3), 'ı', 279)) ? 42 : (ⴗ[98] - 39615));
					continue;
				case 31:
					convertible = Ⴐ(convertible as string);
					convertible = DxFilters.Ⴈ(convertible as string, ႳႥ.ႥႥ(P_2, 983, 1003), 2, 90);
					num = 42;
					continue;
				case 42:
					num = ((!P_1.Grid) ? (ⴅ[256] - ⴅ[106]) : 10);
					continue;
				case 10:
					num = ((!DxCommentExtCfg.ႤႰ(ႳႥ.ႥႥ(P_2, 278, 301), ႥႥ.Ⴅ(1673508808, null, 1), '±', 151)) ? (ⴅ[105] - 182) : 50);
					continue;
				case 50:
					convertible = Ⴐ(convertible as string);
					convertible = DxFilters.Ⴈ(convertible as string, ႳႰ.Ⴈ(P_2, 665, 717), 68, 28);
					num = 14;
					continue;
				case 14:
					num = ((!P_1.CqZone) ? (ⴀႠ[35] - 25300) : 34);
					continue;
				case 34:
					convertible = Ⴐ(convertible as string);
					convertible = ႥႭ.ႳႭ((object)(string)convertible, (object)ClientCty.ႠႷ(P_2, 159, 234), (short)50, 31);
					num = ⴀႠ[0] - 49942;
					continue;
				case 15:
					num = ((!P_1.ItuZone) ? (ⴄ[116] - 53563) : ⴄ[114]);
					continue;
				case 22:
					convertible = Ⴐ((string)convertible);
					convertible = ႥႭ.ႳႭ((object)(convertible as string), (object)ClientCty.ႠႷ(P_2, 733, 683), (short)195, 238);
					num = 40;
					continue;
				case 40:
					num = ((!P_1.Name) ? (ⴄ[296] - 33822) : 24);
					continue;
				case 24:
					convertible = Ⴐ((string)convertible);
					convertible = DxFilters.Ⴈ(convertible as string, FilterViewer.ႨႥ(P_2, 902, 'Ι'), 725, 653);
					num = 26;
					continue;
				case 26:
					num = ((!P_1.SkimmerQuality) ? 11 : 43);
					continue;
				case 43:
					convertible = Ⴐ((string)convertible);
					convertible = DxFilters.Ⴈ((string)convertible, Ⴓ(P_2), 343, 271);
					num = 11;
					continue;
				case 11:
					num = ((!P_1.SpotterCty) ? 27 : (ⴅ[377] - 118));
					continue;
				case 23:
					convertible = Ⴐ(convertible as string);
					convertible = DxFilters.Ⴈ(convertible as string, ႳႰ.Ⴈ(P_2, 202, 159), 230, 190);
					num = 27;
					continue;
				case 27:
					num = ((!P_1.SpotterState) ? (ⴅ[154] - 174) : (ⴗ[26] - 21683));
					continue;
				case 30:
					convertible = Ⴐ(convertible as string);
					convertible = DxFilters.Ⴈ(convertible as string, FilterViewer.ႨႣ(P_2, 332, 'ļ'), 90, 2);
					num = ⴗ[16] - 26597;
					continue;
				case 44:
					num = ((!P_1.SpotterLoc) ? 36 : 17);
					continue;
				case 17:
					convertible = Ⴐ(convertible as string);
					num = ((P_2.SpotterState.Length <= 0) ? 12 : (ⴀႠ[112] - 45096));
					continue;
				case 38:
					convertible = (convertible as string) + P_2.SpotterState;
					num = 36;
					continue;
				case 12:
					convertible = (convertible as string) + P_2.SpotterCty;
					num = 36;
					continue;
				case 36:
					num = ((!P_1.SpotterCont) ? 45 : 3);
					continue;
				case 3:
					convertible = Ⴐ(convertible as string);
					convertible = (convertible as string) + P_2.SpotterCont;
					num = ⴗ[0] - 29114;
					continue;
				case 45:
					num = ((!(convertible as string).EndsWith(ClientCty.Ⴗ('ç', 7, 307012839))) ? 8 : (ⴅ[287] - 103));
					continue;
				case 39:
					convertible = ((string)convertible).Substring(0, (convertible as string).Length - 1);
					num = 8;
					continue;
				case 8:
					num = ((!P_1.Eos) ? 32 : 35);
					continue;
				case 35:
					comparable = P_0 + ႥႥ.Ⴅ(1673508291, null, 1) + (convertible as string);
					num = ⴀႠ[103] - 38431;
					continue;
				case 32:
					num = ((((string)convertible).Length <= 28) ? (ⴄ[139] - 9607) : ⴅ[25]);
					continue;
				case 2:
				case 28:
					convertible = (convertible as string).Substring(0, 28);
					convertible = (convertible as string) + WxFilters.Ⴀ(null, 6, 103387610);
					num = 25;
					continue;
				case 25:
					num = ((!Ⴍ(P_0, (convertible as string).Length)) ? (ⴄ[0] - 30357) : 6);
					continue;
				case 6:
					comparable = P_0.Substring(0, 69 - (convertible as string).Length) + (string)convertible + P_0.Substring(69);
					num = ⴗ[28] - 37760;
					continue;
				case 5:
					comparable = P_0;
					num = 48;
					continue;
				case 48:
					return (string)comparable;
				}
				break;
			}
		}
	}

	private string Ⴓ(DxSpot P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		while (true)
		{
			int num = ((!DxFilters.Ⴄ(P_0, '\u0358', 822)) ? (ⴅ[176] - 14) : 7);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 9;
					continue;
				case 9:
					break;
				case 7:
					return ClientCty.Ⴗ('\b', 7, 307012891);
				case 1:
					num = ((!FilterPicker.ႥႤ(P_0, 518, 623)) ? 5 : 6);
					continue;
				case 6:
				case 8:
					return ClientCty.Ⴗ('\u0001', 2, 307012890);
				case 5:
					num = (FilterEditor.ႷႰ(P_0, 705, 648) ? (ⴗ[93] - 63517) : 0);
					continue;
				case 2:
				case 4:
					return ClientCty.Ⴗ('ª', 8, 307012892);
				case 0:
				case 12:
					num = ((!FilterPicker.ႥႤ(P_0, 209, 184)) ? 11 : 3);
					continue;
				case 3:
					return ClientCty.Ⴗ('i', 8, 307012880);
				case 11:
					return string.Empty;
				}
				break;
			}
		}
	}

	private static string Ⴐ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		while (true)
		{
			int num = ((ႳႳ.Ⴓ(P_0, '\u030d', 811) <= 0) ? 2 : 5);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 1;
					continue;
				case 1:
					break;
				case 0:
				case 3:
				case 5:
					P_0 = DxFilters.Ⴈ(P_0, ClientCty.Ⴗ('\u0096', 8, 307012840), 769, 857);
					num = ⴀႠ[87] - 21218;
					continue;
				case 2:
					return P_0;
				}
				break;
			}
		}
	}

	private static bool Ⴍ(string P_0, int P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		while (true)
		{
			int num = 70 - P_1;
			int num2 = num;
			int num3 = 3;
			while (true)
			{
				switch (num3)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num3 = 4;
					continue;
				case 4:
				case 9:
					break;
				case 8:
					num3 = ((SetDxFilter.Ⴈ(P_0, num2, 718, 662) == ' ') ? 1 : 2);
					continue;
				case 2:
					return false;
				case 1:
					num2++;
					num3 = ⴄ[296] - 33845;
					continue;
				case 3:
				case 7:
				{
					int num5;
					if (num2 >= 70)
					{
						char num4 = ⴀႠ[90];
						HighlightCtyCfg.ႠႠ[60] = (char)((HighlightCtyCfg.ႠႠ[60] - P_1) & 0x45);
						num5 = num4 - 47366;
					}
					else
					{
						num5 = 8;
					}
					num3 = num5;
					continue;
				}
				case 5:
					return true;
				}
				break;
			}
		}
	}

	internal void Ⴍ(AnnWxSpot P_0)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		IEnumerable enumerable = default(IEnumerable);
		object current = default(object);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				if (Ⴄ().Cfg.TelnetServer.Enabled)
				{
					goto IL_004d;
				}
				break;
			case 3:
				enumerable = ShowUsers.Ⴓ(P_0, 'ɋ', 'ɸ');
				goto case 1;
			case 1:
			case 4:
			{
				List<ႥႼ>.Enumerator enumerator = Ⴈ().GetEnumerator();
				try
				{
					int num2 = 5;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ⴗ[37] - 54915;
							continue;
						case 2:
							current = enumerator.Current;
							flag = Ⴄ().Caches.Ann.Ⴓ((current as ႥႼ).Ⴓ());
							goto case 9;
						case 9:
							num2 = ⴅ[75] - 235;
							continue;
						case 1:
						case 3:
							num2 = ((!(current as ႥႼ).Ⴀ()) ? (ⴅ[0] - 156) : ⴅ[17]);
							continue;
						case 0:
							num2 = ((!flag) ? 6 : (ⴀႠ[44] - 48720));
							continue;
						case 8:
							((ႥႼ)current).ႳႷ(enumerable as string);
							break;
						case 6:
							break;
						case 4:
						case 10:
							goto end_IL_0072;
						}
						num2 = (enumerator.MoveNext() ? 2 : (ⴗ[104] - 48537));
						continue;
						end_IL_0072:
						break;
					}
				}
				finally
				{
					switch (1)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 0:
					case 3:
						break;
					}
				}
				break;
			}
			}
			break;
			IL_004d:
			num = 3;
		}
		switch (3)
		{
		}
	}

	internal void Ⴀ(AnnWxSpot P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 1;
		IEquatable<string> equatable = default(IEquatable<string>);
		object current = default(object);
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			default:
				if (Ⴄ().Cfg.TelnetServer.Enabled)
				{
					goto IL_0046;
				}
				break;
			case 2:
			case 3:
			case 4:
				equatable = ShowUsers.Ⴓ(P_0, 'ƭ', 'ƞ');
				goto case 0;
			case 0:
			{
				List<ႥႼ>.Enumerator enumerator = Ⴈ().GetEnumerator();
				try
				{
					int num2 = 8;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 10;
							continue;
						case 2:
						case 7:
							current = enumerator.Current;
							goto case 6;
						case 6:
							flag = Ⴄ().Caches.Wx.Ⴅ(((ႥႼ)current).Ⴍ());
							num2 = 3;
							continue;
						case 3:
							num2 = ((!((ႥႼ)current).Ⴀ()) ? 10 : (ⴄ[171] - 40002));
							continue;
						case 9:
							num2 = (flag ? 1 : 10);
							continue;
						case 1:
						case 4:
							(current as ႥႼ).ႳႷ((string)equatable);
							break;
						case 10:
							break;
						case 5:
							goto end_IL_006b;
						}
						num2 = (enumerator.MoveNext() ? (ⴄ[34] - 61631) : ⴅ[285]);
						continue;
						end_IL_006b:
						break;
					}
				}
				finally
				{
					switch (1)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					}
				}
				break;
			}
			}
			break;
			IL_0046:
			num = 3;
		}
		switch (4)
		{
		}
	}

	internal void Ⴜ(WwvSpot P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 2;
		ICloneable cloneable = default(ICloneable);
		object current = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				if (Ⴄ().Cfg.TelnetServer.Enabled)
				{
					goto IL_0046;
				}
				return;
			case 1:
			case 4:
				cloneable = HighlightStateCfg.Ⴜ(P_0, '\u02f5', 742);
				break;
			case 0:
			case 3:
				break;
			}
			using (List<ႥႼ>.Enumerator enumerator = Ⴈ().GetEnumerator())
			{
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 6:
						current = enumerator.Current;
						num2 = ((!(current as ႥႼ).Ⴀ()) ? 4 : (ⴗ[106] - 22862));
						continue;
					case 1:
					case 5:
						((ႥႼ)current).ႳႷ(cloneable as string);
						break;
					case 3:
						return;
					}
					num2 = (enumerator.MoveNext() ? (ⴅ[18] / 6) : 3);
				}
			}
			IL_0046:
			num = ⴗ[31] - 64615;
		}
	}

	public void SetDefaultDxFilter(string filterName, string filter)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 3;
		object current = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				Ⴄ().Cfg.Filters.Dx.DefaultFilterName = filterName;
				break;
			case 2:
				break;
			case 0:
			case 4:
			{
				List<ႥႼ>.Enumerator enumerator = Ⴈ().GetEnumerator();
				try
				{
					int num2 = 4;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 5;
							continue;
						case 2:
							current = enumerator.Current;
							goto case 0;
						case 0:
							(current as ႥႼ).Ⴃ(TelnetServerCfg.Ⴗ(filter, SqlFilterType.Dx, 'Ɍ', 622));
							num2 = ⴗ[114] - 15474;
							continue;
						case 1:
							((ႥႼ)current).ႳႷ(DxFilters.Ⴈ(ႥႥ.Ⴅ(1673508761, null, 6), filter, 231, 191));
							break;
						case 5:
							break;
						case 8:
							goto end_IL_0076;
						}
						num2 = (enumerator.MoveNext() ? 2 : 8);
						continue;
						end_IL_0076:
						break;
					}
				}
				finally
				{
					switch (1)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					}
				}
				switch (2)
				{
				}
				return;
			}
			}
			Ⴄ().Cfg.Filters.Dx.DefaultFilter = filter;
			num = ⴗ[120] - 5080;
		}
	}

	public void SetDefaultAnnFilter(string filterName, string filter)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 1;
		object current = default(object);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
			case 3:
			{
				List<ႥႼ>.Enumerator enumerator = Ⴈ().GetEnumerator();
				try
				{
					int num2 = 6;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = 2;
							continue;
						case 7:
							current = enumerator.Current;
							(current as ႥႼ).Ⴄ(TelnetServerCfg.Ⴗ(filter, SqlFilterType.AnnWx, 'ȥ', 519));
							goto case 5;
						case 5:
							num2 = 8;
							continue;
						case 8:
							(current as ႥႼ).ႳႷ(DxFilters.Ⴈ(ႥႥ.Ⴍ(7, 1580609474, 'Y', null), filter, 406, 462));
							break;
						case 2:
						case 4:
							break;
						case 0:
						case 3:
							goto end_IL_0073;
						}
						num2 = (enumerator.MoveNext() ? (ⴗ[12] - 294) : (ⴄ[259] - 4897));
						continue;
						end_IL_0073:
						break;
					}
				}
				finally
				{
					switch (3)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 1:
						break;
					}
				}
				switch (2)
				{
				}
				return;
			}
			}
			Ⴄ().Cfg.Filters.Ann.DefaultFilterName = filterName;
			Ⴄ().Cfg.Filters.Ann.DefaultFilter = filter;
			num = 2;
		}
	}

	public void SetDefaultWxFilter(string filterName, string filter)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 4;
		object current = default(object);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 3:
			{
				List<ႥႼ>.Enumerator enumerator = Ⴈ().GetEnumerator();
				try
				{
					int num2 = 5;
					while (true)
					{
						switch (num2)
						{
						default:
							num2 = ⴀႠ[63] - 29197;
							continue;
						case 4:
						case 8:
							current = enumerator.Current;
							goto case 6;
						case 6:
							((ႥႼ)current).Ⴀ(TelnetServerCfg.Ⴗ(filter, SqlFilterType.AnnWx, '\u030c', 814));
							num2 = 7;
							continue;
						case 7:
							(current as ႥႼ).ႳႷ(DxFilters.Ⴈ(WxFilters.Ⴀ(null, 0, 103387585), filter, 106, 50));
							break;
						case 3:
							break;
						case 2:
							goto end_IL_0087;
						}
						num2 = (enumerator.MoveNext() ? (ⴗ[48] - 52953) : (ⴄ[273] - 10910));
						continue;
						end_IL_0087:
						break;
					}
				}
				finally
				{
					switch (0)
					{
					default:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						break;
					case 1:
					case 2:
						break;
					}
				}
				switch (0)
				{
				}
				return;
			}
			}
			Ⴄ().Cfg.Filters.Wx.DefaultFilterName = filterName;
			Ⴄ().Cfg.Filters.Wx.DefaultFilter = filter;
			num = ⴄ[290] - 49150;
		}
	}

	[SecuritySafeCritical]
	static TelnetServerWrapper()
	{
		ArcClientConnectDat.Ⴍ();
		TelnetServerWrapper.m_Ⴍ = HighlightItuZoneCfg.Ⴓ(ClientCty.Ⴗ('\u009b', 3, 307012883), 159, 175);
	}
}

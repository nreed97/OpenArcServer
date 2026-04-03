using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcCaches;

public sealed class DxccCache
{
	private static readonly ILog m_Ⴄ;

	private static readonly object Ⴅ;

	private bool m_Ⴃ;

	private ႳႳ.ႤႰ m_Ⴐ = new ႳႳ.ႤႰ();

	public DxccCache()
	{
		object obj = new Dictionary<string, DxccCacheData>();
		this.m_Ⴐ.Ⴄ = obj as Dictionary<string, DxccCacheData>;
		Init();
	}

	public bool Init()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		bool flag = false;
		object ⴅ = default(object);
		bool flag2;
		try
		{
			switch (3)
			{
			default:
				ႥႥ.ႤႨ(ⴅ = Ⴅ, ref flag, 188, 205);
				try
				{
					int num = 6;
					object obj2 = default(object);
					IConvertible convertible2 = default(IConvertible);
					TextReader textReader = default(TextReader);
					IConvertible convertible = default(IConvertible);
					while (true)
					{
						switch (num)
						{
						default:
							obj2 = new PrecisionTimer();
							MultimediaCfg.Ⴄ(obj2 as PrecisionTimer, 677, 655);
							this.m_Ⴐ.Ⴄ.Clear();
							num = ⴀႠ[38] - 28693;
							continue;
						case 4:
						{
							ICustomAttributeProvider customAttributeProvider = WxFilters.ႭႭ(873, 834);
							convertible2 = DxFilters.Ⴈ(HighlightCfg.ႳႳ(ႥႠ.Ⴅ((Assembly)customAttributeProvider, 765, 705), 'χ', 939), ႥႥ.Ⴍ(5, 1580608274, 'ð', null), 826, 866);
							num = 12;
							continue;
						}
						case 12:
						{
							Stream stream = new FileStream((string)convertible2, FileMode.Open, FileAccess.Read);
							textReader = new StreamReader((FileStream)stream);
							goto case 1;
						}
						case 1:
							num = ⴄ[247] - 48898;
							continue;
						case 8:
							convertible = HighlightItuZoneCfg.Ⴜ((TextReader)(textReader as StreamReader), (short)670, (short)715);
							num = 5;
							continue;
						case 7:
							num = ((ႳႳ.Ⴓ(convertible as string, 'Ã', 229) <= 0) ? (ⴄ[13] - 20658) : (ⴀႠ[16] - 39565));
							continue;
						case 0:
							Ⴓ(convertible as string);
							goto case 2;
						case 2:
							convertible = HighlightItuZoneCfg.Ⴜ((TextReader)(textReader as StreamReader), (short)553, (short)636);
							num = 5;
							continue;
						case 5:
							num = ((convertible is string) ? 7 : 9);
							continue;
						case 9:
							UserInfo.Ⴓ((TextReader)(textReader as StreamReader), 'Ϗ', 'χ');
							MultimediaCfg.Ⴈ((PrecisionTimer)obj2, 944, 913);
							num = 10;
							continue;
						case 10:
						case 11:
						{
							ILog ⴄ2 = DxccCache.m_Ⴄ;
							object obj = new object[4];
							(obj as object[])[0] = obj2 as PrecisionTimer;
							(obj as object[])[1] = ClientCty.Ⴗ('Ú', 2, 307011790);
							((object[])obj)[2] = this.m_Ⴐ.Ⴄ.Count;
							(obj as object[])[3] = ႥႥ.Ⴍ(3, 1580609129, 'Í', null);
							ⴄ2.Info(string.Concat(obj as object[]));
							num = 3;
							continue;
						}
						case 3:
							flag2 = true;
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					DxccCache.m_Ⴄ.Error(ex.Message);
					flag2 = false;
				}
				break;
			}
		}
		finally
		{
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 3 : 6);
					goto IL_031f;
				case 0:
				case 6:
					Monitor.Exit(ⴅ);
					break;
				case 2:
				case 3:
				case 4:
					break;
				}
				break;
				IL_031f:
				num2 = num3;
			}
		}
		return 1 switch
		{
			_ => flag2, 
		};
	}

	private void Ⴓ(string P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!ႥႤ.Ⴍ(P_0, ႥႥ.Ⴍ(5, 1580608270, '|', P_0), 55, 13)) ? 10 : ⴅ[285]);
				break;
			case 5:
				this.m_Ⴃ = false;
				num = 10;
				break;
			case 0:
			case 10:
				num = ((!this.m_Ⴃ) ? 7 : 4);
				break;
			case 4:
			{
				int num2;
				if (ႳႳ.Ⴓ(P_0, 'ϳ', 981) > 0)
				{
					num2 = ⴄ[174] - 46411;
				}
				else
				{
					char num3 = ⴄ[2];
					Bye.Ⴄ[153] = (char)(Bye.Ⴄ[153] & Bye.Ⴄ[113] & 2);
					num2 = num3 - 13947;
				}
				num = num2;
				break;
			}
			case 8:
				Ⴃ(P_0);
				goto case 7;
			case 7:
				num = ((!P_0.StartsWith(ႥႥ.Ⴅ(1673507039, null, 6))) ? (ⴄ[290] - 49150) : (ⴅ[115] / 2));
				break;
			case 2:
			case 9:
				this.m_Ⴃ = true;
				num = 1;
				break;
			case 1:
			case 6:
				return;
			}
		}
	}

	private void Ⴃ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 4;
		object obj = default(object);
		object ⴅ = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new DxccCacheData(P_0);
				goto case 3;
			case 3:
			{
				bool num4 = DxCommentExtCfg.ႤႰ(((DxccCacheData)obj).Ⴅ(), ႥႥ.Ⴅ(1673508293, null, 7), 'ƾ', 408);
				UserCmd.Ⴅ[275] = (byte)((UserCmd.Ⴅ[275] | ႥႰ.Ⴗ[65]) & 0x8B);
				if (!num4)
				{
					return;
				}
				break;
			}
			case 0:
			case 1:
			{
				bool flag = false;
				try
				{
					ႥႥ.ႤႨ(ⴅ = Ⴅ, ref flag, 587, 570);
					this.m_Ⴐ.Ⴄ.Add(((DxccCacheData)obj).Ⴀ(), (DxccCacheData)obj);
					return;
				}
				finally
				{
					int num2 = 4;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							num3 = ((!flag) ? 1 : (ⴀႠ[64] - 42670));
							goto IL_00ee;
						case 2:
							Monitor.Exit(ⴅ);
							break;
						case 1:
						case 3:
							break;
						}
						break;
						IL_00ee:
						num2 = num3;
					}
				}
			}
			}
			num = 1;
		}
	}

	public string GetToolTipInfo(string cty, string call)
	{
		char[] ⴄ = Bye.Ⴄ;
		cty = FilterViewer.ႨႷ(cty, 857, 882);
		bool flag = false;
		object ⴅ = default(object);
		IComparable comparable = default(IComparable);
		try
		{
			int num = 2;
			object obj = default(object);
			while (true)
			{
				int num3;
				switch (num)
				{
				default:
				{
					ႥႥ.ႤႨ(ⴅ = Ⴅ, ref flag, 597, 548);
					bool num2 = this.m_Ⴐ.Ⴄ.ContainsKey(cty);
					Bye.Ⴄ[75] = (char)(Bye.Ⴄ[75] & Bye.Ⴄ[248] & 0x19);
					num3 = ((!num2) ? (ⴄ[21] - 62605) : (ⴄ[122] - 21990));
					goto IL_00c6;
				}
				case 1:
				case 4:
					obj = this.m_Ⴐ.Ⴄ[cty];
					break;
				case 3:
					break;
				case 0:
				case 5:
					goto end_IL_0052;
				}
				comparable = ((DxccCacheData)obj).ႭႼ(call);
				goto IL_0152;
				IL_00c6:
				num = num3;
				continue;
				end_IL_0052:
				break;
			}
		}
		finally
		{
			int num4 = 3;
			while (true)
			{
				int num5;
				switch (num4)
				{
				default:
					num5 = ((!flag) ? 5 : 4);
					goto IL_0120;
				case 1:
				case 2:
				case 4:
					Monitor.Exit(ⴅ);
					break;
				case 0:
				case 5:
					break;
				}
				break;
				IL_0120:
				num4 = num5;
			}
		}
		switch (2)
		{
		default:
			return string.Empty;
		case 0:
		case 1:
		case 4:
			break;
		}
		goto IL_0152;
		IL_0152:
		return comparable as string;
	}

	internal bool Ⴄ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		P_0 = FilterViewer.ႨႷ(P_0, 592, 635);
		bool flag = false;
		object ⴅ = default(object);
		bool result = default(bool);
		try
		{
			int num = 0;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					ႥႥ.ႤႨ(ⴅ = Ⴅ, ref flag, 453, 436);
					goto case 1;
				case 1:
				case 4:
					num2 = ((!this.m_Ⴐ.Ⴄ.ContainsKey(P_0)) ? (ⴀႠ[122] - 49005) : (ⴄ[13] - 20658));
					goto IL_00b1;
				case 2:
				{
					object obj = this.m_Ⴐ.Ⴄ[P_0];
					result = ႥႤ.Ⴍ(((DxccCacheData)obj).Ⴍ(), ClientCty.Ⴗ('u', 0, 307011838), 417, 410);
					return result;
				}
				case 3:
				case 5:
					break;
				}
				break;
				IL_00b1:
				num = num2;
			}
		}
		finally
		{
			int num3 = 2;
			while (true)
			{
				int num4;
				switch (num3)
				{
				default:
					num4 = ((!flag) ? (ⴀႠ[75] - 37476) : 3);
					goto IL_0126;
				case 3:
					Monitor.Exit(ⴅ);
					break;
				case 1:
				case 4:
					break;
				}
				break;
				IL_0126:
				num3 = num4;
			}
		}
		switch (3)
		{
		default:
			return true;
		case 0:
		case 1:
		case 2:
			return result;
		}
	}

	internal bool Ⴐ(string P_0, string P_1, string P_2)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		object obj = null;
		P_0 = FilterViewer.ႨႷ(P_0, 129, 170);
		bool flag = false;
		object ⴅ = default(object);
		try
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					ႥႥ.ႤႨ(ⴅ = Ⴅ, ref flag, 0, 113);
					num = ((!this.m_Ⴐ.Ⴄ.ContainsKey(P_0)) ? (ⴗ[59] - 33050) : 4);
					continue;
				case 0:
				case 1:
				case 4:
					obj = this.m_Ⴐ.Ⴄ[P_0];
					num = ⴄ[209] - 1385;
					continue;
				case 5:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 0;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 3 : (ⴀႠ[58] - 24332));
					goto IL_0103;
				case 1:
				case 2:
				case 4:
					DxFilters.Ⴍ(ⴅ, 965, 931);
					break;
				case 3:
					break;
				}
				break;
				IL_0103:
				num2 = num3;
			}
		}
		int num4 = 1;
		while (true)
		{
			switch (num4)
			{
			default:
				num4 = ((!(obj is DxccCacheData)) ? (ⴄ[36] - 60862) : 3);
				break;
			case 3:
				num4 = (Ⴈ((DxccCacheData)obj, P_2) ? 2 : 7);
				break;
			case 7:
				return Ⴃ((DxccCacheData)obj, P_1);
			case 2:
			case 4:
			case 6:
				return true;
			case 0:
			case 5:
				return true;
			}
		}
	}

	private bool Ⴈ(DxccCacheData P_0, string P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			IComparable comparable;
			int num = (((comparable = P_1) == null) ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 12;
					continue;
				case 12:
					break;
				case 3:
					num = (DxCommentExtCfg.ႤႰ(comparable as string, ႥႥ.Ⴅ(1673507029, null, 7), '\u0002', 36) ? ⴅ[115] : 7);
					continue;
				case 7:
					num = ((!DxCommentExtCfg.ႤႰ(comparable as string, ClientCty.Ⴗ('\u0081', 2, 307011832), 'ň', 366)) ? 5 : 0);
					continue;
				case 5:
					num = ((!DxCommentExtCfg.ႤႰ(comparable as string, WxFilters.Ⴀ(null, 5, 103388416), '\u0093', 181)) ? 1 : 8);
					continue;
				case 1:
					num = ⴅ[281] - ⴅ[56];
					continue;
				case 4:
				case 11:
				{
					bool result = ႥႤ.Ⴍ(P_0.Ⴐ(), ClientCty.Ⴗ('O', 5, 307011835), 76, 119);
					ႥႰ.Ⴗ[19] = (char)((ႥႰ.Ⴗ[19] - ႥႰ.Ⴗ[36]) & 0xDD);
					return result;
				}
				case 0:
				case 6:
					return ႥႤ.Ⴍ(P_0.Ⴈ(), ClientCty.Ⴗ('¡', 0, 307011838), 338, 361);
				case 8:
					return P_0.Ⴃ() != ClientCty.Ⴗ('G', 4, 307011834);
				case 2:
				case 9:
					return true;
				}
				break;
			}
		}
	}

	private bool Ⴃ(DxccCacheData P_0, string P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		int value = default(int);
		while (true)
		{
			IEnumerable<char> enumerable;
			int num = (((enumerable = P_1) == null) ? 7 : 13);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴀႠ[78] - 14979;
					continue;
				case 11:
					break;
				case 13:
					num = ((ႳႰ.Ⴄ != null) ? (ⴗ[63] - 6957) : 6);
					continue;
				case 6:
					ႳႰ.Ⴄ = new Dictionary<string, int>(10)
					{
						{
							ႥႥ.Ⴅ(1673507051, null, 4),
							0
						},
						{
							ႥႥ.Ⴅ(1673507044, null, 1),
							1
						},
						{
							ႥႥ.Ⴅ(1673507046, null, 4),
							2
						},
						{
							ႥႥ.Ⴅ(1673507063, null, 8),
							3
						},
						{
							ႥႥ.Ⴅ(1673507068, null, 8),
							4
						},
						{
							ႥႥ.Ⴅ(1673507059, null, 2),
							5
						},
						{
							ႥႥ.Ⴅ(1673506952, null, 6),
							6
						},
						{
							ႥႥ.Ⴅ(1673506957, null, 6),
							7
						},
						{
							ႥႥ.Ⴅ(1673506952, null, 8),
							8
						},
						{
							ႥႥ.Ⴅ(1673506973, null, 0),
							9
						}
					};
					num = 1;
					continue;
				case 1:
					num = ((!ႳႰ.Ⴄ.TryGetValue(enumerable as string, out value)) ? 7 : 3);
					continue;
				case 3:
				case 16:
				case 19:
					num = value switch
					{
						0 => 2, 
						1 => 10, 
						2 => 5, 
						3 => ⴅ[121] - 76, 
						4 => 18, 
						5 => ⴗ[145] - 59471, 
						6 => 15, 
						7 => 12, 
						8 => 8, 
						9 => ⴗ[154] - 7301, 
						_ => ⴗ[119] - 30797, 
					};
					continue;
				case 0:
					num = 7;
					continue;
				case 2:
					return ႥႤ.Ⴍ(P_0.Ⴄ(), ClientCty.Ⴗ('j', 4, 307011834), 850, 873);
				case 10:
					return ႥႤ.Ⴍ(P_0.Ⴜ(), ClientCty.Ⴗ('ª', 6, 307011832), 372, 335);
				case 5:
					return ႥႤ.Ⴍ(P_0.ႠႷ(), ClientCty.Ⴗ('\u0012', 1, 307011839), 40, 19);
				case 9:
				case 17:
					return ႥႤ.Ⴍ(P_0.ႠႠ(), ClientCty.Ⴗ('«', 7, 307011833), 615, 604);
				case 18:
					return ႥႤ.Ⴍ(P_0.ႠႥ(), ClientCty.Ⴗ('Z', 4, 307011834), 291, 280);
				case 14:
					return ႥႤ.Ⴍ(P_0.ႠႭ(), ClientCty.Ⴗ('\u0081', 3, 307011837), 714, 753);
				case 15:
					return ႥႤ.Ⴍ(P_0.ႠႨ(), ClientCty.Ⴗ('W', 7, 307011833), 224, 219);
				case 12:
					return ႥႤ.Ⴍ(P_0.ႠႰ(), ClientCty.Ⴗ('\u0099', 7, 307011833), 109, 86);
				case 8:
					return P_0.ႠႣ() != ClientCty.Ⴗ('o', 3, 307011837);
				case 4:
					return P_0.ႠႳ() != ClientCty.Ⴗ('N', 6, 307011832);
				case 7:
					return true;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static DxccCache()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				ArcClientConnectDat.Ⴍ();
				DxccCache.m_Ⴄ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴍ(7, 1580608313, '¼', null), 871, 855);
				break;
			case 4:
				break;
			case 3:
				Ⴅ = new object();
				return;
			case 1:
				return;
			}
			num = 3;
		}
	}
}

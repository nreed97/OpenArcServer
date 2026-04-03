using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using Spring.Core.IO;
using Spring.Objects.Factory;
using Spring.Objects.Factory.Xml;
using ZedGraph;

namespace Ⴀ;

internal sealed class ႥႭ
{
	internal sealed class ႳႨ
	{
		internal IContainer Ⴀ;

		internal Button Ⴗ;

		internal System.Windows.Forms.Label Ⴃ;

		internal ArcClientObjMgr Ⴍ;

		internal ႳႨ()
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct ႳႰ
	{
		internal string Ⴐ;

		internal Color Ⴍ;
	}

	private readonly IObjectFactory m_Ⴈ;

	internal ႥႳ Ⴈ(string P_0)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		object obj = (ႥႳ)this.m_Ⴈ.GetObject(P_0);
		return (ႥႳ)obj;
	}

	internal ႥႭ()
	{
		object obj = new FileSystemResource(WxFilters.Ⴀ(null, 8, 103387878));
		this.m_Ⴈ = new XmlObjectFactory(obj as IResource);
	}

	internal DxCache Ⴐ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			object obj = (DxCache)this.m_Ⴈ.GetObject(ClientCty.Ⴗ('Ó', 7, 307013317));
			int num = ⴅ[285];
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴅ[115];
					continue;
				case 4:
					break;
				case 0:
				case 1:
				case 5:
				{
					DxCache result = (DxCache)obj;
					Bye.Ⴄ[238] = (char)((Bye.Ⴄ[238] + Bye.Ⴄ[258]) & 0x85);
					return result;
				}
				}
				break;
			}
		}
	}

	internal DxccCache Ⴓ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		while (true)
		{
			object obj = (DxccCache)this.m_Ⴈ.GetObject(ႥႥ.Ⴅ(1673508328, null, 7));
			int num = ⴄ[265] - 20897;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴗ[120] - 5082;
					continue;
				case 0:
				case 2:
				case 5:
					break;
				case 3:
				case 4:
					return (DxccCache)obj;
				}
				break;
			}
		}
	}

	internal BuddyCache Ⴍ()
	{
		while (true)
		{
			object obj = (BuddyCache)this.m_Ⴈ.GetObject(ႥႥ.Ⴍ(7, 1580608801, '`', null));
			while (true)
			{
				IL_0049:
				int num = 4;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
					case 1:
						break;
					case 5:
						goto IL_0049;
					case 4:
					{
						BuddyCache result = obj as BuddyCache;
						UserCmd.Ⴅ[356] = (byte)((UserCmd.Ⴅ[356] * UserCmd.Ⴅ[195]) & 0x6F);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	internal AnnCache Ⴀ()
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		while (true)
		{
			object obj = (AnnCache)this.m_Ⴈ.GetObject(WxFilters.Ⴀ(null, 0, 103387781));
			while (true)
			{
				IL_0059:
				int num = ⴗ[38] - ⴗ[38];
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴗ[158] - 28145;
						continue;
					case 5:
						break;
					case 1:
					case 2:
						goto IL_0059;
					case 0:
					case 4:
					{
						AnnCache result = (AnnCache)obj;
						Bye.Ⴄ[283] = (char)(Bye.Ⴄ[283] & UserCmd.Ⴅ[229] & 0x63);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	internal ArcConnectsCache Ⴃ()
	{
		while (true)
		{
			object obj = (ArcConnectsCache)this.m_Ⴈ.GetObject(ClientCty.Ⴗ('Ô', 3, 307013361));
			while (true)
			{
				IL_004b:
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 4;
						continue;
					case 4:
						break;
					case 5:
						goto IL_004b;
					case 0:
					case 1:
					case 2:
						return obj as ArcConnectsCache;
					}
					break;
				}
				break;
			}
		}
	}

	internal CtyHdgDistCache Ⴈ()
	{
		while (true)
		{
			object obj = (CtyHdgDistCache)this.m_Ⴈ.GetObject(ႥႥ.Ⴅ(1673508351, null, 6));
			while (true)
			{
				IL_0047:
				int num = 0;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 5;
						continue;
					case 2:
					case 5:
						break;
					case 1:
						goto IL_0047;
					case 0:
					case 3:
					{
						CtyHdgDistCache result = obj as CtyHdgDistCache;
						Bye.Ⴄ[27] = (char)((Bye.Ⴄ[27] - HighlightCtyCfg.ႠႠ[110]) & 0x8B);
						return result;
					}
					}
					break;
				}
				break;
			}
		}
	}

	internal CtyCache Ⴄ()
	{
		while (true)
		{
			object obj = (CtyCache)this.m_Ⴈ.GetObject(ႥႥ.Ⴍ(8, 1580608989, 'æ', null));
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
				case 5:
					break;
				case 0:
				case 2:
				case 4:
				{
					CtyCache result = (CtyCache)obj;
					Bye.Ⴄ[251] = (char)((Bye.Ⴄ[251] * Bye.Ⴄ[195]) & 0x75);
					return result;
				}
				}
				break;
			}
		}
	}

	internal WxCache Ⴗ()
	{
		while (true)
		{
			object obj = (WxCache)this.m_Ⴈ.GetObject(WxFilters.Ⴀ(null, 8, 103387826));
			while (true)
			{
				IL_0047:
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
						break;
					case 3:
						goto IL_0047;
					case 5:
						return (WxCache)obj;
					}
					break;
				}
				break;
			}
		}
	}

	internal WwvCache Ⴅ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		while (true)
		{
			object obj = (WwvCache)this.m_Ⴈ.GetObject(ClientCty.Ⴗ('Ì', 3, 307013402));
			while (true)
			{
				IL_0051:
				int num = ⴀႠ[35] - 25311;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
						break;
					case 5:
						goto IL_0051;
					case 2:
					case 4:
						return obj as WwvCache;
					}
					break;
				}
				break;
			}
		}
	}

	internal MultimediaCache Ⴜ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		while (true)
		{
			object obj = (MultimediaCache)this.m_Ⴈ.GetObject(ႥႥ.Ⴅ(1673508229, null, 4));
			while (true)
			{
				IL_0056:
				int num = ⴀႠ[16] - 39565;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႠ[81] - 54676;
						continue;
					case 4:
						break;
					case 3:
						goto IL_0056;
					case 0:
					case 5:
						return (MultimediaCache)obj;
					}
					break;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ႥႭ()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static DataColumnCollection ႳႷ<_0021_00210>(_0021_00210 P_0, short P_1, char P_2) where _0021_00210 : DataTable
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		InternalDataCollectionBase internalDataCollectionBase = default(InternalDataCollectionBase);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴄ[117] - 41899;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴅ[0] - 155;
					continue;
				case 3:
				case 7:
					break;
				case 2:
					num2 = (((P_1 ^ P_2) - 9) ^ num) switch
					{
						0 => 0, 
						_ => 8, 
					};
					continue;
				case 8:
					internalDataCollectionBase = null;
					num2 = 11;
					continue;
				case 0:
					internalDataCollectionBase = P_0.Columns;
					num2 = 11;
					continue;
				case 11:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 4;
				case 4:
					num2 = ⴄ[52] - 25104;
					continue;
				case 5:
					num2 = ((num3 % 2 != 0) ? 2 : 9);
					continue;
				case 6:
				case 9:
					return (DataColumnCollection)internalDataCollectionBase;
				case 1:
					num2 = ⴀႠ[90] - 47369;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႳႳ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, short P_3) where _0021_00210 : Symbol where _0021_00211 : Fill
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 5;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴄ[262] - 58208;
				continue;
			case 4:
				num = (((P_2 ^ P_3) - 14) ^ num2) switch
				{
					0 => 8, 
					_ => 7, 
				};
				continue;
			case 7:
				num = ⴗ[161] - 4997;
				continue;
			case 0:
			case 8:
				P_0.Fill = P_1;
				break;
			case 1:
			case 2:
				break;
			case 3:
			case 6:
				return;
			}
			num2++;
			int num3 = 492;
			int num4 = 126;
			num = ((246 < num3 / 2 - num4) ? (ⴗ[41] - 23800) : 3);
		}
	}

	[SecuritySafeCritical]
	internal static string ႳႣ<_0021_00210, _0021_00211, _0021_00212>(_0021_00210 P_0, _0021_00212 P_1, _0021_00211 P_2, char P_3, int P_4)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		object obj = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴀႠ[34] - 62553;
					continue;
				case 11:
					break;
				case 5:
					num2 = (((P_3 ^ P_4) - 59) ^ num) switch
					{
						0 => ⴗ[158] - 28143, 
						_ => ⴄ[176] - 2243, 
					};
					continue;
				case 1:
					obj = null;
					goto case 4;
				case 4:
				case 8:
					num2 = 6;
					continue;
				case 7:
					obj = string.Concat(P_0, P_1, P_2);
					num2 = 6;
					continue;
				case 6:
					num++;
					num2 = (((P_3 * P_3 + P_3) % 2 == 0) ? 2 : 0);
					continue;
				case 0:
					num2 = ⴀႠ[112] - 45129;
					continue;
				case 2:
				case 10:
					return obj as string;
				case 9:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႳႭ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 4;
					continue;
				case 4:
					break;
				case 6:
					num2 = (((P_3 ^ P_2) - 45) ^ num) switch
					{
						0 => 5, 
						_ => 8, 
					};
					continue;
				case 8:
					obj = null;
					num2 = 11;
					continue;
				case 5:
					obj = string.Concat(P_0, P_1);
					num2 = 11;
					continue;
				case 1:
				case 3:
				case 11:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = ⴗ[69] - 62803;
					continue;
				case 2:
					num2 = ((num3 % 2 != 0) ? 6 : (ⴄ[256] - 65030));
					continue;
				case 10:
					return obj as string;
				case 9:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}
}

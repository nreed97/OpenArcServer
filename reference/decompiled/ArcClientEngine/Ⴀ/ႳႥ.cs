using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Security;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcIo.Tcp;
using ZedGraph;

namespace Ⴀ;

[TypeConverter(typeof(ExpandableObjectConverter))]
internal sealed class ႳႥ
{
	internal sealed class ႥႳ
	{
		internal DxFilters Ⴅ;

		internal ႥႳ()
		{
		}
	}

	private string m_Ⴓ;

	private string m_Ⴅ;

	private DateTime Ⴍ;

	private ႥႤ.Ⴃ Ⴗ = new ႥႤ.Ⴃ();

	[Description("Arc Node")]
	internal string Ⴈ
	{
		get
		{
			return Ⴗ.Ⴀ;
		}
		set
		{
			Ⴗ.Ⴀ = text as string;
		}
	}

	[Description("IP Address")]
	internal string Ⴓ
	{
		get
		{
			return this.m_Ⴓ;
		}
		set
		{
			this.m_Ⴓ = ⴓ;
		}
	}

	[Description("Port (default 3608)")]
	internal int Ⴐ
	{
		get
		{
			return Ⴗ.Ⴓ;
		}
		set
		{
			Ⴗ.Ⴓ = ⴓ;
		}
	}

	[Description("Connect As")]
	internal string Ⴐ
	{
		get
		{
			char[] ⴄ = Bye.Ⴄ;
			return Ⴗ.Ⴃ;
		}
		set
		{
			Ⴗ.Ⴃ = text;
		}
	}

	[Description("Enabled")]
	internal bool Ⴈ
	{
		get
		{
			char[] ⴗ = global::Ⴀ.ႥႰ.Ⴗ;
			return Ⴗ.Ⴍ;
		}
		set
		{
			bool ⴍ = flag;
			Ⴗ.Ⴍ = ⴍ;
		}
	}

	[Browsable(true)]
	internal bool Ⴅ
	{
		get
		{
			return Ⴗ.Ⴅ;
		}
		set
		{
			bool ⴅ = flag;
			Ⴗ.Ⴅ = ⴅ;
		}
	}

	[Browsable(true)]
	internal string Ⴅ
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return this.m_Ⴅ;
		}
		set
		{
			this.m_Ⴅ = ⴅ;
		}
	}

	[Browsable(true)]
	internal DateTime Ⴀ
	{
		get
		{
			return Ⴍ;
		}
		set
		{
			Ⴍ = ⴍ;
		}
	}

	[Browsable(true)]
	internal long Ⴐ
	{
		get
		{
			return Ⴗ.Ⴗ;
		}
		set
		{
			Ⴗ.Ⴗ = ⴗ;
		}
	}

	[Browsable(true)]
	internal string Ⴃ
	{
		get
		{
			char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
			return Ⴗ.Ⴈ;
		}
		set
		{
			Ⴗ.Ⴈ = text as string;
		}
	}

	internal ႳႥ()
	{
	}

	public override string ToString()
	{
		char[] ⴗ = global::Ⴀ.ႥႰ.Ⴗ;
		string result = global::Ⴀ.ႥႥ.Ⴅ(1673508552, null, 3);
		HighlightCtyCfg.ႠႠ[73] = (char)(HighlightCtyCfg.ႠႠ[73] & UserCmd.Ⴅ[405] & 0x23);
		return result;
	}

	[SecuritySafeCritical]
	static ႳႥ()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static Chart ႥႣ<_0021_00210>(_0021_00210 P_0, int P_1, short P_2) where _0021_00210 : GraphPane
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = global::Ⴀ.ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		ISerializable serializable = default(ISerializable);
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
					num2 = ⴄ[249] - 5081;
					continue;
				case 1:
				case 2:
				case 11:
					break;
				case 6:
					num2 = (((P_2 ^ P_1) - 37) ^ num) switch
					{
						0 => 8, 
						_ => 0, 
					};
					continue;
				case 0:
					serializable = null;
					num2 = 4;
					continue;
				case 8:
					serializable = P_0.Chart;
					num2 = ⴗ[159] - 58280;
					continue;
				case 3:
				case 4:
				{
					num++;
					int num3 = 182;
					int num4 = 486;
					num2 = ((3402 > num4 - num3 * 7) ? (ⴅ[309] - 245) : 10);
					continue;
				}
				case 10:
					num2 = ⴅ[25] * 3;
					continue;
				case 7:
					return serializable as Chart;
				case 9:
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႥႥ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : DxSpot
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = global::Ⴀ.ႥႰ.Ⴗ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴅ[102];
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 0;
					continue;
				case 0:
				case 4:
					break;
				case 10:
					num2 = (((P_2 ^ P_1) - 59) ^ num) switch
					{
						0 => 12, 
						1 => ⴅ[4], 
						2 => 13, 
						_ => 9, 
					};
					continue;
				case 9:
					obj = null;
					num2 = ⴄ[195] - 44486;
					continue;
				case 12:
					obj = P_0.Cty;
					num2 = 1;
					continue;
				case 8:
					obj = P_0.County;
					num2 = 1;
					continue;
				case 13:
					obj = P_0.Cont;
					num2 = ⴗ[129] - 40417;
					continue;
				case 1:
					num++;
					num3 = P_1 * P_1;
					goto case 6;
				case 6:
					num3 = P_1 + num3;
					num2 = 3;
					continue;
				case 3:
					num2 = ((num3 % 2 != 0) ? 10 : (ⴄ[192] - 48333));
					continue;
				case 7:
					return (string)obj;
				case 11:
					num2 = ⴅ[102];
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႭ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : TcpServer
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 1;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴅ[115];
				break;
			case 4:
				num = (((P_2 ^ P_1) - 29) ^ num2) switch
				{
					0 => 8, 
					_ => ⴄ[4] - 10466, 
				};
				break;
			case 6:
				num = ⴅ[17];
				break;
			case 8:
				P_0.Start();
				goto case 0;
			case 0:
				num2++;
				goto case 3;
			case 3:
			case 9:
				num = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴀႠ[55] - 49888) : (ⴀႠ[48] - 3654));
				break;
			case 7:
				num = ⴀႠ[111] - 49557;
				break;
			case 2:
			case 5:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool ႥႰ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2) where _0021_00210 : TcpClient
	{
		char[] ⴗ = global::Ⴀ.ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴗ[13] - 41498;
					continue;
				case 0:
					break;
				case 2:
				case 8:
					num2 = (((P_2 ^ P_1) - 83) ^ num) switch
					{
						0 => 3, 
						_ => ⴗ[103] - 55685, 
					};
					continue;
				case 6:
					result = false;
					goto case 4;
				case 4:
					num2 = 10;
					continue;
				case 3:
					result = P_0.IsConnected;
					num2 = 10;
					continue;
				case 9:
				case 10:
				{
					num++;
					int num3 = 2912;
					int num4 = 548;
					num2 = ((728 < num3 / 4 - num4) ? (ⴗ[48] - 52953) : 7);
					continue;
				}
				case 7:
					return result;
				case 1:
					num2 = ⴄ[248] - 4566;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႥႷ<_0021_00210>(_0021_00210 P_0, NotifyFilters P_1, short P_2, char P_3) where _0021_00210 : FileSystemWatcher
	{
		char[] ⴗ = global::Ⴀ.ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 4;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 3;
				break;
			case 3:
				num = (((P_3 ^ P_2) - 30) ^ num3) switch
				{
					0 => ⴗ[134] - 12477, 
					_ => 5, 
				};
				break;
			case 5:
				num = 2;
				break;
			case 6:
				P_0.NotifyFilter = P_1;
				goto case 2;
			case 2:
				num3++;
				num2 = P_3 * P_3;
				goto case 1;
			case 1:
				num2 = P_3 + num2;
				num = 7;
				break;
			case 7:
				num = ((num2 % 2 != 0) ? (ⴀႠ[96] - 2582) : 8);
				break;
			case 0:
			case 8:
			case 9:
				return;
			}
		}
	}
}

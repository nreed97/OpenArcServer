using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsVersion
{
	public static Version Version
	{
		get
		{
			while (true)
			{
				IEvidenceFactory evidenceFactory = FrmUpdateAvailable.ႷႥ(875, 773);
				ISerializable serializable = PrecisionTimer.ႤႤ(evidenceFactory as Assembly, '\u0096', 'é');
				int num = 1;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
					case 2:
					case 5:
						break;
					case 1:
					{
						object version = ((AssemblyName)serializable).Version;
						return version as Version;
					}
					}
					break;
				}
			}
		}
	}

	public static string ShortVersion
	{
		get
		{
			while (true)
			{
				IEquatable<Version> version = Version;
				object obj = new object[5];
				((object[])obj)[0] = UtilsCopyright.Ⴓ(version as Version, 607, 'Ʉ');
				int num = 6;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 7;
						continue;
					case 7:
						break;
					case 0:
					case 6:
						((object[])obj)[1] = ႣႼ.Ⴜ(8, 365386765, 12);
						((object[])obj)[2] = DirectoryMonitor.ႠႰ((Version)version, 694, 'ʀ');
						num = 1;
						continue;
					case 1:
						((object[])obj)[3] = ႣႼ.Ⴜ(8, 365386765, 20);
						goto case 3;
					case 3:
						(obj as object[])[4] = DgvBaseColumnFilter.ႨႠ((Version)version, '\u036c', 779);
						num = 5;
						continue;
					case 5:
					{
						IComparable comparable = string.Concat((object[])obj);
						return (string)comparable;
					}
					}
					break;
				}
			}
		}
	}

	public static string VeryShortVersion
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			IComparable comparable = default(IComparable);
			while (true)
			{
				object version = Version;
				object obj = new object[4];
				while (true)
				{
					IL_0055:
					(obj as object[])[0] = UtilsCopyright.Ⴓ((Version)version, 464, 'ǋ');
					int num = 7;
					while (true)
					{
						switch (num)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							num = ⴃႭ[245] - 52420;
							continue;
						case 3:
						case 6:
							break;
						case 1:
							goto IL_0055;
						case 7:
							((object[])obj)[1] = ႣႼ.Ⴜ(6, 365386755, 21);
							(obj as object[])[2] = DirectoryMonitor.ႠႰ((Version)version, 803, '\u0315');
							goto case 2;
						case 2:
							num = 4;
							continue;
						case 4:
							(obj as object[])[3] = ႣႼ.Ⴜ(4, 365386753, 28);
							comparable = string.Concat((object[])obj);
							num = 0;
							continue;
						case 0:
							return (string)comparable;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public static string LongVersion
	{
		get
		{
			ICloneable version = Version;
			string result = UtilsString.Ⴍ((object)(version as Version), '\u0349', 859);
			NeedsCfg.ႣႤ[312] = (NeedsCfg.ႣႤ[312] + DxCfg.Ⴗ[84]) & 0xDD;
			return result;
		}
	}

	public static string LongVersionAndBits
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			while (true)
			{
				IComparable<Version> version = Version;
				object obj = UtilsString.Ⴍ((object)(version as Version), 'Ǘ', 453);
				obj = ReverseBeaconClient.Ⴗ(obj as string, GetBits(), '\u0352', '\u031a');
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႣ[199] - 41516;
						continue;
					case 0:
					case 2:
					case 4:
						break;
					case 5:
						return (string)obj;
					}
					break;
				}
			}
		}
	}

	public static AssemblyName AssemblyName
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			while (true)
			{
				IEvidenceFactory evidenceFactory = FrmUpdateAvailable.ႷႥ(978, 956);
				while (true)
				{
					IL_0052:
					IDeserializationCallback deserializationCallback = PrecisionTimer.ႤႤ((Assembly)evidenceFactory, 'Ȥ', 'ɛ');
					while (true)
					{
						IL_0068:
						int num = ⴃႣ[103] - 47730;
						while (true)
						{
							switch (num)
							{
							default:
								/*OpCode not supported: LdMemberToken*/;
								num = ⴗ[93] - 712;
								continue;
							case 5:
								break;
							case 3:
								goto IL_0052;
							case 2:
								goto IL_0068;
							case 0:
							{
								AssemblyName result = deserializationCallback as AssemblyName;
								DataGridViewColumnSelector.Ⴐ[297] = (char)((DataGridViewColumnSelector.Ⴐ[297] * DataGridViewColumnSelector.Ⴐ[75]) & 0xA4);
								return result;
							}
							}
							break;
						}
						break;
					}
					break;
				}
			}
		}
	}

	public static string GetBits()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		while (true)
		{
			int num = ((!ServerIoCfg.ႤႳ(127, 108)) ? (ⴐ[361] - 22514) : (ⴃႣ[179] - 62088));
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
				case 4:
				case 5:
					return ႣႼ.Ⴜ(0, 365386777, 20);
				case 0:
				case 1:
				case 3:
					return ႣႼ.Ⴜ(7, 365386773, 16);
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static UtilsVersion()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static string Ⴀ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : WwvSpot
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = ⴃႣ[96] - 36632;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[215] - 32470;
					continue;
				case 10:
					break;
				case 2:
				{
					int num5 = P_1 ^ P_2;
					DataGridViewColumnSelector.Ⴐ[120] = (char)((DataGridViewColumnSelector.Ⴐ[120] + P_2) & 0xB5);
					num2 = ((num5 - 123) ^ num) switch
					{
						0 => 12, 
						1 => ⴃႣ[5] - 35951, 
						_ => 0, 
					};
					continue;
				}
				case 0:
				case 4:
					enumerable = null;
					num2 = 6;
					continue;
				case 12:
					enumerable = P_0.Sfi;
					num2 = ⴃႣ[70] - 48566;
					continue;
				case 9:
					enumerable = P_0.Spotter;
					num2 = ⴀ[114] - 58314;
					continue;
				case 6:
				case 7:
				{
					num++;
					int num3 = 97;
					int num4 = 292;
					num2 = ((2336 > num4 - num3 * 8) ? (ⴗ[136] - 24121) : 5);
					continue;
				}
				case 5:
				case 11:
					num2 = ⴃႭ[43] - 34348;
					continue;
				case 3:
					return enumerable as string;
				case 8:
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int Ⴓ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : BaseCollection
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 0:
				case 9:
					num2 = (((P_2 ^ P_1) - 6) ^ num) switch
					{
						0 => ⴀ[182] - 17965, 
						_ => ⴐ[225] - 26608, 
					};
					continue;
				case 6:
					result = P_1;
					num2 = 1;
					continue;
				case 2:
				case 3:
					result = P_0.Count;
					num2 = 1;
					continue;
				case 1:
					num++;
					num2 = (((P_2 * P_2 + P_2) % 2 == 0) ? 8 : 4);
					continue;
				case 4:
					num2 = ⴀ[329] - 29358;
					continue;
				case 5:
				case 8:
					return result;
				case 7:
					num2 = ⴃႣ[142] - ⴃႣ[142];
					continue;
				}
				break;
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.ArcCfg;
using Ⴈ;

namespace ArcEngine.ContestProcessing;

public class CallHistoryOverride
{
	public readonly Dictionary<string, string> OverrideList;

	public CallHistoryOverride()
	{
		OverrideList = new Dictionary<string, string>();
	}

	public void LoadOverrides(string filePath)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			object obj = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			try
			{
				int num = 0;
				object obj2 = default(object);
				IComparable<string> comparable = default(IComparable<string>);
				while (true)
				{
					switch (num)
					{
					default:
						obj2 = new StreamReader(obj as FileStream);
						goto case 3;
					case 3:
						comparable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, '\u0329', 868);
						goto case 10;
					case 10:
						num = 9;
						break;
					case 7:
						num = ((CallBlockCacheCfg.Ⴜ(comparable as string, 357, 260) <= 0) ? 1 : 6);
						break;
					case 5:
					case 6:
						num = (SetAnnDefault.Ⴍ((string)comparable, ႰႥ.Ⴅ(6, 'G', 952620228), 744, 698) ? (ⴄႤ[178] - 22) : 4);
						break;
					case 4:
						num = (SetAnnDefault.Ⴍ(comparable as string, SetStationClubHelp.Ⴍ(1, 3, 1747258012, null), 48, 98) ? 1 : ⴅ[210]);
						break;
					case 8:
						Ⴗ(comparable as string);
						goto case 1;
					case 1:
						comparable = SetAnnModeHelp.Ⴐ((TextReader)(StreamReader)obj2, 'ρ', 908);
						num = 9;
						break;
					case 9:
						num = (((string)comparable != null) ? 7 : (ⴃႰ[150] - 63827));
						break;
					case 2:
						return;
					}
				}
			}
			finally
			{
				int num2 = 5;
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						num3 = (((FileStream)obj == null) ? (ⴀ[52] - 59015) : (ⴃႰ[84] - 33));
						goto IL_018b;
					case 0:
						((IDisposable)(obj as FileStream)).Dispose();
						break;
					case 1:
					case 3:
						break;
					}
					break;
					IL_018b:
					num2 = num3;
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void Ⴗ(string P_0)
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				object obj2 = new char[1];
				(obj2 as char[])[0] = ',';
				obj = ArcEngine.ArcCmds.User.Operating.Mail.Directory.Ⴓ(P_0, (char[])obj2, 356, 306);
				num = 2;
				break;
			}
			case 1:
			case 2:
				if ((obj as string[]).Length == 3)
				{
					num = 5;
					break;
				}
				return;
			case 4:
			case 5:
				if (OverrideList.ContainsKey(((string[])obj)[0]))
				{
					num = ⴃႥ[152] - 55226;
					break;
				}
				OverrideList.Add(((string[])obj)[0], (obj as string[])[2]);
				return;
			case 6:
				OverrideList[((string[])obj)[0]] = ((string[])obj)[2];
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, int P_3) where _0021_00210 : string where _0021_00211 : WxCfg
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 8;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 7;
				continue;
			case 7:
				num = (((P_3 ^ P_2) - 105) ^ num2) switch
				{
					0 => ⴃႰ[100] - 44486, 
					_ => ⴀ[436] - 2472, 
				};
				continue;
			case 1:
			case 2:
				num = ⴄႤ[415] - 208;
				continue;
			case 6:
				P_0.Filter = P_1;
				break;
			case 0:
			case 4:
			case 5:
				break;
			case 3:
				return;
			}
			num2++;
			int num3 = 1550;
			int num4 = 275;
			num = ((775 < num3 / 2 - num4) ? 7 : 3);
		}
	}
}

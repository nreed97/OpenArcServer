using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Timers;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcInterfaces.Io;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Dx;

public class PrintDxFilters : IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴗ
	{
		internal string Ⴓ;

		internal string Ⴗ;

		internal string Ⴄ;

		internal string Ⴍ;

		internal Guid Ⴈ;

		internal SerializableConcurrentDictionary<Guid, ArcConnect> Ⴐ;

		internal string Ⴀ;

		internal bool Ⴃ;

		internal bool Ⴅ;

		internal ArcUserCfg Ⴜ;

		internal IIoClient ႷႳ;

		internal string ႷႷ;

		internal ObjectManager ႷႤ;

		internal string ႷႭ;
	}

	internal sealed class Ⴀ
	{
		internal OnIoClientRxEventHandler Ⴄ;

		internal OnIoClientDisconnectEventHandler Ⴀ;

		internal ႳႰ Ⴗ;

		internal Timer Ⴃ;

		internal DateTime Ⴓ;

		internal int Ⴐ;

		internal int Ⴈ;

		internal int Ⴍ;

		internal int Ⴅ;

		internal DateTime Ⴜ;

		internal double[] ႠႤ;

		internal Ⴀ()
		{
		}
	}

	public void Exec(NodeUserCmd cmd)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		try
		{
			int num = 6;
			object obj2 = default(object);
			ISerializable serializable = default(ISerializable);
			IConvertible convertible = default(IConvertible);
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = cmd.Ⴍ().Ⴅ().Ⴀ()
						.ႨႣ()
						.Ⴗ();
					serializable = ShowLog.Ⴍ(607, 'ɗ');
					num = ⴅ[99] / 4;
					continue;
				case 4:
					convertible = ShowUsersHelp.Ⴅ(SkimmerSpot.Ⴈ(DxSpotBlockCacheCfg.Ⴃ((Assembly)serializable, 451, 417), 283, 'Ď'), ShowSkimCtyHelp.Ⴍ(1216134820, 6, 'I'), 917, 987);
					goto case 0;
				case 0:
					num = ⴃႰ[177] - 20355;
					continue;
				case 5:
					obj = new StreamWriter((string)convertible);
					break;
				case 1:
					break;
				}
				break;
			}
			List<string>.Enumerator enumerator = (obj2 as List<string>).GetEnumerator();
			try
			{
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = ⴄႭ[66] * 6;
						continue;
					case 5:
					{
						IEquatable<string> current = enumerator.Current;
						SetStationBeep.Ⴄ((TextWriter)obj, current as string, 855, 852);
						break;
					}
					case 0:
						break;
					case 1:
					case 3:
						goto end_IL_00e3;
					}
					num2 = ((!enumerator.MoveNext()) ? 1 : (ⴄႭ[172] - 173));
					continue;
					end_IL_00e3:
					break;
				}
			}
			finally
			{
				switch (2)
				{
				default:
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					break;
				case 1:
					break;
				}
			}
			switch (0)
			{
			default:
				((TextWriter)obj).Close();
				break;
			case 2:
				break;
			}
		}
		catch (Exception)
		{
		}
		switch (0)
		{
		}
	}

	[SecuritySafeCritical]
	internal static DateTime Ⴄ(char P_0, char P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		DateTime dateTime = default(DateTime);
		DateTime result = default(DateTime);
		while (true)
		{
			int num = 0;
			int num2 = ⴄႤ[135];
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
				case 5:
					num2 = (((P_0 ^ P_1) - 99) ^ num) switch
					{
						0 => 8, 
						_ => ⴅ[210] / 8, 
					};
					continue;
				case 1:
					dateTime = default(DateTime);
					goto case 0;
				case 0:
					result = dateTime;
					num2 = 6;
					continue;
				case 8:
					result = DateTime.Now;
					num2 = ⴍႭ[239] - 12402;
					continue;
				case 6:
				case 10:
				{
					num++;
					int num3 = 80;
					int num4 = 17;
					num2 = ((20 < num3 / 4 - num4) ? 5 : 3);
					continue;
				}
				case 3:
					return result;
				case 2:
				case 9:
					num2 = ⴃႠ[165] - 47290;
					continue;
				}
				break;
			}
		}
	}
}

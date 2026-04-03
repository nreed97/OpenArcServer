using System;
using System.Collections.Generic;
using System.Threading;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.ArcWeb;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcIo.Arc4;

public sealed class V4NodeParser
{
	private static readonly ILog Ⴈ;

	private static readonly object Ⴓ;

	private static readonly V4NodeParser Ⴈ;

	private int Ⴓ;

	private readonly int Ⴄ;

	private readonly string Ⴍ = string.Empty;

	private readonly string Ⴓ = string.Empty;

	private readonly string Ⴃ = string.Empty;

	private readonly string[] Ⴐ;

	private DeleteMailHelp.Ⴈ Ⴗ = new DeleteMailHelp.Ⴈ();

	public static V4NodeParser GetInstance => Ⴈ;

	static V4NodeParser()
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				V4NodeParser.Ⴈ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687352870, 5, 30), 873, 884);
				goto IL_0044;
			case 2:
				goto IL_0044;
			case 0:
				V4NodeParser.Ⴓ = new object();
				break;
			case 4:
				break;
			}
			break;
			IL_0044:
			num = ⴄႤ[65] - 48;
		}
		Ⴈ = new V4NodeParser();
	}

	private V4NodeParser()
	{
		IComparable empty = string.Empty;
		Ⴗ.Ⴄ = empty as string;
		Ⴐ = new string[97];
		base._002Ector();
		Ⴍ = SetTalkCount.Ⴗ(6, null, 1267019956, typeof(YahooGeoRef));
		Ⴍ = ShowUsersHelp.Ⴅ(Ⴍ, ႰႼ.Ⴓ('\r', '\u0364', 775), 468, 410);
		Ⴍ = ShowUsersHelp.Ⴅ(Ⴍ, ႰႼ.Ⴓ('\n', 'ϥ', 902), 750, 672);
		Ⴍ = ShowUsersHelp.Ⴅ(Ⴍ, ႰႼ.Ⴓ('"', 'F', 37), 142, 192);
		int num = 0;
		Ⴄ = CallBlockCacheCfg.Ⴜ(Ⴍ, 652, 749);
		Ⴐ[0] = Ⴍ;
		for (int i = 1; i < Ⴄ; i++)
		{
			Ⴓ = SetTalkOutputHelp.Ⴍ(Ⴐ[num], 0, 1, 765, 686);
			Ⴃ = Ⴐ[num].Substring(1, Ⴄ - 1);
			Ⴐ[i] = Ⴃ + Ⴓ;
			num++;
		}
	}

	public string Parse(string sKey, string sText)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		bool flag = false;
		object ⴓ = default(object);
		IComparable comparable2 = default(IComparable);
		try
		{
			int num = 0;
			IConvertible convertible = default(IConvertible);
			int num5 = default(int);
			int num3 = default(int);
			int num6 = default(int);
			int num4 = default(int);
			IEnumerable<char> enumerable2 = default(IEnumerable<char>);
			while (true)
			{
				switch (num)
				{
				default:
					ႨႥ.Ⴍ(ⴓ = V4NodeParser.Ⴓ, ref flag, 789, 796);
					convertible = sText;
					break;
				case 3:
				case 5:
					break;
				case 2:
				{
					IEnumerable<char> enumerable = string.Empty;
					try
					{
						int num2 = 11;
						while (true)
						{
							switch (num2)
							{
							default:
							{
								this.Ⴓ = CallBlockCacheCfg.Ⴜ(sText, 347, 314);
								int ⴐ2 = CallBlockCacheCfg.Ⴜ(sKey, 221, 188);
								Ⴗ.Ⴐ = ⴐ2;
								num2 = 15;
								continue;
							}
							case 15:
								num5 = 0;
								num3 = 0;
								num2 = 4;
								continue;
							case 2:
							{
								IComparable<string> comparable = SetTalkOutputHelp.Ⴍ(convertible as string, num3, 1, 103, 52);
								num6 = ShowNodes.Ⴄ(Ⴍ, comparable as string, 839, 888);
								num2 = 14;
								continue;
							}
							case 14:
							{
								object obj = SetTalkOutputHelp.Ⴍ(sKey, num5, 1, 218, 137);
								Ⴗ.Ⴄ = (string)obj;
								num2 = ⴃႰ[11] - 51456;
								continue;
							}
							case 1:
							case 13:
								num4 = 0;
								num2 = ⴄႷ[126] - 39167;
								continue;
							case 5:
								num2 = ((!ByeHelp.Ⴍ(SetTalkOutputHelp.Ⴍ(Ⴐ[num4], num6, 1, 628, 551), Ⴗ.Ⴄ, 580, 547)) ? 12 : (ⴐ[126] + ⴐ[367]));
								continue;
							case 17:
								enumerable2 = SetTalkOutputHelp.Ⴍ(Ⴐ[num4], 0, 1, 53, 102);
								num2 = ⴀႳ[348] - 48482;
								continue;
							case 8:
								enumerable = ShowUsersHelp.Ⴅ(enumerable as string, (string)enumerable2, 483, 429);
								goto case 6;
							case 6:
								num2 = 9;
								continue;
							case 12:
								num4++;
								num2 = ⴀႨ[143] - 64088;
								continue;
							case 3:
							case 16:
								num2 = ((num4 < Ⴄ) ? 5 : 9);
								continue;
							case 9:
								num5++;
								num2 = ((num5 < Ⴗ.Ⴐ) ? 7 : 0);
								continue;
							case 0:
								num5 = 0;
								num2 = ⴀႣ[0] - 46446;
								continue;
							case 7:
								num3++;
								num2 = 4;
								continue;
							case 4:
								num2 = ((num3 < this.Ⴓ) ? 2 : (ⴍႤ[54] - 39923));
								continue;
							case 10:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						V4NodeParser.Ⴈ.Error((ex as Exception).Message);
						comparable2 = null;
						goto end_IL_0073;
					}
					switch (2)
					{
					default:
						comparable2 = (string)enumerable;
						break;
					case 4:
						break;
					}
					goto end_IL_0073;
				}
				}
				num = ⴍႤ[284] - 31693;
				continue;
				end_IL_0073:
				break;
			}
		}
		finally
		{
			int num7 = 3;
			while (true)
			{
				int num8;
				switch (num7)
				{
				default:
					num8 = ((!flag) ? 4 : 0);
					goto IL_038b;
				case 0:
				case 5:
					Monitor.Exit(ⴓ);
					break;
				case 2:
				case 4:
					break;
				}
				break;
				IL_038b:
				num7 = num8;
			}
		}
		return 3 switch
		{
			_ => (string)comparable2, 
		};
	}
}

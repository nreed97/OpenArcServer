using System;
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
using log4net;

namespace Ⴀ;

internal sealed class ႥႨ
{
	private delegate UserCmd ႭႤ(UserCmd P_0);

	private static readonly ILog Ⴗ;

	private readonly ArcClientObjMgr m_Ⴍ;

	private MultimediaCache.Ⴀ Ⴐ = new MultimediaCache.Ⴀ();

	internal ႥႨ(ArcClientObjMgr P_0)
	{
		this.m_Ⴍ = P_0;
		object obj = new UserCmdLookup();
		Ⴐ.Ⴈ = (UserCmdLookup)obj;
	}

	internal void Ⴍ(string P_0, ႥႼ P_1)
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 5;
		object obj7 = default(object);
		object obj4 = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				P_0 = ShowDxFilter.Ⴍ(P_0, 'ˑ', 764);
				obj7 = new UserCmd(P_1);
				goto case 1;
			case 1:
				((UserCmd)obj7).RxMsg = P_0;
				goto case 4;
			case 4:
				num = ⴄ[237] - 13500;
				break;
			case 0:
			case 3:
				if (SetDxExtension.Ⴀ(P_0, 900, 909))
				{
					num = 2;
					break;
				}
				while (true)
				{
					Ⴗ.Error(P_0);
					while (true)
					{
						IL_00c6:
						object obj = Ⴀ(P_0);
						int num2 = (((UserCmdCfg)obj == null) ? (ⴀႠ[81] - 54675) : (ⴅ[4] / 8));
						while (true)
						{
							switch (num2)
							{
							default:
								/*OpCode not supported: LdMemberToken*/;
								return;
							case 3:
								break;
							case 4:
								goto IL_00c6;
							case 0:
							case 1:
								goto IL_00ed;
							case 5:
								P_1.ႳႷ(WxFilters.Ⴀ(null, 8, 103388329));
								return;
							case 2:
								return;
							}
							break;
							IL_00ed:
							if (SetDxExtension.Ⴀ(ႥႤ.Ⴅ(obj as UserCmdCfg, 677, 'ʒ'), 834, 843))
							{
								num2 = 5;
								continue;
							}
							try
							{
								int num3 = 0;
								while (true)
								{
									switch (num3)
									{
									default:
										obj4 = this.m_Ⴍ.Ⴍ().Ⴈ(ႥႤ.Ⴅ((UserCmdCfg)obj, 705, '\u02f6'));
										num3 = ⴄ[214] - 20666;
										continue;
									case 5:
									{
										object obj3 = new ႭႤ((obj4 as ႥႳ).Process);
										Delegate obj5 = (Delegate)obj3;
										object obj6 = new object[1];
										((object[])obj6)[0] = (UserCmd)obj7;
										obj2 = new ႳႳ(obj5, obj6 as object[]);
										goto case 1;
									}
									case 1:
									case 3:
										num3 = ⴄ[159] - 48365;
										continue;
									case 2:
									case 4:
										ႳႭ.Ⴓ((ႳႳ)obj2);
										break;
									}
									break;
								}
							}
							catch (Exception ex)
							{
								Ⴗ.Error((ex as Exception).Message);
								P_1.ႳႷ(ႥႥ.Ⴅ(1673506867, null, 0));
							}
							switch (3)
							{
							}
							return;
						}
						break;
					}
				}
			case 2:
				P_1.ႥႣ();
				return;
			}
		}
	}

	private UserCmdCfg Ⴀ(string P_0)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		byte[] ⴅ = UserCmd.Ⴅ;
		while (true)
		{
			object obj = null;
			string text = FilterViewer.ႨႷ(P_0, 967, 1004);
			Array array = new char[2];
			((char[])array)[0] = ' ';
			(array as char[])[1] = '/';
			object obj2 = ႳႳ.Ⴄ(text, array as char[], 885, '\u033a');
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 10;
					continue;
				case 9:
				case 10:
					break;
				case 1:
					num = ((((string[])obj2).Length > 3) ? 15 : 0);
					continue;
				case 15:
				{
					UserCmdLookup ⴈ = Ⴐ.Ⴈ;
					Array array2 = new object[7];
					(array2 as object[])[0] = (obj2 as string[])[0];
					((object[])array2)[1] = ' ';
					((object[])array2)[2] = (obj2 as string[])[1];
					((object[])array2)[3] = ' ';
					(array2 as object[])[4] = (obj2 as string[])[2];
					((object[])array2)[5] = ' ';
					(array2 as object[])[6] = ((string[])obj2)[3];
					obj = ⴈ.GetCmdTag(ShowDxFilter.Ⴓ(array2 as object[], 639, 570));
					num = 0;
					continue;
				}
				case 0:
				case 12:
					num = (((UserCmdCfg)obj != null) ? 7 : 6);
					continue;
				case 6:
					num = ((((string[])obj2).Length <= 2) ? 7 : 2);
					continue;
				case 2:
				{
					UserCmdLookup ⴈ2 = Ⴐ.Ⴈ;
					object obj3 = new object[5];
					(obj3 as object[])[0] = ((string[])obj2)[0];
					((object[])obj3)[1] = ' ';
					((object[])obj3)[2] = (obj2 as string[])[1];
					(obj3 as object[])[3] = ' ';
					((object[])obj3)[4] = (obj2 as string[])[2];
					obj = ⴈ2.GetCmdTag(ShowDxFilter.Ⴓ((object[])obj3, 796, 857));
					num = 7;
					continue;
				}
				case 7:
					num = (((UserCmdCfg)obj != null) ? 11 : (ⴗ[85] - 18011));
					continue;
				case 3:
					num = (((obj2 as string[]).Length <= 1) ? 11 : 4);
					continue;
				case 4:
					obj = Ⴐ.Ⴈ.GetCmdTag(ႥႭ.ႳႣ((object)(obj2 as string[])[0], (object)' ', (object)((string[])obj2)[1], 'ȟ', 548));
					num = 11;
					continue;
				case 11:
				case 13:
					num = ((obj is UserCmdCfg) ? 8 : (ⴀႠ[92] - 62198));
					continue;
				case 5:
					obj = Ⴐ.Ⴈ.GetCmdTag(((string[])obj2)[0]);
					num = ⴅ[4];
					continue;
				case 8:
					return obj as UserCmdCfg;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	static ႥႨ()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴗ = HighlightItuZoneCfg.Ⴓ(ClientCty.Ⴗ('j', 4, 307011758), 592, 608);
	}
}

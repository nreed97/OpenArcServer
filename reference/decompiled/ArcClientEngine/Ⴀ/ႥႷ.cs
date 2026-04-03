using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;

namespace Ⴀ;

internal sealed class ႥႷ
{
	private readonly ArcClientObjMgr Ⴐ;

	private FileSystemWatcher m_Ⴍ;

	private DateTime Ⴗ = DateTime.MinValue;

	internal ႥႷ(ArcClientObjMgr P_0)
	{
		Ⴐ = P_0;
		Ⴍ();
	}

	internal void Ⴍ()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 0;
		ICloneable cloneable = default(ICloneable);
		while (true)
		{
			switch (num)
			{
			default:
			{
				ICustomAttributeProvider customAttributeProvider = WxFilters.ႭႭ(261, 302);
				cloneable = HighlightCfg.ႳႳ(ႥႠ.Ⴅ((Assembly)customAttributeProvider, 902, 954), '϶', 922);
				num = ⴀႠ[9] - 28062;
				continue;
			}
			case 5:
			{
				Component component = new FileSystemWatcher();
				ArcClientConnectDat.ႷႣ(component as FileSystemWatcher, DxFilters.Ⴈ((string)cloneable, ClientCty.Ⴗ('\u00b8', 4, 307012294), 505, 417), 344, 295);
				ႳႥ.ႥႷ(component as FileSystemWatcher, NotifyFilters.LastWrite, 82, 'L');
				((FileSystemWatcher)component).Filter = ClientCty.Ⴗ('Ä', 1, 307012334);
				this.m_Ⴍ = (FileSystemWatcher)component;
				num = ⴄ[300] - 46375;
				continue;
			}
			case 3:
				this.m_Ⴍ.Changed += Ⴀ;
				break;
			case 1:
			case 2:
				break;
			case 4:
				return;
			}
			break;
		}
		this.m_Ⴍ.EnableRaisingEvents = true;
	}

	private void Ⴀ(object P_0, FileSystemEventArgs P_1)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 4;
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			switch (num)
			{
			default:
			{
				DateTime dateTime = FilterPicker.ႥႰ('ˢ', 'ʿ');
				timeSpan = WxFilters.ႭႥ(ref dateTime, Ⴗ, 299, 'ū');
				goto case 1;
			}
			case 1:
				num = 5;
				break;
			case 2:
			case 5:
				Ⴗ = FilterPicker.ႥႰ('Λ', 'φ');
				if (AnnFilters.Ⴍ(ref timeSpan, 792, '\u036b') < 2.0)
				{
					num = ⴄ[295] - 49141;
					break;
				}
				while (true)
				{
					IComparable comparable;
					int num2 = (((comparable = FilterViewer.ႨႷ(FilterViewer.ႨႰ(P_1, 470, 'ƛ'), 871, 844)) == null) ? (ⴀႠ[9] - 28060) : (ⴄ[83] - 37160));
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 5:
						case 6:
							break;
						case 0:
							num3 = (DxCommentExtCfg.ႤႰ(comparable as string, ClientCty.Ⴗ('\u0011', 2, 307012325), 'Ķ', 272) ? 3 : 4);
							goto IL_013d;
						case 4:
							return;
						case 3:
							Ⴐ.Caches.CtyHdgDist.Init();
							Ⴐ.Caches.CtyHdgDist.UpdateHeadingRange(Ⴐ.Cfg.Info.Latitude, Ⴐ.Cfg.Info.Longitude);
							return;
						case 7:
							return;
						}
						break;
						IL_013d:
						num2 = num3;
					}
				}
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static ႥႷ()
	{
		ArcClientConnectDat.Ⴍ();
	}

	[SecuritySafeCritical]
	internal static void Ⴓ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, int P_2, int P_3) where _0021_00210 : DataColumnCollection where _0021_00211 : DataColumn
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴗ = ႥႰ.Ⴗ;
		int num = 5;
		int num4 = default(int);
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num4 = 0;
				num = ⴀႠ[96] - 2578;
				break;
			case 7:
				num = (((P_2 ^ P_3) - 79) ^ num4) switch
				{
					0 => 6, 
					_ => 1, 
				};
				break;
			case 1:
			case 4:
				num = ⴗ[72] - 15841;
				break;
			case 2:
			case 6:
				P_0.Add(P_1);
				goto case 8;
			case 8:
			{
				num4++;
				num3 = 1031;
				int num5 = num3;
				num2 = num5 * num5;
				num = 0;
				break;
			}
			case 0:
				num2 = num3 + num2;
				num = ((num2 % 2 != 0) ? 7 : 9);
				break;
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴃ<_0021_00210>(_0021_00210 P_0, int P_1, int P_2, char P_3) where _0021_00210 : TreeView
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 10;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴅ[17];
				break;
			case 0:
				num = (((P_3 ^ P_2) - 1) ^ num3) switch
				{
					0 => 3, 
					1 => ⴗ[32] - 52741, 
					2 => ⴀႠ[26] - 10577, 
					_ => 7, 
				};
				break;
			case 7:
				num = 1;
				break;
			case 3:
			case 8:
			case 11:
				P_0.ImageIndex = P_1;
				num = 1;
				break;
			case 9:
				P_0.SelectedImageIndex = P_1;
				num = 1;
				break;
			case 4:
				P_0.Indent = P_1;
				goto case 1;
			case 1:
			case 6:
				num3++;
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴅ[285];
				break;
			case 5:
				num = ((num2 % 2 == 0) ? (ⴀႠ[61] - 26819) : 0);
				break;
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void Ⴄ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Form
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 9;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 8;
				break;
			case 8:
				num = (((P_2 ^ P_1) - 23) ^ num3) switch
				{
					0 => 7, 
					_ => 5, 
				};
				break;
			case 5:
				num = 0;
				break;
			case 7:
				P_0.Close();
				goto case 0;
			case 0:
			case 3:
			case 6:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 2;
				break;
			case 2:
				num = ((num2 % 2 != 0) ? 8 : (ⴄ[296] - 33847));
				break;
			case 1:
			case 4:
				return;
			}
		}
	}
}

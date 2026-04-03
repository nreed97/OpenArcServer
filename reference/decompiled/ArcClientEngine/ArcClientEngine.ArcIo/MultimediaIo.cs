using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Threading;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcForms;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using ArcInterfaces.Spots;
using ArcShared.ArcUtils;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcIo;

public sealed class MultimediaIo
{
	private static readonly ILog Ⴐ;

	private Thread m_Ⴈ;

	private HighlightSpotterCfg.ႤႰ m_Ⴓ;

	internal MultimediaIo(ArcClientObjMgr P_0)
	{
		DateTime minValue = DateTime.MinValue;
		this.m_Ⴓ.Ⴈ = minValue;
		base._002Ector();
		this.m_Ⴓ.Ⴍ = P_0 as ArcClientObjMgr;
	}

	public void Init()
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 2;
		ICustomAttributeProvider customAttributeProvider = default(ICustomAttributeProvider);
		IComparable comparable = default(IComparable);
		while (true)
		{
			switch (num)
			{
			default:
			{
				ICloneable cloneable2 = TelnetServerCfg.Ⴗ(this.m_Ⴓ.Ⴍ.Cfg.Multimedia.MultimediaFilter, SqlFilterType.Dx, 'Ή', 939);
				this.m_Ⴓ.Ⴃ = (string)cloneable2;
				num = 4;
				break;
			}
			case 4:
				customAttributeProvider = WxFilters.ႭႭ(610, 585);
				goto case 5;
			case 5:
				comparable = HighlightCfg.ႳႳ(ႥႠ.Ⴅ((Assembly)customAttributeProvider, 337, 365), '»', 215);
				num = ⴀႠ[71] - 18557;
				break;
			case 6:
			{
				ICloneable cloneable = HighlightArrlSectionCfg.Ⴀ((string)comparable, WxFilters.Ⴀ(null, 7, 103388609), this.m_Ⴓ.Ⴍ.Cfg.Multimedia.AlertFile, 'ŀ', 332);
				this.m_Ⴓ.Ⴐ = cloneable as string;
				num = ⴀႠ[35] - 25312;
				break;
			}
			case 3:
			{
				IEquatable<string> equatable = (string)comparable + ႥႥ.Ⴍ(3, 1580608414, '\n', null);
				this.m_Ⴓ.Ⴅ = equatable as string;
				return;
			}
			case 1:
				return;
			}
		}
	}

	internal void Ⴓ(DxSpot P_0)
	{
		char[] ⴄ = Bye.Ⴄ;
		char[] ⴗ = ႥႰ.Ⴗ;
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				if (!this.m_Ⴓ.Ⴍ.Cfg.Multimedia.Alert)
				{
					num = 3;
					continue;
				}
				break;
			case 1:
			case 3:
				if (!this.m_Ⴓ.Ⴍ.Cfg.Multimedia.FullAnnounce)
				{
					num = 4;
					continue;
				}
				break;
			case 0:
			case 2:
			case 4:
				return;
			}
			break;
		}
		try
		{
			int num2 = 13;
			bool flag = default(bool);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				default:
					flag = this.m_Ⴓ.Ⴍ.Caches.Dx.Ⴓ(this.m_Ⴓ.Ⴃ);
					num2 = 1;
					continue;
				case 1:
					num2 = ((!flag) ? (ⴄ[259] - 4886) : 9);
					continue;
				case 9:
					num2 = (this.m_Ⴓ.Ⴍ.Caches.Ⴀ().Ⴍ(P_0) ? (ⴅ[291] - ⴅ[219]) : (ⴗ[25] - 16819));
					continue;
				case 8:
					num2 = ((!this.m_Ⴓ.Ⴍ.Cfg.Multimedia.Alert) ? (ⴀႠ[94] - 21821) : 6);
					continue;
				case 6:
					Ⴃ(this.m_Ⴓ.Ⴐ);
					goto case 7;
				case 7:
					num2 = ((!this.m_Ⴓ.Ⴍ.Cfg.Multimedia.FullAnnounce) ? (ⴅ[36] - 37) : 15);
					continue;
				case 5:
				case 15:
				{
					DateTime dateTime = FilterPicker.ႥႰ('š', 'ļ');
					timeSpan = WxFilters.ႭႥ(ref dateTime, this.m_Ⴓ.Ⴈ, 985, 'Ι');
					goto case 3;
				}
				case 3:
					num2 = 12;
					continue;
				case 12:
					num2 = ((DxFilters.Ⴐ(ref timeSpan, 864, 816) < 15) ? 2 : 0);
					continue;
				case 2:
					break;
				case 0:
				{
					DateTime ⴈ = FilterPicker.ႥႰ('ƃ', 'Ǟ');
					this.m_Ⴓ.Ⴈ = ⴈ;
					num2 = 10;
					continue;
				}
				case 10:
				case 11:
					this.m_Ⴓ.Ⴓ = P_0;
					Ⴈ();
					break;
				case 14:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴐ.Error((ex as Exception).Message);
		}
		switch (2)
		{
		}
	}

	private void Ⴈ()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 3:
			case 4:
				this.m_Ⴈ.Start();
				return;
			}
			CriticalFinalizerObject criticalFinalizerObject = new Thread(Ⴓ);
			DxFilters.Ⴀ((Thread)criticalFinalizerObject, ThreadPriority.Normal, 'ʱ', '\u02fc');
			ShowUsers.ႥႣ(criticalFinalizerObject as Thread, ႥႥ.Ⴅ(1673507627, null, 7), 'ι', 967);
			this.m_Ⴈ = criticalFinalizerObject as Thread;
			num = 3;
		}
	}

	private void Ⴃ(string P_0)
	{
		Component component = new SoundPlayer(P_0);
		TelnetServerCfg.ႳႷ(component as SoundPlayer, 45, 59);
	}

	private void Ⴓ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴄ(FilterViewer.ႨႥ(this.m_Ⴓ.Ⴓ, 189, '\u009d'));
				num = 4;
				break;
			case 4:
				Ⴃ(DxFilters.Ⴈ(this.m_Ⴓ.Ⴅ, ႥႥ.Ⴅ(1673507641, null, 6), 837, 797));
				num = 3;
				break;
			case 1:
			case 3:
				Ⴄ(WxFilters.ႭႤ(this.m_Ⴓ.Ⴓ, 839, 823).ToString());
				num = ⴅ[213] - 239;
				break;
			case 6:
				Ⴃ(this.m_Ⴓ.Ⴅ + ႥႥ.Ⴅ(1673507632, null, 0));
				return;
			case 5:
				return;
			}
		}
	}

	private void Ⴄ(string P_0)
	{
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 4;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = ⴀႠ[104] - 61264;
				break;
			case 6:
			{
				char c = SetDxFilter.Ⴈ(P_0, num2, 493, 437);
				Ⴀ(c);
				goto case 2;
			}
			case 2:
				num = ⴄ[119] - 8990;
				break;
			case 7:
				num2++;
				num = 3;
				break;
			case 3:
			case 5:
				num = ((num2 < P_0.Length) ? 6 : (ⴄ[217] - 54990));
				break;
			case 1:
				return;
			}
		}
	}

	private void Ⴀ(char P_0)
	{
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴀႠ = HighlightCtyCfg.ႠႠ;
		int num = 8;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		while (true)
		{
			switch (num)
			{
			case 4:
				num = ⴀႠ[101] - 46668;
				continue;
			case 0:
			case 3:
				enumerable = DxFilters.Ⴈ(this.m_Ⴓ.Ⴅ, WxFilters.Ⴀ(null, 2, 103388642), 542, 582);
				goto case 5;
			case 5:
				num = 1;
				continue;
			case 2:
			case 6:
				enumerable = DxFilters.Ⴈ(this.m_Ⴓ.Ⴅ, ႥႥ.Ⴅ(1673507789, null, 7), 227, 187);
				num = 1;
				continue;
			case 7:
				enumerable = this.m_Ⴓ.Ⴅ + P_0 + ClientCty.Ⴗ('ó', 7, 307011931);
				num = 1;
				continue;
			case 1:
				Ⴃ((string)enumerable);
				return;
			}
			enumerable = string.Empty;
			int num3;
			switch (P_0)
			{
			default:
				num3 = 4;
				break;
			case '.':
				num3 = 3;
				break;
			case '/':
			{
				char num2 = ⴗ[106];
				ႥႰ.Ⴗ[46] = (char)((ႥႰ.Ⴗ[46] - ႥႰ.Ⴗ[84]) & 0xBF);
				num3 = num2 - 22857;
				break;
			}
			}
			num = num3;
		}
	}

	[SecuritySafeCritical]
	static MultimediaIo()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴐ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴅ(1673507793, null, 8), 991, 1007);
	}
}

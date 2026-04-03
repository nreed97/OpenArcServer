using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Security;
using System.Windows.Forms;
using ArcClientEngine.ArcCaches;
using ArcClientEngine.ArcCfg;
using ArcClientEngine.ArcCfg.Filters;
using ArcClientEngine.ArcCfg.OldHighlightCode;
using ArcClientEngine.ArcObjs;
using ArcClientEngine.CmdProcessing;
using ArcClientEngine.CmdProcessing.UserCmds;
using log4net;
using Ⴀ;

namespace ArcClientEngine.ArcForms;

public class DxClusterNetwork : Form
{
	private IContainer Ⴐ;

	private TreeView Ⴈ;

	private static readonly ILog Ⴀ;

	private ArcClientObjMgr Ⴓ;

	private DxSpotRates.ႠႥ m_Ⴗ = new DxSpotRates.ႠႥ();

	protected override void Dispose(bool disposing)
	{
		char[] ⴄ = Bye.Ⴄ;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!disposing) ? (ⴄ[146] - 18551) : (ⴄ[159] - 48363));
				continue;
			case 4:
				num = ((Ⴐ == null) ? (ⴄ[302] - 8859) : (ⴄ[155] - 45034));
				continue;
			case 1:
			case 3:
				Ⴐ.Dispose();
				break;
			case 2:
			case 5:
				break;
			}
			break;
		}
		base.Dispose(disposing);
		UserCmd.Ⴅ[73] = (byte)((UserCmd.Ⴅ[73] - UserCmd.Ⴅ[160]) & 0xB1);
	}

	private void Ⴗ()
	{
		byte[] ⴅ = UserCmd.Ⴅ;
		char[] ⴗ = ႥႰ.Ⴗ;
		char[] ⴄ = Bye.Ⴄ;
		int num = 4;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
			{
				Ⴐ = new Container();
				obj = new ComponentResourceManager(typeof(DxClusterNetwork));
				IButtonControl buttonControl = new Button();
				this.m_Ⴗ.Ⴃ = buttonControl as Button;
				num = 0;
				break;
			}
			case 0:
			{
				Ⴈ = new TreeView();
				Component component = new ImageList(Ⴐ);
				this.m_Ⴗ.Ⴍ = (ImageList)component;
				num = 15;
				break;
			}
			case 15:
				AnnFilters.Ⴓ((Control)this, 'ǌ', 'Ǔ');
				HighlightCountyCfg.Ⴜ((Control)this.m_Ⴗ.Ⴃ, new Point(122, 318), 953, 1002);
				num = 20;
				break;
			case 20:
				ႥႤ.Ⴀ((Control)this.m_Ⴗ.Ⴃ, ClientCty.Ⴗ('ü', 4, 307012768), '\u0018', 'u');
				num = 10;
				break;
			case 10:
				ArcClientConnectDat.Ⴄ((Control)this.m_Ⴗ.Ⴃ, new Size(75, 23), 'ç', 186);
				num = 11;
				break;
			case 11:
				DxEmailCfg.Ⴈ((Control)this.m_Ⴗ.Ⴃ, 0, (short)665, 'ʨ');
				ႥႠ.ႭႤ((Control)this.m_Ⴗ.Ⴃ, ႥႥ.Ⴅ(1673508847, null, 4), 'Ɏ', 'Ȯ');
				num = ⴅ[25];
				break;
			case 2:
				ArcClientConnectDat.Ⴜ((ButtonBase)this.m_Ⴗ.Ⴃ, true, 37, (short)52);
				FilterViewer.ႨႨ<EventHandler, Control>(this.m_Ⴗ.Ⴃ, Ⴅ, '(', 52);
				num = 14;
				break;
			case 14:
				ShowUsers.Ⴐ((Control)Ⴈ, AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right, 'ώ', 1022);
				ႥႷ.Ⴃ(Ⴈ, 1, 137, '\u0088');
				num = 8;
				break;
			case 8:
				DxSpotRates.ႠႰ(Ⴈ, this.m_Ⴗ.Ⴍ, 1023, 1009);
				goto case 6;
			case 6:
				num = ⴗ[70] - 33481;
				break;
			case 13:
				HighlightCountyCfg.Ⴜ((Control)Ⴈ, new Point(8, 7), 704, 659);
				ႥႤ.Ⴀ((Control)Ⴈ, ClientCty.Ⴗ('¹', 6, 307012774), 'ɋ', 'Ȧ');
				num = 1;
				break;
			case 1:
				ႥႷ.Ⴃ(Ⴈ, 1, 770, '\u0300');
				ArcClientConnectDat.Ⴄ((Control)Ⴈ, new Size(302, 302), '\u030e', 851);
				num = 12;
				break;
			case 12:
				DxEmailCfg.Ⴈ((Control)Ⴈ, 1, (short)207, 'þ');
				SkimmerSpotRateGraph.ႤႭ(this.m_Ⴗ.Ⴍ, (ImageListStreamer)ClientCty.Ⴜ((ResourceManager)(obj as ComponentResourceManager), ClientCty.Ⴗ('ò', 7, 307012827), (short)172, (short)218), '\u034f', 797);
				num = 21;
				break;
			case 21:
				ShowUsers.Ⴗ(this.m_Ⴗ.Ⴍ, HighlightCallCfg.Ⴄ(349, 344), 'Ł', 296);
				goto case 3;
			case 3:
				num = 5;
				break;
			case 5:
				SetDxExtension.Ⴓ(this.m_Ⴗ.Ⴍ, 458, 443).SetKeyName(0, ႥႥ.Ⴍ(1, 1580609317, 'º', null));
				num = 16;
				break;
			case 16:
				this.m_Ⴗ.Ⴍ.Images.SetKeyName(1, ႥႥ.Ⴅ(1673508832, null, 2));
				num = 19;
				break;
			case 19:
				base.AutoScaleDimensions = new SizeF(6f, 13f);
				base.AutoScaleMode = AutoScaleMode.Font;
				base.ClientSize = new Size(319, 350);
				num = ⴄ[288] - 36180;
				break;
			case 9:
				base.Controls.Add(Ⴈ);
				base.Controls.Add(this.m_Ⴗ.Ⴃ);
				num = ⴅ[176] - ⴅ[4];
				break;
			case 7:
			case 17:
				base.Name = ႥႥ.Ⴅ(1673508854, null, 3);
				Text = WxFilters.Ⴀ(null, 7, 103387445);
				num = ⴅ[404] - 140;
				break;
			case 18:
				base.Load += Ⴄ;
				ResumeLayout(performLayout: false);
				Bye.Ⴄ[148] = (char)((Bye.Ⴄ[148] ^ Bye.Ⴄ[61]) & 0xC);
				return;
			}
		}
	}

	public DxClusterNetwork(ArcClientObjMgr om)
	{
		Ⴓ = om;
		Ⴗ();
	}

	private void Ⴄ(object P_0, EventArgs P_1)
	{
		char[] ⴄ = Bye.Ⴄ;
		try
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					UserInfo.Ⴜ((Control)this, HighlightSpotterCfg.Ⴗ('\u0097', 195), (short)978, 'φ');
					goto case 5;
				case 5:
					ClientCfg.Ⴄ(HighlightCqZoneCfg.Ⴅ(Ⴈ, 'P', 79), 570, 624);
					num = 0;
					continue;
				case 0:
					ႥႷ.Ⴃ(Ⴈ, 20, 113, 'r');
					new ArcWebService(Ⴓ);
					num = ⴄ[210] - 42789;
					continue;
				case 3:
					Ⴈ.Refresh();
					break;
				case 6:
					break;
				}
				break;
			}
			Cursor = Cursors.Default;
		}
		catch (Exception ex)
		{
			Ⴀ.Error(ex.Message);
		}
		switch (0)
		{
		}
	}

	private void Ⴅ(object P_0, EventArgs P_1)
	{
		ႥႷ.Ⴄ((Form)this, 1010, 'ϥ');
	}

	[SecuritySafeCritical]
	static DxClusterNetwork()
	{
		ArcClientConnectDat.Ⴍ();
		Ⴀ = HighlightItuZoneCfg.Ⴓ(ႥႥ.Ⴅ(1673508852, null, 1), 600, 616);
	}
}

using System;
using System.Collections.Generic;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using DxAtlas;
using log4net;

namespace ArcShared.DxAtlas;

public class DxAtlasWrapper
{
	private static readonly ILog m_Ⴀ;

	private Atlas m_Ⴀ;

	private CustomLayer m_Ⴀ;

	private CustomLayer Ⴅ;

	private float Ⴐ;

	private AnnWxSpotExt.ႤႰ Ⴗ;

	public float HomeLatitude
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			return Ⴗ.Ⴄ;
		}
		set
		{
			Ⴗ.Ⴄ = value;
		}
	}

	public float HomeLongitude
	{
		get
		{
			return Ⴐ;
		}
		set
		{
			Ⴐ = value;
		}
	}

	public DxAtlasWrapper()
	{
		try
		{
			HomeLatitude = 30.88f;
			HomeLongitude = -97.4f;
			this.m_Ⴀ = (Atlas)UtilsSql.ႨႼ(AnnWxSpotExt.ႤႭ(new Guid(TelnetServerClient.Ⴄ(1945323260, '¡', 4)), 135, 'Ý'), 'ô', 188);
			this.m_Ⴀ.Map.PrefixesVisible = false;
			this.m_Ⴀ.Map.Projection = EnumProjection.PRJ_AZIMUTHAL;
			this.m_Ⴀ.Map.HomeLatitude = HomeLatitude;
			this.m_Ⴀ.Map.HomeLongitude = HomeLongitude;
			Ⴅ = this.m_Ⴀ.Map.CustomLayers.Add(EnumLayerKind.LK_POINTS);
			ICustomLayer customLayer = this.m_Ⴀ.Map.CustomLayers.Add(EnumLayerKind.LK_LINES);
			Ⴗ.Ⴀ = (CustomLayer)customLayer;
			this.m_Ⴀ = this.m_Ⴀ.Map.CustomLayers.Add(EnumLayerKind.LK_LABELS);
			Ⴅ.BrushColor = EnumColor.clAqua;
			Ⴅ.PenColor = EnumColor.clBlue;
			Ⴅ.PointSize = 3;
			Ⴗ.Ⴀ.PenColor = EnumColor.clBlue;
			this.m_Ⴀ.LabelsTransparent = true;
			this.m_Ⴀ.PenColor = EnumColor.clRed;
			this.m_Ⴀ.Height = 600;
			this.m_Ⴀ.Width = 514;
			this.m_Ⴀ.Visible = true;
		}
		catch (Exception ex)
		{
			DxAtlasWrapper.m_Ⴀ.Error(ex.Message);
		}
	}

	public void Draw(List<DxAtlasData> DxAtlasPoints)
	{
		try
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					this.m_Ⴀ.Map.BeginUpdate();
					Ⴀ(DxAtlasPoints);
					Ⴈ(DxAtlasPoints);
					num = 5;
					continue;
				case 5:
					Ⴍ(DxAtlasPoints);
					goto case 2;
				case 2:
					this.m_Ⴀ.Map.EndUpdate();
					this.m_Ⴀ.Visible = true;
					num = 6;
					continue;
				case 6:
					this.m_Ⴀ.BringToFront();
					break;
				case 4:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			DxAtlasWrapper.m_Ⴀ.Error(PrecisionTimer.Ⴜ(ex as Exception, 1002, 'η'));
		}
		switch (3)
		{
		}
	}

	private void Ⴀ(List<DxAtlasData> P_0)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 7;
		Array array = default(Array);
		int num2 = default(int);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				array = new object[P_0.Count];
				num2 = 0;
				num = 5;
				break;
			case 1:
				obj = new object[2];
				(obj as object[])[0] = P_0[num2].Lon;
				num = 3;
				break;
			case 3:
				((object[])obj)[1] = P_0[num2].Lat;
				goto case 2;
			case 2:
				((object[])array)[num2] = obj as object[];
				num = ⴗ[112] - ⴗ[112];
				break;
			case 0:
				num2++;
				num = 5;
				break;
			case 5:
				num = ((num2 < P_0.Count) ? (ⴀ[381] - 35980) : (ⴗ[20] - 30035));
				break;
			case 4:
			case 8:
				Ⴅ.SetData((object[])array);
				return;
			}
		}
	}

	private void Ⴈ(List<DxAtlasData> P_0)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 7;
		Array array = default(Array);
		int num2 = default(int);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				array = new object[P_0.Count];
				num2 = 0;
				goto case 3;
			case 3:
				num = ⴃႤ[159] - 6849;
				break;
			case 6:
				obj = new object[3];
				goto case 1;
			case 1:
				((object[])obj)[0] = P_0[num2].Lon;
				num = 0;
				break;
			case 0:
			case 8:
				((object[])obj)[1] = P_0[num2].Lat;
				((object[])obj)[2] = P_0[num2].Call;
				num = 4;
				break;
			case 4:
				(array as object[])[num2] = obj as object[];
				num2++;
				num = 2;
				break;
			case 2:
				num = ((num2 < P_0.Count) ? 6 : 5);
				break;
			case 5:
				this.m_Ⴀ.SetData(array as object[]);
				return;
			}
		}
	}

	private void Ⴍ(List<DxAtlasData> P_0)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 1;
		object obj = default(object);
		int num2 = default(int);
		object obj2 = default(object);
		Array array = default(Array);
		while (true)
		{
			switch (num)
			{
			default:
				obj = new object[P_0.Count - 1];
				num2 = 1;
				num = 6;
				break;
			case 10:
				obj2 = new object[2];
				array = new object[2];
				((object[])obj2)[0] = P_0[0].Lon;
				num = ⴃႭ[32] - 53229;
				break;
			case 9:
				(obj2 as object[])[1] = P_0[0].Lat;
				(array as object[])[0] = obj2 as object[];
				goto case 4;
			case 4:
				num = 0;
				break;
			case 0:
				obj2 = new object[2];
				((object[])obj2)[0] = P_0[num2].Lon;
				num = 8;
				break;
			case 7:
			case 8:
				((object[])obj2)[1] = P_0[num2].Lat;
				((object[])array)[1] = (object[])obj2;
				goto case 5;
			case 5:
				num = 3;
				break;
			case 3:
				((object[])obj)[num2 - 1] = (object[])array;
				num2++;
				num = ⴃႭ[285] - 39659;
				break;
			case 6:
				num = ((num2 < P_0.Count) ? (ⴐ[519] - 58352) : (ⴃႭ[106] - 59661));
				break;
			case 2:
				Ⴗ.Ⴀ.SetData((object[])obj);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	static DxAtlasWrapper()
	{
		UtilsIdentity.Ⴐ();
		DxAtlasWrapper.m_Ⴀ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507264, 27, 0), 102, 57);
	}
}

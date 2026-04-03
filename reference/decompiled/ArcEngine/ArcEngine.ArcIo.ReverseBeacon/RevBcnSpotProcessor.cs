using System;
using System.Runtime.CompilerServices;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using ArcShared.ArcUtils;
using log4net;
using Ⴈ;

namespace ArcEngine.ArcIo.ReverseBeacon;

public sealed class RevBcnSpotProcessor
{
	private static readonly ILog m_Ⴍ = SkimmerValidSpot.Ⴐ(SetStationQth.Ⴍ(null, 1687354365, 3, 24), 252, 225);

	private int Ⴃ;

	private int m_Ⴄ;

	private string m_Ⴐ;

	[SpecialName]
	internal void Ⴍ(int P_0)
	{
		Ⴃ = P_0;
	}

	[SpecialName]
	internal int Ⴓ()
	{
		return Ⴃ;
	}

	[SpecialName]
	internal void Ⴀ(int P_0)
	{
		this.m_Ⴄ = P_0;
	}

	[SpecialName]
	internal int Ⴄ()
	{
		return this.m_Ⴄ;
	}

	[SpecialName]
	internal void Ⴈ(string P_0)
	{
		this.m_Ⴐ = P_0;
	}

	[SpecialName]
	internal string Ⴈ()
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		return this.m_Ⴐ;
	}

	public void ProcessSpots(ArcConnect arcBase, string xml)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		try
		{
			int num = 8;
			object obj = default(object);
			object spots = default(object);
			int num2 = default(int);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = xml.Deserialize<RevBcnSpotArray>();
					spots = (obj as RevBcnSpotArray).Spots;
					num2 = 0;
					num = 7;
					continue;
				case 3:
				case 4:
					obj2 = ((RevBcnSpot[])spots)[num2];
					Ⴍ(Ⴓ() + 1);
					goto case 1;
				case 1:
					num = 6;
					continue;
				case 6:
				{
					Process(arcBase, (RevBcnSpot)obj2);
					num2++;
					byte num3 = ⴀႼ[21];
					TxNodeUserCmd.ႤႷ[3] = (char)((TxNodeUserCmd.ႤႷ[3] - TxNodeUserCmd.ႤႷ[85]) & 0xAB);
					num = num3 - 230;
					continue;
				}
				case 7:
					num = ((num2 < ((RevBcnSpot[])spots).Length) ? 4 : 5);
					continue;
				case 5:
					RevBcnSpotProcessor.m_Ⴍ.Info(qslinfoResponse.Ⴗ(SetStationQth.Ⴍ(null, 1687354127, 3, 30), ((RevBcnSpotArray)obj).Spots[0].Id, ႰႥ.Ⴅ(5, 'Ë', 952620215), ((RevBcnSpotArray)obj).Spots[(obj as RevBcnSpotArray).Spots.Length - 1].Id, 407, 'Ǵ'));
					num = 9;
					continue;
				case 0:
				case 9:
					Ⴐ(obj as RevBcnSpotArray);
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			RevBcnSpotProcessor.m_Ⴍ.Warn(SetStationQth.Ⴍ(null, 1687354155, 3, 19) + xml + ႰႥ.Ⴅ(6, '\u0018', 952620212) + SkimmerSpotBins.Ⴈ(ex, 648, 678));
		}
		switch (4)
		{
		}
	}

	private void Ⴐ(RevBcnSpotArray P_0)
	{
		Ⴈ((P_0.Spots.Length <= 0) ? string.Empty : P_0.Spots[P_0.Spots.Length - 1].Id);
	}

	public void Process(ArcConnect arcBase, RevBcnSpot spot)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = ႨႣ.Ⴐ;
		try
		{
			int num = 8;
			object obj = default(object);
			object obj4 = default(object);
			object obj3 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = new PrecisionTimer();
					ShowPrefixCallsHelp.Ⴗ(obj as PrecisionTimer, 284, 349);
					obj4 = new NodeUserCmd(arcBase);
					num = 9;
					continue;
				case 9:
					(obj4 as NodeUserCmd).Rx.Msg = UserCacheCfg.Ⴃ((object)spot, '\f', 103);
					obj3 = obj4 as NodeUserCmd;
					num = 6;
					continue;
				case 6:
				{
					DxSpotBase dxSpotBase = new DxSpotRevBcnWeb();
					num = ((!((DxSpotRevBcnWeb)dxSpotBase).Process(obj3 as NodeUserCmd, spot)) ? ⴐ[257] : (ⴀႨ[171] - 5172));
					continue;
				}
				case 3:
					Ⴀ(Ⴄ() + 1);
					goto case 1;
				case 1:
				case 7:
				{
					object obj2 = new Publisher();
					(obj2 as Publisher).Process(obj3 as NodeUserCmd);
					ByeHelp.Ⴄ((PrecisionTimer)obj, '\u009b', 200);
					goto case 2;
				}
				case 2:
					num = 4;
					continue;
				case 4:
					RevBcnSpotProcessor.m_Ⴍ.Info(SetWxCountHelp.Ⴗ((object)(PrecisionTimer)obj, (object)UserCacheCfg.Ⴃ((object)spot, 'Ŕ', 319), 962, (short)953));
					break;
				case 0:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			ILog ⴍ = RevBcnSpotProcessor.m_Ⴍ;
			object obj5 = new object[4];
			(obj5 as object[])[0] = ReplyMailHelp.Ⴄ(2, null, 1057164701, 0);
			((object[])obj5)[1] = spot;
			(obj5 as object[])[2] = ႰႥ.Ⴅ(6, '\u008d', 952620212);
			(obj5 as object[])[3] = (ex as Exception).Message;
			ⴍ.Warn(string.Concat((object[])obj5));
		}
		switch (0)
		{
		}
	}
}

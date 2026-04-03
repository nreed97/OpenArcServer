using System;
using System.Threading.Tasks;
using ArcEngine;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using log4net;

namespace Ⴈ;

internal sealed class ႨႭ
{
	private sealed class ႨႷ
	{
		public NodeUserCmd Ⴍ;

		public IArcCmd Ⴅ;

		public void Ⴄ(object P_0)
		{
			Ⴅ.Exec(Ⴍ);
		}
	}

	private static readonly ILog Ⴍ = SkimmerValidSpot.Ⴐ(ShowWxHelp.Ⴍ('f', 985805913, 8), 628, 617);

	private readonly ObjectManager Ⴈ;

	private CallbookCfg.Ⴅ Ⴄ = new CallbookCfg.Ⴅ();

	internal ႨႭ(ObjectManager P_0)
	{
		Ⴈ = P_0;
		object obj = new global::Ⴈ.ႨႷ();
		Ⴄ.Ⴅ = (global::Ⴈ.ႨႷ)obj;
	}

	internal void Ⴓ(string P_0, ArcConnect P_1)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		try
		{
			int num = 3;
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
				{
					obj = new ႨႷ();
					ႨႷ obj3 = (ႨႷ)obj;
					object obj4 = new NodeUserCmd(P_1);
					(obj4 as NodeUserCmd).Rx.Msg = P_0;
					obj3.Ⴍ = obj4 as NodeUserCmd;
					num = ⴃႠ[256] - 5294;
					continue;
				}
				case 8:
					obj2 = Ⴄ.Ⴅ.Ⴍ((obj as ႨႷ).Ⴍ.Rx.CmdKey);
					num = ⴃႥ[28] - 18371;
					continue;
				case 7:
					num = (((NodeCmdCfg)obj2 == null) ? (ⴃႠ[185] - 15218) : ⴄႭ[66]);
					continue;
				case 0:
				case 5:
					num = ((!ႰႨ.ႥႥ(((NodeCmdCfg)obj2).CodeName, 'Π', 'Ά')) ? (ⴄႷ[61] - 8219) : (ⴀႨ[112] - 20948));
					continue;
				case 4:
				case 10:
					break;
				case 1:
				case 2:
					(obj as ႨႷ).Ⴅ = Ⴈ.Ⴗ().Ⴈ(((NodeCmdCfg)obj2).CodeName);
					num = 6;
					continue;
				case 6:
					PublishInfo.Ⴅ(368, 299).StartNew(((ႨႷ)obj).Ⴄ, TaskCreationOptions.PreferFairness);
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴍ.Error(P_0 + (ex as Exception).Message);
		}
		switch (1)
		{
		}
	}
}

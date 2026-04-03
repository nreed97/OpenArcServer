using System.Runtime.InteropServices;
using System.Security;
using ArcEngine.ArcCmds.Publish;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcObjs;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcShared.MaintenanceUpdates;
using Ⴈ;

namespace ArcEngine.ArcCmds.User.Network;

public sealed class ClearHelp : IArcCmd
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Ⴍ
	{
		internal ႷႠ Ⴅ;

		internal ArcServerCfg Ⴍ;

		internal ArcConnect Ⴗ;

		internal ႳႭ Ⴄ;

		internal ႰႼ Ⴃ;

		internal string Ⴓ;
	}

	public void Exec(NodeUserCmd cmd)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				cmd.Tx.DistroType = DistroType.ToRequester;
				goto case 4;
			case 4:
				cmd.Tx.Msg.Add(SetTalkCount.Ⴗ(3, null, 1267013651, typeof(SetWwvCount)));
				goto case 5;
			case 5:
				num = 0;
				break;
			case 0:
				cmd.Tx.Msg.Add(ShowSkimCtyHelp.Ⴍ(1216130088, 5, ';'));
				cmd.Tx.Msg.Add(ႰႥ.Ⴅ(3, '{', 952620567));
				goto case 1;
			case 1:
			{
				char num2 = ⴃႠ[432];
				SetDxCountHelp.ႭႤ[414] = (SetDxCountHelp.ႭႤ[414] | SetDxCountHelp.ႭႤ[380]) & 0x2E;
				num = num2 - 65300;
				break;
			}
			case 3:
			{
				object obj = new Publisher();
				((Publisher)obj).Process(cmd);
				return;
			}
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴗ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, short P_2, int P_3) where _0021_00210 : CtyUpdate where _0021_00211 : string
	{
		char[] ⴃႥ = ShowWwvOptionsHelp.ႣႥ;
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 9;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႥ[79] - 4226;
					continue;
				case 2:
					break;
				case 9:
					num2 = (((P_2 ^ P_3) - 126) ^ num) switch
					{
						0 => ⴀႣ[322] - ⴀႣ[322], 
						_ => ⴃႠ[29] - 16835, 
					};
					continue;
				case 1:
				case 10:
					result = false;
					num2 = ⴀ[366] - 47447;
					continue;
				case 0:
				case 8:
					result = P_0.Download(P_1);
					num2 = 3;
					continue;
				case 3:
					num++;
					goto case 6;
				case 6:
				{
					int num4 = 1256;
					int num5 = 211;
					num2 = ((314 < num4 / 4 - num5) ? (ⴄႭ[498] / 7) : 4);
					continue;
				}
				case 4:
					return result;
				case 7:
				{
					char num3 = ⴍႭ[326];
					TxNodeUserCmd.ႤႷ[63] = (char)((TxNodeUserCmd.ႤႷ[63] * P_2) & 0xF9);
					num2 = num3 - 31893;
					continue;
				}
				}
				break;
			}
		}
	}
}

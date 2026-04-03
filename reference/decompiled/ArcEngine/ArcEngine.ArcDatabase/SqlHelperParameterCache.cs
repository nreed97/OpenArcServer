using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.Dx;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Network;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Station;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;

namespace ArcEngine.ArcDatabase;

public sealed class SqlHelperParameterCache
{
	private static Hashtable Ⴀ = qslinfoSoapClient.Ⴐ(new Hashtable(), 880, 893);

	private SqlHelperParameterCache()
	{
	}

	private static OleDbParameter[] Ⴍ(string P_0, string P_1, bool P_2)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		ICloneable cloneable = new OleDbConnection(P_0);
		object obj;
		try
		{
			switch (1)
			{
			default:
			{
				DbCommand dbCommand = new OleDbCommand(P_1, cloneable as OleDbConnection);
				try
				{
					int num = 7;
					Array array = default(Array);
					while (true)
					{
						switch (num)
						{
						default:
							SetAnnWrapHelp.Ⴀ((DbConnection)(OleDbConnection)cloneable, 458, (short)457);
							ShowQslInfoHelp.Ⴐ((DbCommand)(dbCommand as OleDbCommand), CommandType.StoredProcedure, '\u032e', '\u033d');
							goto case 4;
						case 4:
							num = 8;
							continue;
						case 8:
							SetTalkDefaultHelp.Ⴍ((OleDbCommand)dbCommand, 231, 'Þ');
							num = (P_2 ? 1 : (ⴀႣ[350] - 49127));
							continue;
						case 3:
						case 6:
							ShowDxHelp.Ⴗ((DbParameterCollection)SetDxExtensionHelp.Ⴐ((OleDbCommand)dbCommand, 'ɹ', 'ɧ'), 0, (short)572, 'ɗ');
							goto case 1;
						case 1:
						{
							array = new OleDbParameter[Bye.Ⴈ((DbParameterCollection)SetDxExtensionHelp.Ⴐ(dbCommand as OleDbCommand, 'ï', 'ñ'), (short)74, 35)];
							char num2 = ⴀႳ[321];
							SetTalkCountHelp.Ⴅ[442] = (byte)((SetTalkCountHelp.Ⴅ[442] | SetTalkCountHelp.Ⴅ[367]) & 7);
							num = num2 - 61742;
							continue;
						}
						case 5:
							(dbCommand as OleDbCommand).Parameters.CopyTo(array as OleDbParameter[], 0);
							break;
						case 0:
							break;
						}
						break;
					}
					obj = (OleDbParameter[])array;
				}
				finally
				{
					int num3 = 4;
					while (true)
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = ((!(dbCommand is OleDbCommand)) ? 3 : 6);
							goto IL_01de;
						case 0:
						case 2:
						case 6:
							((IDisposable)(dbCommand as OleDbCommand)).Dispose();
							break;
						case 1:
						case 3:
							break;
						}
						break;
						IL_01de:
						num3 = num4;
					}
				}
				break;
			}
			}
		}
		finally
		{
			int num5 = 1;
			while (true)
			{
				int num6;
				switch (num5)
				{
				default:
					num6 = (((OleDbConnection)cloneable == null) ? 3 : 0);
					goto IL_0220;
				case 0:
					((IDisposable)(cloneable as OleDbConnection)).Dispose();
					break;
				case 3:
				case 6:
					break;
				}
				break;
				IL_0220:
				num5 = num6;
			}
		}
		return 3 switch
		{
			_ => obj as OleDbParameter[], 
		};
	}

	private static OleDbParameter[] Ⴓ(OleDbParameter[] P_0)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		while (true)
		{
			object obj = new OleDbParameter[P_0.Length];
			while (true)
			{
				IL_0052:
				int num = 0;
				int num2 = P_0.Length;
				int num3 = 1;
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 2;
						continue;
					case 2:
					case 4:
						break;
					case 5:
						goto IL_0052;
					case 3:
						((OleDbParameter[])obj)[num] = (OleDbParameter)((ICloneable)P_0[num]).Clone();
						num++;
						num3 = ⴀႨ[219] - 45728;
						continue;
					case 1:
					{
						int num5;
						if (num >= num2)
						{
							char num4 = ⴀ[126];
							SetTalkCountHelp.Ⴅ[148] = (byte)((SetTalkCountHelp.Ⴅ[148] | BandModeCacheCfg.ႠႳ[284]) & 0x3C);
							num5 = num4 - 56578;
						}
						else
						{
							num5 = ⴍႭ[85] - 31490;
						}
						num3 = num5;
						continue;
					}
					case 0:
					case 7:
						return obj as OleDbParameter[];
					}
					break;
				}
				break;
			}
		}
	}

	public static void CacheParameterSet(string connectionString, string commandText, params OleDbParameter[] commandParameters)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		int num = 0;
		IEquatable<string> equatable = default(IEquatable<string>);
		while (true)
		{
			switch (num)
			{
			default:
				equatable = AnnHelp.Ⴈ(connectionString, ShowSkimCtyHelp.Ⴍ(1216134115, 8, 'Ý'), commandText, 261, 'Ĳ');
				break;
			case 2:
				break;
			case 1:
			case 3:
			case 4:
				Ⴀ[equatable as string] = commandParameters;
				return;
			}
			num = ⴀႳ[183] - 43499;
		}
	}

	public static OleDbParameter[] GetCachedParameterSet(string connectionString, string commandText)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		Array array = default(Array);
		while (true)
		{
			IConvertible convertible = AnnHelp.Ⴈ(connectionString, ShowSkimCtyHelp.Ⴍ(1216134126, 5, '¾'), commandText, 337, 'Ŧ');
			while (true)
			{
				IL_006f:
				int num = ⴀ[389] - 31301;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴄႭ[54] - ⴄႭ[275];
						continue;
					case 2:
						break;
					case 5:
						goto IL_006f;
					case 4:
						array = (OleDbParameter[])ShowWwv.Ⴐ(Ⴀ, (object)(convertible as string), 'ǡ', 'Ƅ');
						goto case 7;
					case 7:
						num = (((OleDbParameter[])array != null) ? 1 : 0);
						continue;
					case 0:
						return null;
					case 1:
						return Ⴓ(array as OleDbParameter[]);
					}
					break;
				}
				break;
			}
		}
	}

	public static OleDbParameter[] GetSpParameterSet(string connectionString, string spName)
	{
		OleDbParameter[] spParameterSet = GetSpParameterSet(connectionString, spName, includeReturnValueParameter: false);
		SetTalkCountHelp.Ⴅ[149] = (byte)((SetTalkCountHelp.Ⴅ[149] ^ SetTalkCountHelp.Ⴅ[254]) & 0x76);
		return spParameterSet;
	}

	public static OleDbParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
	{
		object obj = default(object);
		while (true)
		{
			IEnumerable enumerable = qslinfoResponse.Ⴗ(connectionString, ShowSkimCtyHelp.Ⴍ(1216134125, 6, 'G'), spName, includeReturnValueParameter ? SetTalkCount.Ⴗ(6, null, 1267019508, typeof(LogFileCfg)) : SetStationClubHelp.Ⴍ(14, 4, 1747258268, null), 369, 'Ē');
			Array array = (OleDbParameter[])ShowWwv.Ⴐ(Ⴀ, (object)(enumerable as string), 'Ǩ', 'ƍ');
			while (true)
			{
				IL_00a0:
				int num = 5;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 3;
						continue;
					case 3:
						break;
					case 8:
						goto IL_00a0;
					case 5:
						num = (((OleDbParameter[])array == null) ? 1 : 2);
						continue;
					case 0:
					case 1:
						DxTestHelp.Ⴍ(Ⴀ, (object)(enumerable as string), obj = Ⴍ(connectionString, spName, includeReturnValueParameter), 'ä', (short)129);
						goto case 6;
					case 6:
						num = 4;
						continue;
					case 4:
						array = (OleDbParameter[])obj;
						num = 2;
						continue;
					case 2:
						return Ⴓ((OleDbParameter[])array);
					}
					break;
				}
				break;
			}
		}
	}
}

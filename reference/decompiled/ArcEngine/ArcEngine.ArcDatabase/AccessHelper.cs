using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.Serialization;
using ArcEngine.ArcCmds;
using ArcEngine.ArcCmds.AnnWx;
using ArcEngine.ArcCmds.NodeProcessor;
using ArcEngine.ArcCmds.User.Ann;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wwv;
using ArcEngine.ArcCmds.User.Wx;
using ArcEngine.ArcIo.Arc4;
using ArcEngine.ArcServerConfig.Caches;
using ArcEngine.QslInfo;
using Ⴈ;

namespace ArcEngine.ArcDatabase;

public sealed class AccessHelper
{
	private enum ႨႣ
	{

	}

	private AccessHelper()
	{
	}

	private static void Ⴄ(OleDbCommand P_0, OleDbParameter[] P_1)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = Ⴈ.ႨႣ.Ⴐ;
		int num = 5;
		Array array = default(Array);
		int num2 = default(int);
		DbParameter dbParameter = default(DbParameter);
		while (true)
		{
			switch (num)
			{
			default:
				array = P_1;
				num2 = 0;
				num = 4;
				break;
			case 1:
				dbParameter = (array as OleDbParameter[])[num2];
				goto case 6;
			case 6:
			{
				int num3;
				if (AnnHelp.Ⴃ((DbParameter)(OleDbParameter)dbParameter, '\u0087', (short)138) == ParameterDirection.InputOutput)
				{
					num3 = ⴄႤ[376] - 64;
				}
				else
				{
					byte num4 = ⴅ[121];
					SetTalkCountHelp.Ⴅ[179] = (byte)((SetTalkCountHelp.Ⴅ[179] - SetTalkCountHelp.Ⴅ[333]) & 0x41);
					num3 = num4 - 188;
				}
				num = num3;
				break;
			}
			case 7:
				num = ((NodeCmdCfg.Ⴈ((DbParameter)(OleDbParameter)dbParameter, 'Ʀ', 'Ǌ') != null) ? (ⴀႼ[33] / 3) : 9);
				break;
			case 9:
				AnnFullHelp.Ⴀ((DbParameter)(dbParameter as OleDbParameter), (object)DBNull.Value, (short)730, 653);
				goto case 3;
			case 3:
				SetDxExtensionHelp.Ⴐ(P_0, '\u038d', 'Γ').Add(dbParameter as OleDbParameter);
				num2++;
				num = ⴀႨ[196] - 23282;
				break;
			case 0:
			case 4:
				num = ((num2 < (array as OleDbParameter[]).Length) ? (ⴅ[17] - 29) : (ⴐ[65] - 229));
				break;
			case 8:
				return;
			}
		}
	}

	private static void Ⴀ(OleDbParameter[] P_0, object[] P_1)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		byte[] ⴐ = Ⴈ.ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int num = 0;
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((P_0 == null) ? 5 : (ⴀ[12] - 22301));
				break;
			case 1:
			case 2:
			case 3:
			case 4:
				if (P_1 == null)
				{
					num = 5;
					break;
				}
				while (true)
				{
					int num2 = ((P_0.Length != P_1.Length) ? 1 : 10);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 9:
							return;
						case 0:
						case 6:
							break;
						case 1:
							throw new ArgumentException(CallBlockCacheCfg.Ⴅ(null, 0, 62054615, null));
						case 10:
							num3 = 0;
							goto case 8;
						case 8:
							num4 = P_0.Length;
							num2 = ⴃႰ[32] - 1119;
							continue;
						case 7:
							AnnFullHelp.Ⴀ((DbParameter)P_0[num3], P_1[num3], (short)742, 689);
							num2 = 2;
							continue;
						case 2:
							num3++;
							num2 = ⴀႼ[92] - 105;
							continue;
						case 3:
							num2 = ((num3 < num4) ? ⴐ[257] : 4);
							continue;
						case 4:
							return;
						}
						break;
					}
				}
			case 5:
				return;
			}
		}
	}

	private static void Ⴃ(OleDbCommand P_0, OleDbConnection P_1, OleDbTransaction P_2, CommandType P_3, string P_4, OleDbParameter[] P_5)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((MasterCallCacheCfg.Ⴀ((DbConnection)P_1, 714, 763) == ConnectionState.Open) ? 7 : 9);
				break;
			case 5:
			case 9:
				SetAnnWrapHelp.Ⴀ((DbConnection)P_1, 639, (short)636);
				goto case 7;
			case 7:
				Top100CacheCfg.Ⴐ(P_0, P_1, 500, 427);
				goto case 10;
			case 10:
				ShowHamHelp.Ⴐ((DbCommand)P_0, P_4, (short)802, '\u0320');
				num = ⴃႰ[185] - 49416;
				break;
			case 1:
				num = ((P_2 == null) ? 8 : (ⴍႭ[331] - 20129));
				break;
			case 4:
				P_0.Transaction = P_2;
				goto case 8;
			case 8:
				P_0.CommandType = P_3;
				num = ((P_5 == null) ? 2 : 0);
				break;
			case 0:
				Ⴄ(P_0, P_5);
				return;
			case 2:
				return;
			}
		}
	}

	public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
	{
		int result = ExecuteNonQuery(connectionString, commandType, commandText, (OleDbParameter[])null);
		SetAnnMode.ႤႭ[310] = (byte)((SetAnnMode.ႤႭ[310] + SetAnnMode.ႤႭ[600]) & 0xBC);
		return result;
	}

	public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		IDbConnection dbConnection = new OleDbConnection(connectionString);
		try
		{
			SetAnnWrapHelp.Ⴀ((DbConnection)(OleDbConnection)dbConnection, 536, (short)539);
			return ExecuteNonQuery((OleDbConnection)dbConnection, commandType, commandText, commandParameters);
		}
		finally
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((!(dbConnection is OleDbConnection)) ? 1 : 4);
					goto IL_0092;
				case 0:
				case 4:
					((IDisposable)(dbConnection as OleDbConnection)).Dispose();
					break;
				case 1:
				case 5:
					break;
				}
				break;
				IL_0092:
				num = num2;
			}
		}
	}

	public static int ExecuteNonQuery(string connectionString, string spName, params object[] parameterValues)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		while (true)
		{
			int num = ((parameterValues == null) ? 7 : (ⴀ[336] - 53694));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 0;
					continue;
				case 0:
					break;
				case 4:
					num = ((parameterValues.Length > 0) ? 1 : (ⴀႼ[93] - 128));
					continue;
				case 1:
				{
					Array spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
					Ⴀ((OleDbParameter[])spParameterSet, parameterValues);
					return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, (OleDbParameter[])spParameterSet);
				}
				case 2:
				case 3:
				case 7:
					return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static int ExecuteNonQuery(OleDbConnection connection, CommandType commandType, string commandText)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		return ExecuteNonQuery(connection, commandType, commandText, (OleDbParameter[])null);
	}

	public static int ExecuteNonQuery(OleDbConnection connection, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		int result = default(int);
		while (true)
		{
			ICloneable cloneable = new OleDbCommand();
			Ⴃ(cloneable as OleDbCommand, connection, null, commandType, commandText, commandParameters);
			while (true)
			{
				IL_0058:
				int num = 3;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴍႤ[167] - 20614;
						continue;
					case 4:
					case 6:
						break;
					case 5:
						goto IL_0058;
					case 3:
						result = SetAnnCountHelp.Ⴅ((DbCommand)(cloneable as OleDbCommand), (short)667, '\u02ea');
						SetDxExtensionHelp.Ⴐ(cloneable as OleDbCommand, 'Ǐ', 'Ǒ').Clear();
						num = 2;
						continue;
					case 2:
						return result;
					}
					break;
				}
				break;
			}
		}
	}

	public static int ExecuteNonQuery(OleDbConnection connection, string spName, params object[] parameterValues)
	{
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		object spParameterSet = default(object);
		while (true)
		{
			int num = ((parameterValues == null) ? 8 : 3);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 5;
					continue;
				case 5:
					break;
				case 3:
					num = ((parameterValues.Length <= 0) ? 8 : (ⴄႤ[516] - 25));
					continue;
				case 7:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)connection, (short)975, (short)965), spName);
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					num = 0;
					continue;
				case 0:
				case 6:
					return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, spParameterSet as OleDbParameter[]);
				case 4:
				case 8:
					return ExecuteNonQuery(connection, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static int ExecuteNonQuery(OleDbTransaction transaction, CommandType commandType, string commandText)
	{
		return ExecuteNonQuery(transaction, commandType, commandText, (OleDbParameter[])null);
	}

	public static int ExecuteNonQuery(OleDbTransaction transaction, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		int result = default(int);
		while (true)
		{
			IDbCommand dbCommand = new OleDbCommand();
			Ⴃ(dbCommand as OleDbCommand, ShowWx.Ⴃ(transaction, 455, 439), transaction, commandType, commandText, commandParameters);
			while (true)
			{
				IL_0068:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴀႼ[136];
						continue;
					case 5:
						break;
					case 4:
						goto IL_0068;
					case 2:
						result = SetAnnCountHelp.Ⴅ((DbCommand)(OleDbCommand)dbCommand, (short)58, 'K');
						goto case 0;
					case 0:
						((OleDbCommand)dbCommand).Parameters.Clear();
						num = ⴀႨ[147] - 30834;
						continue;
					case 1:
					case 3:
						return result;
					}
					break;
				}
				break;
			}
		}
	}

	public static int ExecuteNonQuery(OleDbTransaction transaction, string spName, params object[] parameterValues)
	{
		byte[] ⴐ = Ⴈ.ႨႣ.Ⴐ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		Array spParameterSet = default(Array);
		while (true)
		{
			int num = ((parameterValues == null) ? (ⴐ[77] - 44) : 0);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 6;
					continue;
				case 6:
					break;
				case 0:
					num = ((parameterValues.Length <= 0) ? 5 : (ⴀ[312] - 19366));
					continue;
				case 2:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)ShowWx.Ⴃ(transaction, 485, 405), (short)935, (short)941), spName);
					goto case 3;
				case 3:
				case 7:
					num = ⴀ[480] - 26871;
					continue;
				case 1:
					Ⴀ((OleDbParameter[])spParameterSet, parameterValues);
					return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, spParameterSet as OleDbParameter[]);
				case 5:
					return ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText)
	{
		return ExecuteDataset(connectionString, commandType, commandText, (OleDbParameter[])null);
	}

	public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		IDisposable disposable = new OleDbConnection(connectionString);
		ISerializable serializable;
		try
		{
			SetAnnWrapHelp.Ⴀ((DbConnection)(disposable as OleDbConnection), 382, (short)381);
			serializable = ExecuteDataset((OleDbConnection)disposable, commandType, commandText, commandParameters);
		}
		finally
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((disposable is OleDbConnection) ? 4 : 0);
					goto IL_007e;
				case 4:
				case 5:
					((IDisposable)(OleDbConnection)disposable).Dispose();
					break;
				case 0:
					break;
				}
				break;
				IL_007e:
				num = num2;
			}
		}
		return serializable as DataSet;
	}

	public static DataSet ExecuteDataset(string connectionString, string spName, params object[] parameterValues)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		Array spParameterSet = default(Array);
		while (true)
		{
			int num = ((parameterValues == null) ? (ⴃႰ[20] - 30607) : 6);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴅ[145];
					continue;
				case 3:
				case 7:
					break;
				case 6:
					num = ((parameterValues.Length <= 0) ? (ⴀႳ[230] - 17605) : 4);
					continue;
				case 4:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
					goto case 1;
				case 1:
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, spParameterSet as OleDbParameter[]);
				case 0:
				case 5:
					return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static DataSet ExecuteDataset(OleDbConnection connection, CommandType commandType, string commandText)
	{
		byte[] ⴐ = Ⴈ.ႨႣ.Ⴐ;
		return ExecuteDataset(connection, commandType, commandText, (OleDbParameter[])null);
	}

	public static DataSet ExecuteDataset(OleDbConnection connection, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		IDbDataAdapter dbDataAdapter = default(IDbDataAdapter);
		ISupportInitialize supportInitialize = default(ISupportInitialize);
		while (true)
		{
			IDisposable disposable = new OleDbCommand();
			Ⴃ((OleDbCommand)disposable, connection, null, commandType, commandText, commandParameters);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 4:
					break;
				case 5:
					dbDataAdapter = new OleDbDataAdapter(disposable as OleDbCommand);
					goto case 3;
				case 3:
					supportInitialize = new DataSet();
					goto case 0;
				case 0:
					qslinfoRequest.Ⴓ((DataAdapter)(dbDataAdapter as OleDbDataAdapter), supportInitialize as DataSet, 725, (short)650);
					num = 2;
					continue;
				case 2:
					SetDxExtensionHelp.Ⴐ(disposable as OleDbCommand, 'Ƴ', 'ƭ').Clear();
					goto case 6;
				case 6:
					return (DataSet)supportInitialize;
				}
				break;
			}
		}
	}

	public static DataSet ExecuteDataset(OleDbConnection connection, string spName, params object[] parameterValues)
	{
		int[] ⴍႤ = SetDxCountHelp.ႭႤ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		byte[] ⴄႤ = ShowQrzHelp.ႤႤ;
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		object spParameterSet = default(object);
		while (true)
		{
			int num = ((parameterValues == null) ? (ⴍႤ[182] - ⴍႤ[182]) : (ⴍႤ[251] - 35338));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
					break;
				case 8:
					num = ((parameterValues.Length <= 0) ? (ⴄႤ[252] - 204) : (ⴅ[441] - ⴅ[121]));
					continue;
				case 6:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)connection, (short)886, (short)892), spName);
					goto case 1;
				case 1:
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					num = ⴄႭ[255] - 92;
					continue;
				case 3:
				case 4:
					return ExecuteDataset(connection, CommandType.StoredProcedure, spName, spParameterSet as OleDbParameter[]);
				case 0:
				case 7:
					return ExecuteDataset(connection, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static DataSet ExecuteDataset(OleDbTransaction transaction, CommandType commandType, string commandText)
	{
		DataSet result = ExecuteDataset(transaction, commandType, commandText, (OleDbParameter[])null);
		SetTalkCountHelp.Ⴅ[375] = ShowQrzHelp.ႤႤ[88];
		return result;
	}

	public static DataSet ExecuteDataset(OleDbTransaction transaction, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		IDataAdapter dataAdapter = default(IDataAdapter);
		IListSource listSource = default(IListSource);
		while (true)
		{
			IDbCommand dbCommand = new OleDbCommand();
			Ⴃ(dbCommand as OleDbCommand, ShowWx.Ⴃ(transaction, 713, 697), transaction, commandType, commandText, commandParameters);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 4;
					continue;
				case 3:
				case 4:
					break;
				case 5:
					dataAdapter = new OleDbDataAdapter((OleDbCommand)dbCommand);
					goto case 1;
				case 1:
					listSource = new DataSet();
					qslinfoRequest.Ⴓ((DataAdapter)(OleDbDataAdapter)dataAdapter, (DataSet)listSource, 518, (short)601);
					num = 2;
					continue;
				case 0:
				case 2:
					((OleDbCommand)dbCommand).Parameters.Clear();
					return (DataSet)listSource;
				}
				break;
			}
		}
	}

	public static DataSet ExecuteDataset(OleDbTransaction transaction, string spName, params object[] parameterValues)
	{
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		byte[] ⴐ = Ⴈ.ႨႣ.Ⴐ;
		Array spParameterSet = default(Array);
		while (true)
		{
			int num = ((parameterValues == null) ? (ⴀႳ[206] - ⴀႳ[206]) : (ⴀႨ[143] - 64090));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 2;
					continue;
				case 2:
					break;
				case 1:
				case 3:
					num = ((parameterValues.Length <= 0) ? ⴐ[254] : 7);
					continue;
				case 5:
				case 7:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)ShowWx.Ⴃ(transaction, 126, 14), (short)398, (short)388), spName);
					num = 8;
					continue;
				case 4:
				case 8:
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					return ExecuteDataset(transaction, CommandType.StoredProcedure, spName, (OleDbParameter[])spParameterSet);
				case 0:
					return ExecuteDataset(transaction, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	private static OleDbDataReader Ⴗ(OleDbConnection P_0, OleDbTransaction P_1, CommandType P_2, string P_3, OleDbParameter[] P_4, ႨႣ P_5)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		object obj2 = default(object);
		while (true)
		{
			object obj = new OleDbCommand();
			Ⴃ(obj as OleDbCommand, P_0, P_1, P_2, P_3, P_4);
			while (true)
			{
				IL_005b:
				int num = 8;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 6;
						continue;
					case 6:
						break;
					case 5:
						goto IL_005b;
					case 8:
						num = ((P_5 != (ႨႣ)1) ? (ⴃႰ[17] - 56147) : 4);
						continue;
					case 2:
					case 4:
						obj2 = DxCacheCfg.Ⴐ((OleDbCommand)obj, 987, 963);
						num = 7;
						continue;
					case 3:
						obj2 = SetDxMode.Ⴐ((OleDbCommand)obj, CommandBehavior.CloseConnection, 932, 898);
						num = ⴀႣ[217] - 50649;
						continue;
					case 7:
						((OleDbCommand)obj).Parameters.Clear();
						return (OleDbDataReader)obj2;
					}
					break;
				}
				break;
			}
		}
	}

	public static OleDbDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		return ExecuteReader(connectionString, commandType, commandText, (OleDbParameter[])null);
	}

	public static OleDbDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		ICloneable cloneable = new OleDbConnection(connectionString);
		SetAnnWrapHelp.Ⴀ((DbConnection)(OleDbConnection)cloneable, 41, (short)42);
		object obj;
		try
		{
			obj = Ⴗ((OleDbConnection)cloneable, null, commandType, commandText, commandParameters, (ႨႣ)0);
		}
		catch
		{
			HamQthDotComLookupExt.Ⴈ((DbConnection)(cloneable as OleDbConnection), 'ʵ', '\u02d8');
			throw;
		}
		OleDbDataReader result = (OleDbDataReader)obj;
		TxNodeUserCmd.ႤႷ[98] = (char)((TxNodeUserCmd.ႤႷ[98] + SetTalkCountHelp.Ⴅ[195]) & 0xA3);
		return result;
	}

	public static OleDbDataReader ExecuteReader(string connectionString, string spName, params object[] parameterValues)
	{
		char[] ⴀႣ = Arc4ServerClient.ႠႣ;
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		object spParameterSet = default(object);
		while (true)
		{
			int num = ((parameterValues == null) ? (ⴃႰ[144] - 9227) : (ⴀႣ[248] - 37921));
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
				case 1:
					num = ((parameterValues.Length <= 0) ? 2 : 7);
					continue;
				case 4:
				case 7:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
					goto case 0;
				case 0:
				case 6:
					Ⴀ((OleDbParameter[])spParameterSet, parameterValues);
					return ExecuteReader(connectionString, CommandType.StoredProcedure, spName, spParameterSet as OleDbParameter[]);
				case 2:
					return ExecuteReader(connectionString, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static OleDbDataReader ExecuteReader(OleDbConnection connection, CommandType commandType, string commandText)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		return ExecuteReader(connection, commandType, commandText, (OleDbParameter[])null);
	}

	public static OleDbDataReader ExecuteReader(OleDbConnection connection, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		return Ⴗ(connection, null, commandType, commandText, commandParameters, (ႨႣ)1);
	}

	public static OleDbDataReader ExecuteReader(OleDbConnection connection, string spName, params object[] parameterValues)
	{
		byte[] ⴐ = Ⴈ.ႨႣ.Ⴐ;
		byte[] ⴀႼ = AnnCacheCfg.ႠႼ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		object spParameterSet = default(object);
		while (true)
		{
			SetTalkCountHelp.Ⴅ[396] = (byte)((SetTalkCountHelp.Ⴅ[396] + SetTalkCountHelp.Ⴅ[105]) & 0xA6);
			int num = ((parameterValues == null) ? 8 : ⴀႼ[113]);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴐ[254];
					continue;
				case 0:
					break;
				case 2:
					num = ((parameterValues.Length <= 0) ? (ⴀ[57] - 22264) : (ⴄႷ[120] - 46472));
					continue;
				case 1:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)connection, (short)910, (short)900), spName);
					goto case 4;
				case 4:
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					goto case 7;
				case 7:
					num = ⴀ[513] - 5082;
					continue;
				case 5:
					return ExecuteReader(connection, CommandType.StoredProcedure, spName, (OleDbParameter[])spParameterSet);
				case 8:
					return ExecuteReader(connection, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static OleDbDataReader ExecuteReader(OleDbTransaction transaction, CommandType commandType, string commandText)
	{
		char[] ⴃႠ = ShowSunHelp.ႣႠ;
		return ExecuteReader(transaction, commandType, commandText, (OleDbParameter[])null);
	}

	public static OleDbDataReader ExecuteReader(OleDbTransaction transaction, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		char[] ⴀႳ = BandModeCacheCfg.ႠႳ;
		return Ⴗ(ShowWx.Ⴃ(transaction, 971, 955), transaction, commandType, commandText, commandParameters, (ႨႣ)1);
	}

	public static OleDbDataReader ExecuteReader(OleDbTransaction transaction, string spName, params object[] parameterValues)
	{
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		int[] ⴀႨ = DirectoryBulletin.ႠႨ;
		byte[] ⴐ = Ⴈ.ႨႣ.Ⴐ;
		object spParameterSet = default(object);
		while (true)
		{
			int num = ((parameterValues == null) ? (ⴀႨ[219] - 45726) : (ⴀ[200] - 61361));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 8;
					continue;
				case 8:
					break;
				case 5:
					num = ((parameterValues.Length <= 0) ? ⴐ[21] : 6);
					continue;
				case 6:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)ShowWx.Ⴃ(transaction, 473, 425), (short)703, (short)693), spName);
					goto case 7;
				case 7:
					num = ⴀႨ[21] - 17706;
					continue;
				case 0:
				case 1:
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					goto case 4;
				case 4:
					return ExecuteReader(transaction, CommandType.StoredProcedure, spName, (OleDbParameter[])spParameterSet);
				case 3:
					return ExecuteReader(transaction, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText)
	{
		return ExecuteScalar(connectionString, commandType, commandText, (OleDbParameter[])null);
	}

	public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		IDbConnection dbConnection = new OleDbConnection(connectionString);
		try
		{
			SetAnnWrapHelp.Ⴀ((DbConnection)(OleDbConnection)dbConnection, 329, (short)330);
			return ExecuteScalar((OleDbConnection)dbConnection, commandType, commandText, commandParameters);
		}
		finally
		{
			int num = 3;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = (((OleDbConnection)dbConnection == null) ? 1 : 4);
					goto IL_007e;
				case 4:
				case 5:
					((IDisposable)(dbConnection as OleDbConnection)).Dispose();
					break;
				case 1:
				case 2:
					break;
				}
				break;
				IL_007e:
				num = num2;
			}
		}
	}

	public static object ExecuteScalar(string connectionString, string spName, params object[] parameterValues)
	{
		Array spParameterSet = default(Array);
		while (true)
		{
			int num = ((parameterValues == null) ? 1 : 5);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 7;
					continue;
				case 4:
				case 7:
					break;
				case 5:
					num = ((parameterValues.Length <= 0) ? 1 : 0);
					continue;
				case 0:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
					goto case 3;
				case 3:
				{
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					object result = ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, (OleDbParameter[])spParameterSet);
					SetDxCountHelp.ႭႤ[128] = (SetDxCountHelp.ႭႤ[128] - SetDxCountHelp.ႭႤ[401]) & 7;
					return result;
				}
				case 1:
					return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static object ExecuteScalar(OleDbConnection connection, CommandType commandType, string commandText)
	{
		return ExecuteScalar(connection, commandType, commandText, (OleDbParameter[])null);
	}

	public static object ExecuteScalar(OleDbConnection connection, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		object result = default(object);
		while (true)
		{
			IDisposable disposable = new OleDbCommand();
			Ⴃ(disposable as OleDbCommand, connection, null, commandType, commandText, commandParameters);
			while (true)
			{
				IL_0044:
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 0;
						continue;
					case 0:
						break;
					case 6:
						goto IL_0044;
					case 2:
						result = ShowTalk.Ⴈ((DbCommand)(OleDbCommand)disposable, (short)366, 256);
						goto case 1;
					case 1:
						SetDxExtensionHelp.Ⴐ((OleDbCommand)disposable, '·', '©').Clear();
						goto case 4;
					case 4:
						num = 3;
						continue;
					case 3:
						return result;
					}
					break;
				}
				break;
			}
		}
	}

	public static object ExecuteScalar(OleDbConnection connection, string spName, params object[] parameterValues)
	{
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		char[] ⴀ = SetAnnChatRooms.Ⴀ;
		Array spParameterSet = default(Array);
		while (true)
		{
			int num = ((parameterValues == null) ? 6 : (ⴄႷ[61] - 8221));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴅ[120] / 5;
					continue;
				case 4:
					break;
				case 0:
					num = ((parameterValues.Length <= 0) ? 6 : 7);
					continue;
				case 5:
				case 7:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)connection, (short)990, (short)980), spName);
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					num = ⴀ[54] - 17319;
					continue;
				case 3:
				{
					object result = ExecuteScalar(connection, CommandType.StoredProcedure, spName, spParameterSet as OleDbParameter[]);
					Ⴈ.ႨႣ.Ⴐ[327] = (byte)((Ⴈ.ႨႣ.Ⴐ[327] * Ⴈ.ႨႣ.Ⴐ[310]) & 0xC3);
					return result;
				}
				case 2:
				case 6:
					return ExecuteScalar(connection, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}

	public static object ExecuteScalar(OleDbTransaction transaction, CommandType commandType, string commandText)
	{
		object result = ExecuteScalar(transaction, commandType, commandText, (OleDbParameter[])null);
		SetAnnMode.ႤႭ[397] = (byte)((SetAnnMode.ႤႭ[397] * SetWxOutput.ႣႰ[35]) & 0x13);
		return result;
	}

	public static object ExecuteScalar(OleDbTransaction transaction, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
	{
		byte[] ⴄႭ = SetAnnMode.ႤႭ;
		char[] ⴍႭ = IpLockoutCacheCfg.ႭႭ;
		object result = default(object);
		while (true)
		{
			DbCommand dbCommand = new OleDbCommand();
			Ⴃ(dbCommand as OleDbCommand, ShowWx.Ⴃ(transaction, 855, 807), transaction, commandType, commandText, commandParameters);
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴄႭ[246];
					continue;
				case 2:
				case 3:
					break;
				case 1:
					result = ShowTalk.Ⴈ((DbCommand)(dbCommand as OleDbCommand), (short)1004, 898);
					goto case 0;
				case 0:
				case 5:
				{
					(dbCommand as OleDbCommand).Parameters.Clear();
					char num2 = ⴍႭ[359];
					BandModeCacheCfg.ႠႳ[325] = (char)((BandModeCacheCfg.ႠႳ[325] | BandModeCacheCfg.ႠႳ[268]) & 0x12);
					num = num2 - 38861;
					continue;
				}
				case 4:
					return result;
				}
				break;
			}
		}
	}

	public static object ExecuteScalar(OleDbTransaction transaction, string spName, params object[] parameterValues)
	{
		char[] ⴄႷ = TxNodeUserCmd.ႤႷ;
		Array spParameterSet = default(Array);
		while (true)
		{
			int num = ((parameterValues == null) ? 8 : (ⴄႷ[60] - 11696));
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
				case 7:
					break;
				case 2:
					num = ((parameterValues.Length <= 0) ? 8 : 6);
					continue;
				case 6:
					spParameterSet = SqlHelperParameterCache.GetSpParameterSet(SetWwvDefaultHelp.Ⴄ((DbConnection)ShowWx.Ⴃ(transaction, 1011, 899), (short)645, (short)655), spName);
					goto case 5;
				case 5:
					num = 1;
					continue;
				case 1:
					Ⴀ(spParameterSet as OleDbParameter[], parameterValues);
					goto case 0;
				case 0:
					return ExecuteScalar(transaction, CommandType.StoredProcedure, spName, spParameterSet as OleDbParameter[]);
				case 8:
					return ExecuteScalar(transaction, CommandType.StoredProcedure, spName);
				}
				break;
			}
		}
	}
}

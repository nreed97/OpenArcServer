using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter.Extensions;
using ArcShared.DxAtlas;

namespace ArcShared.MaintenanceUpdates;

public class DirectoryMonitor : IDirectoryMonitor
{
	private readonly Dictionary<string, DateTime> m_Ⴐ;

	private readonly System.Threading.Timer m_Ⴓ;

	private bool Ⴗ;

	private FileSystemEvent Ⴃ;

	private DxAtlasData.Ⴃ m_Ⴄ = new DxAtlasData.Ⴃ();

	public bool Enable
	{
		set
		{
			int num = 2;
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					num2 = ((this.m_Ⴄ.Ⴄ == null) ? 3 : 5);
					break;
				case 0:
				case 5:
					UtilsLatLon.ႷႨ(this.m_Ⴄ.Ⴄ, value, 691, 'ˡ');
					return;
				case 3:
				case 4:
					return;
				}
				num = num2;
			}
		}
	}

	public event FileSystemEvent Change
	{
		add
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 6;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴃ;
					num = 5;
					break;
				case 5:
					obj = multicastDelegate as FileSystemEvent;
					multicastDelegate2 = (FileSystemEvent)UtilsIdentity.Ⴀ((Delegate)(obj as FileSystemEvent), (Delegate)value, 222, 'á');
					goto case 3;
				case 3:
					num = 1;
					break;
				case 1:
				case 2:
				case 4:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴃ, multicastDelegate2 as FileSystemEvent, obj as FileSystemEvent);
					num = (((object)(multicastDelegate as FileSystemEvent) != (FileSystemEvent)obj) ? (ⴗ[152] - 36439) : (ⴐ[501] - 23267));
					break;
				case 0:
					return;
				}
			}
		}
		remove
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int num = 5;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴃ;
					num = 4;
					continue;
				case 4:
					obj = multicastDelegate as FileSystemEvent;
					multicastDelegate2 = (FileSystemEvent)DownloadUrl2.Ⴜ((Delegate)(obj as FileSystemEvent), (Delegate)value, '÷', 'Í');
					num = ⴃႣ[142] - 62655;
					continue;
				case 1:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴃ, (FileSystemEvent)multicastDelegate2, obj as FileSystemEvent);
					break;
				case 2:
					break;
				case 0:
				case 3:
				case 6:
					return;
				}
				num = (((object)(FileSystemEvent)multicastDelegate != (FileSystemEvent)obj) ? 4 : 3);
			}
		}
	}

	public DirectoryMonitor(string dirPath)
	{
		object obj = new FileSystemWatcher();
		this.m_Ⴄ.Ⴄ = obj as FileSystemWatcher;
		this.m_Ⴐ = new Dictionary<string, DateTime>();
		base._002Ector();
		ArxServerClient.Ⴐ(this.m_Ⴄ.Ⴄ, dirPath, 'ģ', 300);
		UtilsLatLon.ႷႨ(this.m_Ⴄ.Ⴄ, false, 443, 'Ǩ');
		XmlSerializationHelper.Ⴓ<FileSystemWatcher, FileSystemEventHandler>(this.m_Ⴄ.Ⴄ, Ⴀ, 965, 985);
		AnnCfg.ႷႳ<FileSystemWatcher, FileSystemEventHandler>(this.m_Ⴄ.Ⴄ, Ⴀ, 'ŷ', 380);
		this.m_Ⴓ = new System.Threading.Timer(Ⴄ, null, -1, -1);
	}

	public void Start()
	{
		UtilsLatLon.ႷႨ(this.m_Ⴄ.Ⴄ, true, 189, 'ï');
	}

	private void Ⴀ(object P_0, FileSystemEventArgs P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		bool flag = false;
		object ⴐ2 = default(object);
		try
		{
			int num = 6;
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(ⴐ2 = this.m_Ⴐ, ref flag, 'ϻ', 'Ϛ');
					this.m_Ⴐ[ႠႠ(P_1, 887, '\u0350')] = AnnCfg.Ⴓ(466, 'ƭ');
					goto case 2;
				case 2:
					num = 5;
					continue;
				case 4:
				case 5:
					num = ((!Ⴗ) ? 1 : (ⴀ[285] - 19064));
					continue;
				case 1:
					DgvFreqRangeColumnFilter.Ⴀ(this.m_Ⴓ, 1000, 1000, 131, 'Ê');
					Ⴗ = true;
					num = ⴐ[36] - 7451;
					continue;
				case 3:
				case 7:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 5;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 6 : (ⴃႣ[0] - 54036));
					goto IL_010f;
				case 0:
				case 1:
					Monitor.Exit((Dictionary<string, DateTime>)ⴐ2);
					break;
				case 6:
					break;
				}
				break;
				IL_010f:
				num2 = num3;
			}
		}
		switch (0)
		{
		}
	}

	private void Ⴄ(object P_0)
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = null;
		bool flag = false;
		object ⴐ2 = default(object);
		object obj3 = default(object);
		try
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					DownloadUrl2.ႥႰ(ⴐ2 = this.m_Ⴐ, ref flag, 'Ź', 'Ř');
					obj3 = Ⴅ(this.m_Ⴐ);
					goto case 3;
				case 3:
					num = 6;
					continue;
				case 6:
				{
					List<string> obj2 = obj3 as List<string>;
					if ((Action<string>)obj == null)
					{
						obj = new Action<string>(Ⴐ);
					}
					obj2.ForEach(obj as Action<string>);
					num = ((this.m_Ⴐ.Count != 0) ? 4 : (ⴐ[443] - 42157));
					continue;
				}
				case 5:
					DgvFreqRangeColumnFilter.Ⴀ(this.m_Ⴓ, -1, -1, 163, 'ê');
					Ⴗ = false;
					num = 4;
					continue;
				case 4:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 1;
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					num3 = ((!flag) ? 3 : 5);
					goto IL_00fe;
				case 0:
				case 5:
					UtilsString.Ⴜ((object)(ⴐ2 as Dictionary<string, DateTime>), (short)769, '\u0308');
					break;
				case 3:
				case 6:
					break;
				}
				break;
				IL_00fe:
				num2 = num3;
			}
		}
		switch (4)
		{
		case 3:
			return;
		}
		(obj3 as List<string>).ForEach(Ⴓ);
	}

	private List<string> Ⴅ(Dictionary<string, DateTime> P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		object obj = new List<string>();
		DateTime dateTime = AnnCfg.Ⴓ(295, 'Ř');
		Dictionary<string, DateTime>.Enumerator enumerator = P_0.GetEnumerator();
		try
		{
			int num = 0;
			KeyValuePair<string, DateTime> current = default(KeyValuePair<string, DateTime>);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num)
				{
				default:
					num = 9;
					continue;
				case 4:
					current = enumerator.Current;
					goto case 8;
				case 8:
					timeSpan = XmlSerializationHelper.Ⴅ(ref dateTime, current.Value, 97, 117);
					goto case 2;
				case 2:
					num = 7;
					continue;
				case 7:
				{
					double num2 = AnnCfg.ႷႠ(ref timeSpan, 'ɟ', 'ɢ');
					num = ((!(num2 >= 75.0)) ? 9 : (ⴀ[317] - 4375));
					continue;
				}
				case 5:
					(obj as List<string>).Add(current.Key);
					break;
				case 9:
					break;
				case 3:
					goto end_IL_0057;
				}
				int num4;
				if (!enumerator.MoveNext())
				{
					char num3 = ⴗ[144];
					DxCfg.Ⴗ[13] = (char)((DxCfg.Ⴗ[13] + TalkCfg.ႣႣ[129]) & 0x6E);
					num4 = num3 - 45242;
				}
				else
				{
					num4 = 4;
				}
				num = num4;
				continue;
				end_IL_0057:
				break;
			}
		}
		finally
		{
			switch (3)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			}
		}
		return 4 switch
		{
			_ => (List<string>)obj, 
		};
	}

	private void Ⴍ(string P_0)
	{
		int num = 3;
		object ⴃ = default(object);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				ⴃ = Ⴃ;
				goto case 5;
			case 5:
				num2 = (((FileSystemEvent)ⴃ == null) ? 1 : 4);
				break;
			case 4:
				(ⴃ as FileSystemEvent)(P_0);
				UtilsNumeric.Ⴀ[88] = (char)((UtilsNumeric.Ⴀ[88] - UtilsNumeric.Ⴀ[351]) & 0x1A);
				return;
			case 1:
				return;
			}
			num = num2;
		}
	}

	private void Ⴐ(string P_0)
	{
		this.m_Ⴐ.Remove(P_0);
	}

	private void Ⴓ(string P_0)
	{
		Ⴍ(P_0);
	}

	[SecuritySafeCritical]
	static DirectoryMonitor()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static IAsyncResult Ⴈ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, byte[] P_1, int P_2, int P_3, SocketFlags P_4, _0021_00211 P_5, _0021_00210 P_6, char P_7, char P_8) where _0021_00211 : AsyncCallback where _0021_00212 : Socket
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		object obj = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 8;
					continue;
				case 8:
					break;
				case 5:
					num2 = (((P_7 ^ P_8) - 40) ^ num) switch
					{
						0 => 2, 
						_ => ⴀ[296] - 64736, 
					};
					continue;
				case 7:
					obj = null;
					num2 = ⴐ[391] - 8310;
					continue;
				case 2:
					obj = P_0.BeginSend(P_1, P_2, P_3, P_4, P_5, P_6);
					num2 = 10;
					continue;
				case 10:
					num++;
					goto case 4;
				case 4:
					num3 = 2288;
					goto case 0;
				case 0:
				{
					int num4 = 105;
					num2 = ((572 < num3 / 4 - num4) ? 5 : 3);
					continue;
				}
				case 3:
					return (IAsyncResult)obj;
				case 6:
				case 9:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object Ⴜ<_0021_00210>(_0021_00210 P_0, char P_1, short P_2) where _0021_00210 : DataGridViewComboBoxColumn
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴗ = DxCfg.Ⴗ;
		object result = default(object);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 8:
					num2 = (((P_1 ^ P_2) - 28) ^ num) switch
					{
						0 => 3, 
						_ => 0, 
					};
					continue;
				case 0:
				case 6:
					result = null;
					num2 = ⴃႭ[156] - 30515;
					continue;
				case 3:
					result = P_0.DataSource;
					num2 = ⴃႣ[32] - 43998;
					continue;
				case 9:
				{
					num++;
					num3 = P_1 * P_1;
					int num4 = num3;
					TalkCfg.ႣႣ[198] = (char)((TalkCfg.ႣႣ[198] ^ P_2) & 0xFE);
					num3 = P_1 + num4;
					goto case 5;
				}
				case 5:
					num2 = ⴗ[140] - 43356;
					continue;
				case 1:
				case 4:
					num2 = ((num3 % 2 != 0) ? 8 : (ⴃႣ[30] - 55086));
					continue;
				case 10:
					return result;
				case 7:
					num2 = ⴃႣ[3] - 24460;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int ႠႰ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : Version
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int result = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[377] - 25995;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[206] - 36151;
					continue;
				case 5:
					break;
				case 7:
					num2 = (((P_1 ^ P_2) - 54) ^ num) switch
					{
						0 => 11, 
						_ => 6, 
					};
					continue;
				case 4:
				case 6:
					result = P_1;
					num2 = 2;
					continue;
				case 11:
					result = P_0.Minor;
					num2 = 2;
					continue;
				case 2:
				case 3:
				{
					num++;
					int num3 = 284;
					int num4 = 301;
					num2 = ((1806 <= num4 - num3 * 6) ? 9 : 0);
					continue;
				}
				case 9:
					num2 = ⴐ[24] - 3995;
					continue;
				case 0:
				case 10:
					return result;
				case 8:
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string ႠႠ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : FileSystemEventArgs
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		IEnumerable<char> enumerable = default(IEnumerable<char>);
		int num3 = default(int);
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
					num2 = 11;
					continue;
				case 11:
					break;
				case 8:
				case 9:
					TalkCfg.ႣႣ[41] = (char)(TalkCfg.ႣႣ[41] & P_1 & 0xBE);
					num2 = (((P_1 ^ P_2) - 39) ^ num) switch
					{
						0 => ⴐ[125] - 11313, 
						_ => ⴗ[58] - 1702, 
					};
					continue;
				case 2:
				case 4:
					enumerable = null;
					num2 = 10;
					continue;
				case 0:
				case 5:
					enumerable = P_0.FullPath;
					num2 = ⴀ[158] - 56387;
					continue;
				case 10:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					num2 = 7;
					continue;
				case 7:
					num2 = ((num3 % 2 == 0) ? 1 : (ⴃႣ[33] - 33495));
					continue;
				case 1:
					return (string)enumerable;
				case 6:
					num2 = ⴐ[68] - 10436;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႨ<_0021_00210>(_0021_00210 P_0, Padding P_1, int P_2, char P_3) where _0021_00210 : ToolStripItem
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 3;
				break;
			case 3:
			case 4:
				num = (((P_2 ^ P_3) - 39) ^ num3) switch
				{
					0 => ⴃႤ[317] - 38173, 
					_ => 0, 
				};
				break;
			case 0:
				num = ⴗ[33] - 33382;
				break;
			case 1:
				P_0.Margin = P_1;
				goto case 9;
			case 9:
				num3++;
				goto case 2;
			case 2:
				num2 = P_3 * P_3;
				num2 = P_3 + num2;
				num = ⴀ[382] - 13375;
				break;
			case 8:
				num = ((num2 % 2 != 0) ? 3 : (ⴃႤ[103] - 3406));
				break;
			case 7:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static double ႠႷ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴗ = DxCfg.Ⴗ;
		double result = default(double);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 11;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 2:
					break;
				case 11:
					num2 = (((P_1 ^ P_2) - 39) ^ num) switch
					{
						0 => 10, 
						_ => ⴐ[501] - 23266, 
					};
					continue;
				case 1:
				case 3:
					result = 13.841789639700218;
					num2 = 4;
					continue;
				case 7:
				case 9:
				case 10:
					result = Convert.ToDouble(P_0);
					num2 = 4;
					continue;
				case 4:
				{
					num++;
					num3 = P_2 * P_2;
					int num4 = num3;
					WxCfg.ႣႭ[264] = (char)(WxCfg.ႣႭ[264] & P_1 & 0x62);
					num3 = P_2 + num4;
					num2 = 5;
					continue;
				}
				case 5:
					num2 = ((num3 % 2 != 0) ? 11 : 8);
					continue;
				case 8:
					return result;
				case 6:
					num2 = ⴗ[94] - 22928;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႳ<_0021_00210>(_0021_00210 P_0, ApartmentState P_1, char P_2, int P_3) where _0021_00210 : Thread
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 5;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = ⴃႭ[257] - 21115;
				break;
			case 2:
				num = (((P_2 ^ P_3) - 48) ^ num3) switch
				{
					0 => ⴗ[12] - 35082, 
					_ => 8, 
				};
				break;
			case 0:
			case 8:
				num = 3;
				break;
			case 7:
			case 9:
				P_0.SetApartmentState(P_1);
				goto case 3;
			case 3:
				num3++;
				goto case 1;
			case 1:
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				num = 4;
				break;
			case 4:
				num = ((num2 % 2 != 0) ? 2 : 6);
				break;
			case 6:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static FileStream ႠႤ<_0021_00210>(_0021_00210 P_0, int P_1, char P_2) where _0021_00210 : string
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		Stream stream = default(Stream);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴐ[363] - 27682;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 10;
					continue;
				case 10:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 24) ^ num) switch
					{
						0 => 8, 
						_ => 11, 
					};
					continue;
				case 11:
					stream = null;
					num2 = ⴃႣ[102] - 27329;
					continue;
				case 8:
					stream = File.Create(P_0);
					num2 = 0;
					continue;
				case 0:
				case 7:
					num++;
					num3 = P_2 * P_2;
					num3 = P_2 + num3;
					goto case 3;
				case 3:
					num2 = 4;
					continue;
				case 4:
					num2 = ((num3 % 2 != 0) ? (ⴐ[245] - 13575) : 2);
					continue;
				case 2:
				case 9:
					return (FileStream)stream;
				case 6:
					num2 = ⴐ[363] - 27682;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႠႭ<_0021_00210>(_0021_00210 P_0, Formatting P_1, char P_2, int P_3) where _0021_00210 : XmlTextWriter
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 7;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num3 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_2 ^ P_3) - 48) ^ num3) switch
				{
					0 => 5, 
					_ => ⴀ[113] - 11628, 
				};
				break;
			case 4:
				num = ⴗ[139] - 41086;
				break;
			case 5:
				P_0.Formatting = P_1;
				goto case 6;
			case 6:
				num3++;
				num2 = P_2 * P_2;
				num2 = P_2 + num2;
				goto case 2;
			case 2:
			case 8:
				num = 9;
				break;
			case 9:
				num = ((num2 % 2 == 0) ? 3 : 0);
				break;
			case 3:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static object ႠႣ<_0021_00210>(_0021_00210 P_0, short P_1, int P_2) where _0021_00210 : BindingSource
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		object result = default(object);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႣ[185] - 9488;
					continue;
				case 6:
					break;
				case 1:
					num2 = (((P_2 ^ P_1) - 35) ^ num) switch
					{
						0 => 8, 
						_ => ⴃႣ[228] - 10056, 
					};
					continue;
				case 2:
				case 10:
					result = null;
					num2 = 7;
					continue;
				case 8:
					result = P_0.DataSource;
					num2 = 7;
					continue;
				case 7:
				case 9:
					num++;
					num2 = (((P_1 * P_1 + P_1) % 2 == 0) ? (ⴃႭ[209] - 32125) : 3);
					continue;
				case 3:
					num2 = 1;
					continue;
				case 11:
					return result;
				case 5:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}
}

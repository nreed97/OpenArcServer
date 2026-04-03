using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.DgvUtils;
using ArcShared.DgvUtils.DgvFilter;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.ExtensionMethods.Login;
using log4net;

namespace ArcShared.ArcUtils;

public static class UtilsWeb
{
	private static readonly ILog Ⴀ;

	public static string DnsLookup(string hostName)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		IEquatable<string> equatable = default(IEquatable<string>);
		try
		{
			int num = 0;
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
				{
					int num2;
					if (StringConstants.Ⴐ(hostName, 777, 793))
					{
						num2 = 9;
					}
					else
					{
						char num3 = ⴗ[89];
						TalkCfg.ႣႣ[29] = (char)((TalkCfg.ႣႣ[29] * TalkCfg.ႣႣ[150]) & 0x95);
						num2 = num3 - 21002;
					}
					num = num2;
					continue;
				}
				case 9:
					equatable = null;
					goto IL_013b;
				case 2:
				case 7:
				{
					object obj2 = ServerIoCfg.ႤႣ(hostName, 297, 'ŗ');
					array = PrecisionTimer.ႤႣ(obj2 as IPHostEntry, 410, 'ǉ');
					num = 5;
					continue;
				}
				case 5:
					num = (((array as IPAddress[]).Length <= 0) ? 1 : (ⴐ[609] - 31344));
					continue;
				case 8:
				{
					object obj = UtilsString.Ⴍ((object)((IPAddress[])array)[0], '6', 36);
					equatable = (string)obj;
					goto IL_013b;
				}
				case 1:
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(ex.Message);
		}
		switch (3)
		{
		default:
			return null;
		case 4:
			break;
		}
		goto IL_013b;
		IL_013b:
		return equatable as string;
	}

	public static string GetMyIpAddress()
	{
		object obj = string.Empty;
		try
		{
			int num = 3;
			ISerializable serializable = default(ISerializable);
			int num7 = default(int);
			int num8 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 1:
				case 2:
				{
					object obj2 = UtilsCopyright.Ⴅ((WebRequest)serializable, 'ϫ', 1015);
					try
					{
						switch (2)
						{
						default:
						{
							object obj3 = new StreamReader(UtilsXml.Ⴈ(obj2 as WebResponse, 970, 'ϴ'));
							try
							{
								obj = 1 switch
								{
									_ => DgvComboBoxColumnFilter.Ⴃ((TextReader)(obj3 as StreamReader), 632, 570), 
								};
							}
							finally
							{
								int num2 = 6;
								while (true)
								{
									int num3;
									switch (num2)
									{
									default:
										num3 = (((StreamReader)obj3 == null) ? 2 : 5);
										goto IL_0125;
									case 3:
									case 5:
										((IDisposable)(obj3 as StreamReader)).Dispose();
										break;
									case 0:
									case 2:
										break;
									}
									break;
									IL_0125:
									num2 = num3;
								}
							}
							switch (2)
							{
							}
							break;
						}
						}
					}
					finally
					{
						int num4 = 3;
						while (true)
						{
							int num5;
							switch (num4)
							{
							default:
								num5 = ((!(obj2 is WebResponse)) ? 4 : 5);
								goto IL_0187;
							case 5:
								((IDisposable)(WebResponse)obj2).Dispose();
								break;
							case 4:
								break;
							}
							break;
							IL_0187:
							num4 = num5;
						}
					}
					int num6 = 3;
					while (true)
					{
						switch (num6)
						{
						default:
							num7 = ColumnFilterEventArgs.Ⴍ(obj as string, TelnetServerClient.Ⴄ(1945323244, '\u0089', 8), 662, 659) + 9;
							num6 = 2;
							continue;
						case 2:
						case 4:
							num8 = ColumnFilterEventArgs.Ⴍ((string)obj, UtilsString.Ⴐ(null, 6, 192632866), 802, 804);
							goto case 1;
						case 1:
							num6 = 5;
							continue;
						case 5:
						case 6:
							obj = ((string)obj).Substring(num7, num8 - num7);
							break;
						}
						break;
					}
					goto end_IL_0031;
				}
				}
				serializable = ArcLogInRespExt.Ⴀ(UtilsString.Ⴐ(null, 3, 192632834), 996, 976);
				num = 1;
				continue;
				end_IL_0031:
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴀ.Error(ex.Message);
		}
		return 4 switch
		{
			_ => obj as string, 
		};
	}

	[SecuritySafeCritical]
	static UtilsWeb()
	{
		UtilsIdentity.Ⴐ();
		Ⴀ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706507515, 13, 6), 63, 96);
	}
}

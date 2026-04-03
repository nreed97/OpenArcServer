using System;
using System.Collections;
using System.IO;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Telnet;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using log4net;
using Ⴃ;

namespace ArcShared.ArcUtils;

public static class UtilsComp
{
	private static readonly ILog Ⴗ;

	internal static byte[] Ⴅ(string P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		Array array;
		try
		{
			int num = 6;
			Array array3 = default(Array);
			Stream stream = default(Stream);
			MarshalByRefObject marshalByRefObject = default(MarshalByRefObject);
			Array array2 = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					array3 = ႣႼ.ႰႳ(HelpAboutServer.ႷႥ(223, 180), P_0, 487, 'Ʀ');
					num = ⴀ[400] - 20050;
					continue;
				case 7:
					stream = new MemoryStream();
					marshalByRefObject = new DeflaterOutputStream(stream as MemoryStream);
					HelpAboutServer.Ⴜ((Stream)marshalByRefObject, array3 as byte[], 0, ((byte[])array3).Length, 'Ή', 967);
					num = 5;
					continue;
				case 5:
					UtilsIdentity.Ⴅ(marshalByRefObject as Stream, 441, 'ǘ');
					array2 = WwvSpotExt.Ⴅ(stream as MemoryStream, 'Ǒ', 'Ƿ');
					num = 0;
					continue;
				case 0:
				case 1:
					array = (byte[])array2;
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴗ.Warn(ex);
			array = null;
		}
		return 1 switch
		{
			_ => (byte[])array, 
		};
	}

	internal static string Ⴃ(byte[] P_0)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		IEnumerable enumerable;
		try
		{
			int num = 8;
			object obj2 = default(object);
			Array array = default(Array);
			object obj = default(object);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					obj2 = string.Empty;
					array = new byte[4096];
					obj = new InflaterInputStream(new MemoryStream(P_0));
					num = ⴃႤ[313] - 60971;
					continue;
				case 3:
					num2 = DxSpotExt.Ⴈ(obj as Stream, (byte[])array, 0, (array as byte[]).Length, 559, 536);
					goto case 0;
				case 0:
					num = 5;
					continue;
				case 5:
					num = ((num2 <= 0) ? 2 : 7);
					continue;
				case 6:
				case 7:
					obj2 = ReverseBeaconClient.Ⴗ(obj2 as string, PrecisionTimer.ႤႰ(ObjectCopierExt.Ⴄ(912, 966), array as byte[], 0, num2, 'ə', 'ȳ'), 'Ú', '\u0092');
					num = 3;
					continue;
				case 2:
					UtilsIdentity.Ⴅ(obj as Stream, 438, 'Ǘ');
					enumerable = obj2 as string;
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Ⴗ.Warn(ex as Exception);
			enumerable = null;
		}
		return 2 switch
		{
			_ => (string)enumerable, 
		};
	}

	[SecuritySafeCritical]
	static UtilsComp()
	{
		UtilsIdentity.Ⴐ();
		Ⴗ = ArcLogInRqstExt.Ⴍ(ArcLogInRqstExt.Ⴗ(1706506854, 2, 4), 878, 817);
	}
}

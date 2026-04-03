using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using ArcEngine.ArcCmds.User.Wx;
using Ⴈ;

namespace ArcEngine.Callbook;

public sealed class CallBookExtHelper
{
	private static readonly byte[] Ⴐ = new byte[16]
	{
		1, 2, 3, 4, 5, 6, 7, 8, 9, 16,
		17, 18, 19, 20, 21, 22
	};

	private static readonly byte[] Ⴀ = new byte[16]
	{
		2, 3, 4, 5, 6, 7, 8, 9, 16, 17,
		18, 19, 20, 21, 22, 23
	};

	public static string Encrypt(string inVal)
	{
		char[] ⴃႰ = SetWxOutput.ႣႰ;
		byte[] ⴅ = SetTalkCountHelp.Ⴅ;
		object obj4 = default(object);
		Stream stream = default(Stream);
		object obj3 = default(object);
		Array array = default(Array);
		while (true)
		{
			object obj = new UTF8Encoding();
			object obj2 = ႰႭ.Ⴀ((Encoding)(UTF8Encoding)obj, inVal, (short)268, (short)344);
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = ⴃႰ[6] - 7773;
					continue;
				case 3:
					break;
				case 4:
				case 7:
				{
					TripleDES tripleDES = new TripleDESCryptoServiceProvider();
					obj4 = ႰႨ.ႥႷ((SymmetricAlgorithm)(tripleDES as TripleDESCryptoServiceProvider), Ⴐ, Ⴀ, 'Ā', (short)318);
					num = 9;
					continue;
				}
				case 9:
					stream = new MemoryStream();
					obj3 = new CryptoStream((MemoryStream)stream, obj4 as ICryptoTransform, CryptoStreamMode.Write);
					SetWxDefault.Ⴗ((Stream)(CryptoStream)obj3, (byte[])obj2, 0, ((byte[])obj2).Length, 'ɢ', 520);
					num = 8;
					continue;
				case 5:
				case 8:
					MailHelper.Ⴓ(obj3 as CryptoStream, 675, 'ʟ');
					SetWxDefault.Ⴓ((Stream)(MemoryStream)stream, 0L, (short)369, (short)334);
					goto case 6;
				case 6:
					num = 1;
					continue;
				case 1:
					array = new byte[SkimmerValidSpot.Ⴄ((Stream)(stream as MemoryStream), 'Ȉ', 521)];
					(stream as MemoryStream).Read((byte[])array, 0, (stream as MemoryStream).ToArray().Length);
					num = ⴅ[181] - 80;
					continue;
				case 2:
				{
					((CryptoStream)obj3).Close();
					IComparable comparable = Convert.ToBase64String((byte[])array);
					return (string)comparable;
				}
				}
				break;
			}
		}
	}

	public static string Decrypt(string inVal)
	{
		object obj5 = default(object);
		IDisposable disposable = default(IDisposable);
		Array array = default(Array);
		IComparable comparable = default(IComparable);
		while (true)
		{
			object obj = SetWxMode.Ⴗ(inVal, 'Ɏ', 551);
			object obj2 = new TripleDESCryptoServiceProvider();
			object obj3 = ႰႨ.ႥႷ((SymmetricAlgorithm)(TripleDESCryptoServiceProvider)obj2, Ⴐ, Ⴀ, 'ƪ', (short)405);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 7;
					continue;
				case 7:
					break;
				case 2:
				case 3:
					obj5 = new MemoryStream();
					goto case 6;
				case 6:
					disposable = new CryptoStream(obj5 as MemoryStream, obj3 as ICryptoTransform, CryptoStreamMode.Write);
					SetWxDefault.Ⴗ((Stream)(CryptoStream)disposable, (byte[])obj, 0, (obj as byte[]).Length, 'Ύ', 996);
					num = 1;
					continue;
				case 1:
					MailHelper.Ⴓ(disposable as CryptoStream, 512, 'ȼ');
					SetWxDefault.Ⴓ((Stream)(obj5 as MemoryStream), 0L, (short)587, (short)628);
					num = 4;
					continue;
				case 4:
					array = new byte[SkimmerValidSpot.Ⴄ((Stream)(obj5 as MemoryStream), 'ǖ', 471)];
					(obj5 as MemoryStream).Read((byte[])array, 0, ((MemoryStream)obj5).ToArray().Length);
					num = 0;
					continue;
				case 0:
				{
					(disposable as CryptoStream).Close();
					object obj4 = new UTF8Encoding();
					comparable = ((UTF8Encoding)obj4).GetString(array as byte[]);
					goto case 5;
				}
				case 5:
					num = 9;
					continue;
				case 9:
					return comparable as string;
				}
				break;
			}
		}
	}
}

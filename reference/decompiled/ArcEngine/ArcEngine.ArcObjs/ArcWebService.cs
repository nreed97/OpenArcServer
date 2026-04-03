using System.Threading;
using ArcEngine.ArcCaches;
using ArcEngine.ArcCmds.User.Dx;
using ArcEngine.ArcCmds.User.Operating.Mail;
using ArcEngine.ArcCmds.User.Talk;
using log4net;

namespace ArcEngine.ArcObjs;

public sealed class ArcWebService
{
	private static readonly ILog Ⴃ = SkimmerValidSpot.Ⴐ(SetTalkCount.Ⴗ(3, null, 1267015801, typeof(ShowTalkOptions)), 59, 38);

	private SetDxCount.Ⴃ Ⴄ;

	public ArcWebService(ObjectManager om)
	{
		Ⴄ.Ⴐ = om as ObjectManager;
	}

	public void Process()
	{
		object obj = new WaitCallback(Ⴓ);
		DeleteMail.Ⴃ(obj as WaitCallback, (object)string.Empty, 369, 'Ķ');
	}

	private static void Ⴓ(object P_0)
	{
	}
}

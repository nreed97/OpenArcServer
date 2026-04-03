using ArcInterfaces;

namespace ArcEngine.Callbook;

public interface IUsVeCallbook
{
	string CallbookDts { get; }

	CallbookData Search(string call);

	string StateSearch(string call);

	string ShowHam(string call);
}

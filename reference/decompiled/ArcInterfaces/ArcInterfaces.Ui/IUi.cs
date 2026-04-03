using System;

namespace ArcInterfaces.Ui;

public interface IUi
{
	void AddLocalConnect(LocalConnect connect);

	void DeleteLocalConnect(Guid guid);
}

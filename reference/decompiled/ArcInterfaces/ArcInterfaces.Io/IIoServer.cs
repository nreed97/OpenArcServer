namespace ArcInterfaces.Io;

public interface IIoServer
{
	IIoDeviceCfg IoDeviceCfg { get; set; }

	string EofChar { get; set; }

	bool IsConnected { get; }

	event OnIoServerConnectEventHandler OnConnectEvent;

	void Start();

	void Stop();
}

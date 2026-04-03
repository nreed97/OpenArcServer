using System;

namespace ArcInterfaces.Io;

public interface IIoClient
{
	ConnectionState ConnectionState { get; set; }

	string EndPoint { get; set; }

	IIoDeviceCfg IoCfg { get; set; }

	DateTime LastSendDts { get; set; }

	bool IsConnected { get; }

	int LastTenMinuteDxDupeCnt { get; set; }

	int TenMinuteDxDupeCnt { get; set; }

	DateTime ConnectDts { get; set; }

	double[] DxSpotRate { get; set; }

	event OnIoClientRxEventHandler OnRxEvent;

	event OnIoClientConnectEventHandler OnConnectEvent;

	event OnIoClientDisconnectEventHandler OnDisconnectEvent;

	bool Send(byte[] data);

	bool Send(string msg);

	void Connect();

	void Disconnect();

	void OnConnect(string ipAddress);

	void OnDisconnect(string msg);

	void OnRx(string msg);
}

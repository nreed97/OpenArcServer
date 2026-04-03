using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ArcInterfaces.Io;

[XmlType("ClientIoDevice")]
public sealed class ClientIoCfg : IIoDeviceCfg
{
	[Browsable(false)]
	public Guid Id { get; set; }

	public ClientIoType Type { get; set; }

	public IoCategoryType Category => IoCategoryType.Client;

	public string Description { get; set; }

	public bool Enabled { get; set; }

	public string IpAddress { get; set; }

	public int Port { get; set; }

	public string ConnectTo { get; set; }

	public string ConnectAs { get; set; }

	public string Password { get; set; }

	[Browsable(false)]
	[XmlIgnore]
	public string IntroLoginFile { get; set; }

	[Browsable(false)]
	[XmlIgnore]
	public string LoginErrorMsg { get; set; }

	[Browsable(false)]
	[XmlIgnore]
	public string WelcomeLoginFile { get; set; }

	[XmlIgnore]
	[Browsable(false)]
	public string LogoutMsg { get; set; }

	[XmlIgnore]
	[Browsable(false)]
	public string DefaultDxFilter { get; set; }

	[Browsable(false)]
	[XmlIgnore]
	public string DefaultAnnFilter { get; set; }

	[XmlIgnore]
	[Browsable(false)]
	public string DefaultWxFilter { get; set; }

	public ClientIoCfg()
	{
		Id = Guid.NewGuid();
	}

	public ClientIoCfg(ClientIoType type, string description, bool enabled, string ipAddress, int port, string connectTo, string connectAs, string password)
		: this()
	{
		Type = type;
		Description = description;
		Enabled = enabled;
		IpAddress = ipAddress;
		Port = port;
		ConnectTo = connectTo;
		ConnectAs = connectAs;
		Password = password;
	}

	public override string ToString()
	{
		return Description;
	}
}

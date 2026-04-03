using System;

namespace ArcInterfaces.Io;

public interface IIoDeviceCfg
{
	Guid Id { get; set; }

	IoCategoryType Category { get; }

	string Description { get; set; }

	bool Enabled { get; set; }

	string IpAddress { get; set; }

	int Port { get; set; }

	string ConnectTo { get; set; }

	string ConnectAs { get; set; }

	string Password { get; set; }

	string IntroLoginFile { get; set; }

	string LoginErrorMsg { get; set; }

	string WelcomeLoginFile { get; set; }

	string LogoutMsg { get; set; }

	string DefaultDxFilter { get; set; }

	string DefaultAnnFilter { get; set; }

	string DefaultWxFilter { get; set; }
}

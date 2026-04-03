using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ArcServer.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

	public static Settings Default => defaultInstance;

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0, 0")]
	public Point MainFormLocation
	{
		get
		{
			return (Point)this["MainFormLocation"];
		}
		set
		{
			this["MainFormLocation"] = value;
		}
	}

	[DefaultSettingValue("0, 0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public Size MainFormSize
	{
		get
		{
			return (Size)this["MainFormSize"];
		}
		set
		{
			this["MainFormSize"] = value;
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	public StringCollection MainFormGridSettings
	{
		get
		{
			return (StringCollection)this["MainFormGridSettings"];
		}
		set
		{
			this["MainFormGridSettings"] = value;
		}
	}
}

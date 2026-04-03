using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ArcServer.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = new ResourceManager("ArcServer.Properties.Resources", typeof(Resources).Assembly);
				resourceMan = resourceManager;
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap Check2
	{
		get
		{
			object obj = ResourceManager.GetObject("Check2", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap GrnCheck
	{
		get
		{
			object obj = ResourceManager.GetObject("GrnCheck", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap GrnLed
	{
		get
		{
			object obj = ResourceManager.GetObject("GrnLed", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap Health2
	{
		get
		{
			object obj = ResourceManager.GetObject("Health2", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Icon HealthBad
	{
		get
		{
			object obj = ResourceManager.GetObject("HealthBad", resourceCulture);
			return (Icon)obj;
		}
	}

	internal static Icon HealthOk
	{
		get
		{
			object obj = ResourceManager.GetObject("HealthOk", resourceCulture);
			return (Icon)obj;
		}
	}

	internal static Bitmap NilCheck
	{
		get
		{
			object obj = ResourceManager.GetObject("NilCheck", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal static Bitmap RedLed
	{
		get
		{
			object obj = ResourceManager.GetObject("RedLed", resourceCulture);
			return (Bitmap)obj;
		}
	}

	internal Resources()
	{
	}
}

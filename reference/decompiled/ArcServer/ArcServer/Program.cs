using System;
using System.Windows.Forms;
using log4net;

namespace ArcServer;

internal static class Program
{
	private static readonly ILog _log = LogManager.GetLogger("Program");

	[STAThread]
	private static void Main()
	{
		try
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new MainForm());
		}
		catch (Exception ex)
		{
			_log.Fatal("Fatal error Main entry point: " + ex.Message + " - " + ex.Source + " - " + ex.StackTrace);
		}
	}
}

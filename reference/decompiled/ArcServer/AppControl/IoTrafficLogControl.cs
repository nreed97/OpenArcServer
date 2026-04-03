using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AppControl;

[ToolboxBitmap(typeof(AppLogControl), "AppControl.bmp")]
public class IoTrafficLogControl : Panel
{
	private const int SWP_NOOWNERZORDER = 512;

	private const int SWP_NOREDRAW = 8;

	private const int SWP_NOZORDER = 4;

	private const int SWP_SHOWWINDOW = 64;

	private const int WS_EX_MDICHILD = 64;

	private const int SWP_FRAMECHANGED = 32;

	private const int SWP_NOACTIVATE = 16;

	private const int SWP_ASYNCWINDOWPOS = 16384;

	private const int SWP_NOMOVE = 2;

	private const int SWP_NOSIZE = 1;

	private const int GWL_STYLE = -16;

	private const int WS_VISIBLE = 268435456;

	private const int WM_CLOSE = 16;

	private const int WS_CHILD = 1073741824;

	private bool created;

	private IntPtr appWin;

	private string exeName = string.Empty;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Category("Data")]
	[Description("Name of the executable to launch")]
	public string ExeName
	{
		get
		{
			return exeName;
		}
		set
		{
			exeName = value;
		}
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern long GetWindowThreadProcessId(long hWnd, long lpdwProcessId);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	[DllImport("user32.dll", EntryPoint = "GetWindowLongA", SetLastError = true)]
	private static extern long GetWindowLong(IntPtr hwnd, int nIndex);

	[DllImport("user32.dll", EntryPoint = "SetWindowLongA", SetLastError = true)]
	private static extern long SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern long SetWindowPos(IntPtr hwnd, long hWndInsertAfter, long x, long y, long cx, long cy, long wFlags);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	protected override void OnSizeChanged(EventArgs e)
	{
		Invalidate();
		base.OnSizeChanged(e);
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (!created)
		{
			created = true;
			appWin = IntPtr.Zero;
			Process process = null;
			try
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				string directoryName = Path.GetDirectoryName(executingAssembly.Location);
				process = Process.Start(directoryName + "\\Utils\\BareTail.exe", "Logs\\IoTraffic.log");
				while (process.MainWindowHandle == IntPtr.Zero || !IsWindowVisible(process.MainWindowHandle))
				{
					Thread.Sleep(10);
					process.Refresh();
				}
				process.WaitForInputIdle();
				appWin = process.MainWindowHandle;
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Error");
			}
			SetParent(appWin, base.Handle);
			SetWindowLong(appWin, -16, 268435456);
			MoveWindow(appWin, 0, 0, base.Width, base.Height, repaint: true);
		}
		base.OnVisibleChanged(e);
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		if (appWin != IntPtr.Zero)
		{
			PostMessage(appWin, 16u, 0, 0);
			Thread.Sleep(1000);
			appWin = IntPtr.Zero;
		}
		base.OnHandleDestroyed(e);
	}

	protected override void OnResize(EventArgs e)
	{
		if (appWin != IntPtr.Zero)
		{
			MoveWindow(appWin, 0, 0, base.Width, base.Height, repaint: true);
		}
		base.OnResize(e);
	}
}

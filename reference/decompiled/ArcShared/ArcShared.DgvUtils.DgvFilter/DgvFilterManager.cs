using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcInterfaces.Spots;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcIo.Pcxx;
using ArcShared.ArcIo.Telnet;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils.DgvFilter.Implementations;
using ArcShared.DxAtlas;
using ArcShared.ExtensionMethods;
using ArcShared.ExtensionMethods.Login;
using ArcShared.ExtensionMethods.Objects;
using ArcShared.Forms;
using ArcShared.MaintenanceUpdates;
using WindowsFormsApplication1.ApplicationUpdates;
using Ⴃ;

namespace ArcShared.DgvUtils.DgvFilter;

public class DgvFilterManager
{
	private DataGridView m_Ⴄ;

	private DataView m_Ⴅ;

	private int Ⴐ;

	private List<DgvBaseColumnFilter> m_Ⴄ;

	private FilterChangedEventHandler Ⴐ;

	private static Image m_Ⴀ;

	private WwvCfg.Ⴓ m_Ⴍ = new WwvCfg.Ⴓ();

	public bool AutoCreateFilters
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			bool ⴜ = this.m_Ⴍ.Ⴜ;
			DxCfg.Ⴗ[13] = (char)((DxCfg.Ⴗ[13] + TalkCfg.ႣႣ[129]) & 0x6E);
			return ⴜ;
		}
		set
		{
			bool ⴜ = value;
			this.m_Ⴍ.Ⴜ = ⴜ;
		}
	}

	public DgvBaseFilterHost FilterHost
	{
		get
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			while (true)
			{
				DgvBaseFilterHost ⴈ = this.m_Ⴍ.Ⴈ;
				WxCfg.ႣႭ[261] = (char)((WxCfg.ႣႭ[261] ^ WxCfg.ႣႭ[3]) & 0xBE);
				int num = ((ⴈ != null) ? (ⴃႭ[32] - 53233) : 6);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႭ[54] - 54504;
						continue;
					case 1:
						break;
					case 0:
					case 6:
						FilterHost = new DgvFilterHost();
						goto case 3;
					case 3:
					case 5:
						return this.m_Ⴍ.Ⴈ;
					}
					break;
				}
			}
		}
		set
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					this.m_Ⴍ.Ⴈ = value;
					this.m_Ⴍ.Ⴈ.FilterManager = this;
					break;
				case 4:
					break;
				case 1:
				case 3:
					UtilsCallsign.ႰႰ<ToolStripDropDownClosedEventHandler, ToolStripDropDown>(this.m_Ⴍ.Ⴈ.Popup, Ⴓ, 216, 245);
					return;
				case 0:
					return;
				}
				char num2 = ⴃႣ[234];
				DataGridViewColumnSelector.Ⴐ[81] = (char)((DataGridViewColumnSelector.Ⴐ[81] - TalkCfg.ႣႣ[92]) & 8);
				num = num2 - 20663;
			}
		}
	}

	public DataGridView DataGridView
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			return this.m_Ⴄ;
		}
		set
		{
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					this.m_Ⴄ = value;
					this.m_Ⴄ = new List<DgvBaseColumnFilter>(UtilsVersion.Ⴓ((BaseCollection)ႭႰ(this.m_Ⴄ, 'Ķ', 272), 338, 'Ŕ'));
					num = 6;
					continue;
				case 6:
				case 7:
					Ⴗ();
					UtilsXml.ႨႠ(this.m_Ⴄ, DataGridViewColumnHeadersHeightSizeMode.AutoSize, 27, '\0');
					DxCommentExtCfg.ႷႠ<DataGridViewCellMouseEventHandler, DataGridView>(this.m_Ⴄ, mDataGridView_CellMouseClick, 587, 585);
					num = 4;
					continue;
				case 3:
				case 4:
					ArcLogInRqstExt.ႠႠ<DataGridViewCellPaintingEventHandler, DataGridView>(this.m_Ⴄ, Ⴃ, 182, 'Ó');
					PcxxServerClient.Ⴍ<DataGridViewColumnEventHandler, DataGridView>(this.m_Ⴄ, Ⴄ, 912, 957);
					num = 1;
					continue;
				case 1:
					WwvCfg.Ⴈ<DataGridView, DataGridViewColumnEventHandler>(this.m_Ⴄ, Ⴀ, 'Κ', 926);
					break;
				case 5:
					break;
				case 0:
					return;
				}
				if (this.m_Ⴄ != null)
				{
					break;
				}
				num = 0;
			}
			object obj = PrecisionTimer.ႤႭ((BaseCollection)ႭႰ(this.m_Ⴄ, 'ɓ', 629), (short)208, 208);
			try
			{
				int num2 = 4;
				object obj2 = default(object);
				while (true)
				{
					switch (num2)
					{
					default:
						num2 = 5;
						continue;
					case 2:
						obj2 = (DataGridViewColumn)((IEnumerator)obj).Current;
						goto case 3;
					case 3:
					case 7:
						this.m_Ⴄ.Add(null);
						Ⴃ(obj2 as DataGridViewColumn);
						break;
					case 5:
						break;
					case 6:
						goto end_IL_0174;
					}
					num2 = ((obj as IEnumerator).MoveNext() ? 2 : 6);
					continue;
					end_IL_0174:
					break;
				}
			}
			finally
			{
				int num3 = 6;
				object obj3 = default(object);
				while (true)
				{
					int num4;
					switch (num3)
					{
					default:
						obj3 = (obj as IEnumerator) as IDisposable;
						num4 = (((IDisposable)obj3 == null) ? 3 : (ⴗ[124] - 24225));
						goto IL_0225;
					case 1:
					case 4:
						(obj3 as IDisposable).Dispose();
						break;
					case 0:
					case 3:
						break;
					}
					break;
					IL_0225:
					num3 = num4;
				}
			}
			switch (0)
			{
			}
		}
	}

	public string BaseFilter
	{
		get
		{
			return this.m_Ⴍ.Ⴐ;
		}
		set
		{
			this.m_Ⴍ.Ⴐ = value;
			RebuildFilter();
		}
	}

	public DgvBaseColumnFilter this[int ColumnIndex]
	{
		get
		{
			DgvBaseColumnFilter result = this.m_Ⴄ[ColumnIndex];
			UtilsNumeric.Ⴀ[338] = (char)(UtilsNumeric.Ⴀ[338] & ColumnIndex & 0x4C);
			return result;
		}
		set
		{
			this.m_Ⴄ[ColumnIndex] = value;
			value.Init(this, FilterHost, UtilsCallsign.ႰႷ(ႭႰ(this.m_Ⴄ, 'ɾ', 600), ColumnIndex, 778, '\u0308'), this.m_Ⴅ);
		}
	}

	public DgvBaseColumnFilter this[string ColumnName]
	{
		get
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			return this.m_Ⴄ[AutoUpdater.ႭႭ(ႭႰ(this.m_Ⴄ, 'Ĳ', 276), ColumnName, 193, 187).Index];
		}
		set
		{
			this[AutoUpdater.ႭႭ(ႭႰ(this.m_Ⴄ, 'ɨ', 590), ColumnName, 13, 119).Index] = value;
		}
	}

	public static Image FunnelPicture
	{
		get
		{
			char[] ⴗ = DxCfg.Ⴗ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			while (true)
			{
				int num = ((DgvFilterManager.m_Ⴀ == null) ? (ⴗ[88] - 34719) : 0);
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = 2;
						continue;
					case 2:
					case 4:
						break;
					case 3:
					case 6:
					{
						object obj = new ComponentResourceManager(typeof(DgvFilterHost));
						DgvFilterManager.m_Ⴀ = (Image)TelnetServerClient.ႥႥ((ResourceManager)(obj as ComponentResourceManager), ႣႼ.ႥႭ(null, 624735718, 8, null), 410, 'ƍ');
						num = ⴃႣ[32] - 44007;
						continue;
					}
					case 0:
						return DgvFilterManager.m_Ⴀ;
					}
					break;
				}
			}
		}
	}

	public event ColumnFilterEventHandler ColumnFilterAdding
	{
		add
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 6;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ.Ⴍ;
					num = ⴀ[180] - 56360;
					break;
				case 5:
					obj = multicastDelegate as ColumnFilterEventHandler;
					multicastDelegate2 = (ColumnFilterEventHandler)UtilsIdentity.Ⴀ((Delegate)(ColumnFilterEventHandler)obj, (Delegate)value, 799, '\u0320');
					num = 0;
					break;
				case 0:
				case 1:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴍ, (ColumnFilterEventHandler)multicastDelegate2, (ColumnFilterEventHandler)obj);
					num = ⴃႣ[15] - 18748;
					break;
				case 2:
				case 3:
					num = (((object)(ColumnFilterEventHandler)multicastDelegate != (ColumnFilterEventHandler)obj) ? (ⴗ[85] - 5445) : (ⴃႣ[21] - ⴃႣ[104]));
					break;
				case 4:
				case 7:
					return;
				}
			}
		}
		remove
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			int num = 5;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ.Ⴍ;
					num = ⴃႤ[482] - 36634;
					break;
				case 0:
					obj = (ColumnFilterEventHandler)multicastDelegate;
					obj2 = (ColumnFilterEventHandler)DownloadUrl2.Ⴜ((Delegate)(ColumnFilterEventHandler)obj, (Delegate)value, 'a', '[');
					goto case 2;
				case 2:
					num = 6;
					break;
				case 6:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴍ, obj2 as ColumnFilterEventHandler, (ColumnFilterEventHandler)obj);
					goto case 3;
				case 3:
					num = 7;
					break;
				case 7:
				{
					int num3;
					if ((object)(multicastDelegate as ColumnFilterEventHandler) == obj as ColumnFilterEventHandler)
					{
						char num2 = ⴐ[356];
						TalkCfg.ႣႣ[123] = (char)((TalkCfg.ႣႣ[123] - TalkCfg.ႣႣ[127]) & 0x72);
						num3 = num2 - 31993;
					}
					else
					{
						num3 = ⴃႤ[430] - 33415;
					}
					num = num3;
					break;
				}
				case 1:
					return;
				}
			}
		}
	}

	public event ColumnFilterEventHandler ColumnFilterAdded
	{
		add
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			int num = 7;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ.Ⴃ;
					num = 0;
					break;
				case 0:
				case 2:
				case 5:
					obj = (ColumnFilterEventHandler)multicastDelegate;
					multicastDelegate2 = (ColumnFilterEventHandler)UtilsIdentity.Ⴀ((Delegate)(ColumnFilterEventHandler)obj, (Delegate)value, 98, ']');
					num = ⴃႭ[74] - 34516;
					break;
				case 3:
				case 6:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴃ, multicastDelegate2 as ColumnFilterEventHandler, obj as ColumnFilterEventHandler);
					num = 4;
					break;
				case 4:
					num = (((object)(multicastDelegate as ColumnFilterEventHandler) == (ColumnFilterEventHandler)obj) ? 1 : 0);
					break;
				case 1:
					return;
				}
			}
		}
		remove
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int num = 5;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ.Ⴃ;
					num = ⴐ[132] - 38107;
					break;
				case 0:
					obj = multicastDelegate as ColumnFilterEventHandler;
					obj2 = (ColumnFilterEventHandler)DownloadUrl2.Ⴜ((Delegate)(ColumnFilterEventHandler)obj, (Delegate)value, 'õ', 'Ï');
					num = ⴀ[225] - 22439;
					break;
				case 4:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴃ, obj2 as ColumnFilterEventHandler, (ColumnFilterEventHandler)obj);
					goto case 7;
				case 7:
					num = 6;
					break;
				case 6:
					num = (((object)(ColumnFilterEventHandler)multicastDelegate != (ColumnFilterEventHandler)obj) ? (ⴃႣ[197] - 30627) : 2);
					break;
				case 2:
				case 3:
					return;
				}
			}
		}
	}

	public event ColumnFilterEventHandler PopupShowing
	{
		add
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			char[] ⴃႭ = WxCfg.ႣႭ;
			int num = 7;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ.Ⴄ;
					num = 1;
					break;
				case 1:
				case 4:
					obj = multicastDelegate as ColumnFilterEventHandler;
					multicastDelegate2 = (ColumnFilterEventHandler)UtilsIdentity.Ⴀ((Delegate)(ColumnFilterEventHandler)obj, (Delegate)value, 466, 'ǭ');
					num = ⴐ[300] - 16238;
					break;
				case 2:
				case 3:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴄ, multicastDelegate2 as ColumnFilterEventHandler, (ColumnFilterEventHandler)obj);
					num = ⴃႭ[249] - 12436;
					break;
				case 6:
					num = (((object)(ColumnFilterEventHandler)multicastDelegate != obj as ColumnFilterEventHandler) ? 1 : 5);
					break;
				case 0:
				case 5:
					return;
				}
			}
		}
		remove
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			int num = 0;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ.Ⴄ;
					num = 4;
					break;
				case 4:
				case 5:
					obj = (ColumnFilterEventHandler)multicastDelegate;
					obj2 = (ColumnFilterEventHandler)DownloadUrl2.Ⴜ((Delegate)(obj as ColumnFilterEventHandler), (Delegate)value, 'Ô', 'î');
					num = 6;
					break;
				case 6:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴄ, obj2 as ColumnFilterEventHandler, obj as ColumnFilterEventHandler);
					num = 1;
					break;
				case 1:
				case 3:
					num = (((object)(ColumnFilterEventHandler)multicastDelegate != obj as ColumnFilterEventHandler) ? (ⴃႤ[190] - 21435) : 2);
					break;
				case 2:
				case 7:
					return;
				}
			}
		}
	}

	public event FilterChangedEventHandler FilterChanged
	{
		add
		{
			int num = 5;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			MulticastDelegate multicastDelegate3 = default(MulticastDelegate);
			MulticastDelegate multicastDelegate2 = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = Ⴐ;
					num = 6;
					break;
				case 6:
					multicastDelegate3 = (FilterChangedEventHandler)multicastDelegate;
					goto case 4;
				case 4:
					multicastDelegate2 = (FilterChangedEventHandler)UtilsIdentity.Ⴀ((Delegate)(multicastDelegate3 as FilterChangedEventHandler), (Delegate)value, 136, '·');
					num = 2;
					break;
				case 1:
				case 2:
					multicastDelegate = Interlocked.CompareExchange(ref Ⴐ, (FilterChangedEventHandler)multicastDelegate2, (FilterChangedEventHandler)multicastDelegate3);
					num = (((object)(FilterChangedEventHandler)multicastDelegate != multicastDelegate3 as FilterChangedEventHandler) ? 6 : 3);
					break;
				case 3:
					return;
				}
			}
		}
		remove
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			int num = 2;
			object obj = default(object);
			object obj2 = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			while (true)
			{
				switch (num)
				{
				default:
				{
					obj = Ⴐ;
					char num2 = ⴀ[275];
					DataGridViewColumnSelector.Ⴐ[364] = (char)(DataGridViewColumnSelector.Ⴐ[364] & NeedsCfg.ႣႤ[606] & 0x46);
					num = num2 - 40483;
					break;
				}
				case 0:
					obj2 = (FilterChangedEventHandler)obj;
					multicastDelegate = (FilterChangedEventHandler)DownloadUrl2.Ⴜ((Delegate)(FilterChangedEventHandler)obj2, (Delegate)value, '\u0334', '\u030e');
					goto case 1;
				case 1:
				case 5:
					num = ⴃႣ[134] - 14880;
					break;
				case 6:
					obj = Interlocked.CompareExchange(ref Ⴐ, (FilterChangedEventHandler)multicastDelegate, (FilterChangedEventHandler)obj2);
					num = (((object)(obj as FilterChangedEventHandler) != (FilterChangedEventHandler)obj2) ? (ⴐ[450] - ⴐ[450]) : (ⴃႤ[424] - 7515));
					break;
				case 3:
					return;
				}
			}
		}
	}

	public event FilterSavedEventHandler FilterSaved
	{
		add
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			int num = 3;
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj = default(object);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					multicastDelegate = this.m_Ⴍ.Ⴀ;
					num = ⴃႤ[221] - 30808;
					break;
				case 6:
					obj = multicastDelegate as FilterSavedEventHandler;
					obj2 = (FilterSavedEventHandler)UtilsIdentity.Ⴀ((Delegate)(FilterSavedEventHandler)obj, (Delegate)value, 202, 'õ');
					goto case 4;
				case 4:
					num = 5;
					break;
				case 0:
				case 5:
					multicastDelegate = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴀ, (FilterSavedEventHandler)obj2, (FilterSavedEventHandler)obj);
					num = ⴀ[381] - 35980;
					break;
				case 1:
					num = (((object)(FilterSavedEventHandler)multicastDelegate != (FilterSavedEventHandler)obj) ? 6 : (ⴐ[443] - 42160));
					break;
				case 2:
					return;
				}
			}
		}
		remove
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			char[] ⴗ = DxCfg.Ⴗ;
			int num = 0;
			object obj = default(object);
			MulticastDelegate multicastDelegate = default(MulticastDelegate);
			object obj2 = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					obj = this.m_Ⴍ.Ⴀ;
					num = 1;
					break;
				case 1:
				case 2:
					multicastDelegate = obj as FilterSavedEventHandler;
					obj2 = (FilterSavedEventHandler)DownloadUrl2.Ⴜ((Delegate)(FilterSavedEventHandler)multicastDelegate, (Delegate)value, 'Ϯ', 'ϔ');
					goto case 5;
				case 5:
				case 6:
					num = ⴃႭ[86] - 2789;
					break;
				case 7:
					obj = Interlocked.CompareExchange(ref this.m_Ⴍ.Ⴀ, (FilterSavedEventHandler)obj2, (FilterSavedEventHandler)multicastDelegate);
					num = 4;
					break;
				case 4:
				{
					int num2;
					if ((object)(FilterSavedEventHandler)obj == (FilterSavedEventHandler)multicastDelegate)
					{
						num2 = 3;
					}
					else
					{
						char num3 = ⴗ[23];
						WxCfg.ႣႭ[84] = (char)(WxCfg.ႣႭ[84] & DxCfg.Ⴗ[47] & 0x21);
						num2 = num3 - 59671;
					}
					num = num2;
					break;
				}
				case 3:
					return;
				}
			}
		}
	}

	public DgvFilterManager()
	{
		IEnumerable empty = string.Empty;
		this.m_Ⴍ.Ⴐ = empty as string;
		this.Ⴐ = -1;
		this.m_Ⴍ.Ⴓ = true;
		base._002Ector();
	}

	public DgvFilterManager(DataGridView dataGridView, bool autoCreateFilters)
	{
		IComparable empty = string.Empty;
		this.m_Ⴍ.Ⴐ = (string)empty;
		this.Ⴐ = -1;
		this.m_Ⴍ.Ⴓ = true;
		base._002Ector();
		bool ⴓ = autoCreateFilters;
		this.m_Ⴍ.Ⴓ = ⴓ;
		DataGridView = dataGridView;
	}

	public DgvFilterManager(DataGridView dataGridView)
		: this(dataGridView, autoCreateFilters: true)
	{
	}

	private void Ⴀ(object P_0, DataGridViewColumnEventArgs P_1)
	{
		this.m_Ⴄ.RemoveAt(DxAtlasData.Ⴜ(P_1, 'ʼ', 'ː').Index);
	}

	private void Ⴄ(object P_0, DataGridViewColumnEventArgs P_1)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				Ⴗ();
				break;
			case 4:
				break;
			case 3:
				Ⴃ(P_1.Column);
				return;
			case 0:
			case 1:
				return;
			}
			this.m_Ⴄ.Insert(TelnetServerClient.ႥႰ((DataGridViewBand)DxAtlasData.Ⴜ(P_1, 'ʧ', 'ˋ'), (short)975, (short)957), null);
			num = ⴃႭ[46] - 55840;
		}
	}

	protected virtual void mDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((ArcLogInRqstExt.Ⴄ((MouseEventArgs)e, 181, (short)148) == MouseButtons.Right) ? 6 : 0);
				break;
			case 6:
				num = ((ColumnFilterEventArgs.Ⴓ(e, 712, 667) == -1) ? 4 : 0);
				break;
			case 4:
				num = ((ColumnFilterEventArgs.Ⴓ(e, 995, 951) > -1) ? (ⴃႣ[9] - 32477) : 0);
				break;
			case 3:
				ShowPopup(e.ColumnIndex);
				return;
			case 0:
			case 1:
			case 7:
				return;
			}
		}
	}

	private void Ⴃ(object P_0, DataGridViewCellPaintingEventArgs P_1)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				return;
			}
			if (AnnCfg.ႷႭ(P_1, '\u02e5', '\u02f1') != -1)
			{
				num = 1;
				continue;
			}
			while (true)
			{
				int num2 = ((AnnCfg.ႷႭ(P_1, '\u0092', '\u0086') != -1) ? (ⴃႣ[35] - 31531) : (ⴃႣ[221] - 58060));
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 12:
						break;
					case 11:
					case 14:
						num2 = ((ႣႼ.ႰႣ(P_1, 182, 156) == -1) ? 13 : 0);
						continue;
					case 13:
						num2 = ((!this.m_Ⴍ.Ⴗ) ? (ⴃႣ[83] - 56484) : 15);
						continue;
					case 4:
					case 15:
						OnFilteredGridPaint(P_0, P_1);
						return;
					case 0:
					case 2:
						num2 = ((!UnZipFiles.Ⴗ(FilterHost.Popup, 146, '¹')) ? (ⴃႭ[161] - 54232) : 7);
						continue;
					case 7:
						OnHighlightedColumnPaint(P_0, P_1);
						goto case 9;
					case 9:
						num2 = ((ႣႼ.ႰႣ(P_1, 834, 872) != -1) ? (ⴐ[333] - 28074) : (ⴀ[132] - 32885));
						continue;
					case 1:
						return;
					case 3:
					{
						DgvBaseColumnFilter dgvBaseColumnFilter = this.m_Ⴄ[P_1.ColumnIndex];
						DataGridViewColumnSelector.Ⴐ[63] = (char)((DataGridViewColumnSelector.Ⴐ[63] | UtilsNumeric.Ⴀ[114]) & 0x43);
						num2 = ((dgvBaseColumnFilter == null) ? (ⴐ[183] - 20609) : 10);
						continue;
					}
					case 10:
						num2 = ((!this.m_Ⴄ[P_1.ColumnIndex].Active) ? 8 : 6);
						continue;
					case 6:
						OnFilteredColumnPaint(P_0, P_1);
						return;
					case 8:
						return;
					}
					break;
				}
			}
		}
	}

	protected virtual void OnFilteredGridPaint(object sender, DataGridViewCellPaintingEventArgs e)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 6;
		Rectangle rect = default(Rectangle);
		while (true)
		{
			switch (num)
			{
			default:
				FrmUpdating.ႠႳ(DxSpotExt.Ⴓ(e, 957, 1021), StringConstants.Ⴃ(905, '\u038b'), WwvSpotExt.Ⴐ(e, '\u036a', '\u0351'), ';', 772);
				goto case 3;
			case 3:
				num = ⴃႤ[365] - 63906;
				continue;
			case 0:
				ReverseBeaconClient.Ⴍ(e, WwvSpotExt.Ⴐ(e, 'ɏ', 'ɴ'), DownloadUrl2.ႥႼ(e, 'ψ', 984) & ~DataGridViewPaintParts.Background, 'ϴ', 900);
				num = 4;
				continue;
			case 4:
			{
				Rectangle rectangle = WwvSpotExt.Ⴐ(e, 'υ', 'Ͼ');
				int x2 = ႰႣ.ႰႰ(ref rectangle, 'ƨ', 509) + 1;
				Rectangle rectangle2 = WwvSpotExt.Ⴐ(e, '\u007f', 'D');
				int y = PrecisionTimer.ႷႰ(ref rectangle2, 860, 793) + 1;
				Rectangle rectangle3 = WwvSpotExt.Ⴐ(e, 'ʬ', 'ʗ');
				rect = new Rectangle(x2, y, CtyInfo.Ⴄ(ref rectangle3, '\u0384', 1000) - 3, WwvSpotExt.Ⴐ(e, '\u031b', '\u0320').Height - 4);
				num = 7;
				continue;
			}
			case 7:
			{
				Graphics graphics = e.Graphics;
				Image funnelPicture = FunnelPicture;
				int x = (e.CellBounds.Width - FunnelPicture.Width) / 2;
				int height = e.CellBounds.Height;
				int height2 = FunnelPicture.Height;
				WxCfg.ႣႭ[224] = (char)((WxCfg.ႣႭ[224] * WxCfg.ႣႭ[97]) & 0xCA);
				graphics.DrawImage(funnelPicture, x, (height - height2) / 2, FunnelPicture.Width, FunnelPicture.Height);
				num = 2;
				continue;
			}
			case 2:
				e.Graphics.DrawRectangle(Pens.Black, rect);
				break;
			case 5:
				break;
			case 1:
				return;
			}
			break;
		}
		e.Handled = true;
	}

	protected virtual void OnHighlightedColumnPaint(object sender, DataGridViewCellPaintingEventArgs e)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int num = 5;
		Rectangle rect = default(Rectangle);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((ႣႼ.ႰႣ(e, 365, 327) == this.Ⴐ) ? 2 : 0);
				break;
			case 2:
			case 3:
				if (AnnCfg.ႷႭ(e, '6', '"') != -1)
				{
					num = ⴃႣ[59] - 7258;
					break;
				}
				while (true)
				{
					ReverseBeaconClient.Ⴍ(e, WwvSpotExt.Ⴐ(e, '\u035c', '\u0367'), DataGridViewPaintParts.All, 'σ', 947);
					while (true)
					{
						IL_00bc:
						int num2 = 2;
						while (true)
						{
							switch (num2)
							{
							default:
								/*OpCode not supported: LdMemberToken*/;
								return;
							case 6:
								break;
							case 3:
								goto IL_00bc;
							case 2:
							{
								Rectangle rectangle = WwvSpotExt.Ⴐ(e, 'ʌ', 'ʷ');
								int x = ႰႣ.ႰႰ(ref rectangle, 'ͳ', 806) + 1;
								Rectangle rectangle2 = WwvSpotExt.Ⴐ(e, 'Ϯ', 'ϕ');
								rect = new Rectangle(x, PrecisionTimer.ႷႰ(ref rectangle2, 72, 13) + 1, e.CellBounds.Width - 3, e.CellBounds.Height - 4);
								goto case 0;
							}
							case 0:
								num2 = ⴃႭ[262] - 43411;
								continue;
							case 4:
								e.Graphics.DrawRectangle(Pens.Yellow, rect);
								e.Handled = true;
								return;
							case 1:
								return;
							}
							break;
						}
						break;
					}
				}
			case 0:
			case 4:
				return;
			}
		}
	}

	protected virtual void OnFilteredColumnPaint(object sender, DataGridViewCellPaintingEventArgs e)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 2;
		Rectangle rect = default(Rectangle);
		while (true)
		{
			switch (num)
			{
			default:
				FrmUpdating.ႠႳ(DxSpotExt.Ⴓ(e, 528, 592), AnnWxSpotExt.ႤႼ(171, '\u00ad'), WwvSpotExt.Ⴐ(e, 'Ŝ', 'ŧ'), 'ǅ', 447);
				num = ⴃႭ[257] - 21111;
				break;
			case 6:
				ReverseBeaconClient.Ⴍ(e, WwvSpotExt.Ⴐ(e, '\u0085', '¾'), DownloadUrl2.ႥႼ(e, 'ġ', 305) & ~DataGridViewPaintParts.Background, 'ĺ', 330);
				goto case 5;
			case 5:
				num = 1;
				break;
			case 1:
			{
				Rectangle rectangle = WwvSpotExt.Ⴐ(e, '\u02df', 'ˤ');
				int num2 = ႰႣ.ႰႰ(ref rectangle, 'i', 60);
				WxCfg.ႣႭ[290] = (char)(WxCfg.ႣႭ[290] & WxCfg.ႣႭ[92] & 0xAF);
				rect = new Rectangle(num2 + 1, WwvSpotExt.Ⴐ(e, 'ĺ', 'ā').Y + 1, e.CellBounds.Width - 3, e.CellBounds.Height - 4);
				goto case 3;
			}
			case 3:
				num = ⴗ[12] - 35087;
				break;
			case 4:
				e.Graphics.DrawRectangle(Pens.Black, rect);
				e.Handled = true;
				return;
			case 0:
				return;
			}
		}
	}

	private void Ⴓ(object P_0, ToolStripDropDownClosedEventArgs P_1)
	{
		XmlSerializationHelper.Ⴈ(this.m_Ⴄ, this.Ⴐ, -1, 'ĩ', 'Ļ');
	}

	public void ShowPopup(int ColumnIndex)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 0;
		EventArgs e = default(EventArgs);
		while (true)
		{
			switch (num)
			{
			case 2:
			case 3:
			case 4:
				return;
			}
			if (this.m_Ⴄ[ColumnIndex] == null)
			{
				num = 3;
				continue;
			}
			while (true)
			{
				int ⴐ = this.Ⴐ;
				while (true)
				{
					IL_0070:
					this.Ⴐ = ColumnIndex;
					Rectangle rectangle = DxSpotExt.Ⴐ(this.m_Ⴄ, ColumnIndex, -1, false, 813, 834);
					while (true)
					{
						switch (ⴃႤ[500])
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 25131:
							return;
						case 25134:
							break;
						case 25133:
							goto IL_0070;
						case 25135:
							continue;
						case 25132:
						{
							FilterHost.CurrentColumnFilter = this.m_Ⴄ[ColumnIndex];
							try
							{
								switch (0)
								{
								default:
									XmlSerializationHelper.Ⴈ(this.m_Ⴄ, ⴐ, -1, 'L', '^');
									break;
								case 4:
									break;
								}
							}
							catch
							{
							}
							int num2 = 8;
							while (true)
							{
								switch (num2)
								{
								default:
									e = new ColumnFilterEventArgs(UtilsCallsign.ႰႷ(ႭႰ(this.m_Ⴄ, 'Ğ', 312), ColumnIndex, 677, 'ʧ'), this.m_Ⴄ[ColumnIndex]);
									num2 = 3;
									continue;
								case 3:
									num2 = ((this.m_Ⴍ.Ⴄ == null) ? (ⴃႣ[216] - 57480) : 4);
									continue;
								case 1:
								case 2:
								case 4:
									this.m_Ⴍ.Ⴄ(this, (ColumnFilterEventArgs)e);
									goto case 0;
								case 0:
									num2 = (((ColumnFilterEventArgs)e).Handled ? 7 : 6);
									continue;
								case 6:
									FilterHost.Popup.Show(this.m_Ⴄ, ႰႣ.ႰႰ(ref rectangle, '\u0318', 845) + CtyInfo.Ⴄ(ref rectangle, '\u008a', 230) - 4, rectangle.Y - 10);
									break;
								case 7:
									break;
								}
								break;
							}
							FilterHost.Popup.Focus();
							this.m_Ⴄ.InvalidateCell(this.Ⴐ, -1);
							return;
						}
						}
						break;
					}
					break;
				}
			}
		}
	}

	public void ActivateFilter(bool Active, int ColumnIndex)
	{
		this[ColumnIndex].Active = Active;
		RebuildFilter();
		DxCfg.Ⴗ[13] = (char)((DxCfg.Ⴗ[13] * WxCfg.ႣႭ[224]) & 0xF2);
	}

	public void ActivateFilter(bool Active, string ColumnName)
	{
		this[ColumnName].Active = Active;
		RebuildFilter();
	}

	public void ActivateFilter(bool Active)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
			case 2:
			case 4:
				return;
			}
			if (this.Ⴐ == -1)
			{
				num = 2;
				continue;
			}
			while (true)
			{
				this[this.Ⴐ].Active = Active;
				switch ((!Active) ? 2 : (ⴗ[139] - 41086))
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 0:
				case 4:
					return;
				case 1:
					continue;
				case 6:
					this[this.Ⴐ].FilterExpressionBuild();
					break;
				case 2:
					break;
				}
				break;
			}
			RebuildFilter();
			return;
		}
	}

	public void ActivateAllFilters(bool Active)
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		using (List<DgvBaseColumnFilter>.Enumerator enumerator = this.m_Ⴄ.GetEnumerator())
		{
			int num = 1;
			UserControl current = default(UserControl);
			while (true)
			{
				switch (num)
				{
				case 6:
					current = enumerator.Current;
					num = ((!(current is DgvBaseColumnFilter)) ? 7 : (ⴃႣ[176] - 11042));
					continue;
				case 4:
					(current as DgvBaseColumnFilter).Active = Active;
					goto case 5;
				case 5:
					num = ((!Active) ? (ⴃႭ[43] - 34343) : 0);
					continue;
				case 0:
					((DgvBaseColumnFilter)current).FilterExpressionBuild();
					break;
				case 8:
					goto end_IL_001c;
				}
				num = (enumerator.MoveNext() ? 6 : (ⴃႣ[185] - 9486));
				continue;
				end_IL_001c:
				break;
			}
		}
		RebuildFilter();
	}

	internal void Ⴅ()
	{
		int num = 0;
		IConvertible convertible = default(IConvertible);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				convertible = RebuildFilter();
				goto case 1;
			case 1:
				num2 = ((this.m_Ⴍ.Ⴀ == null) ? 2 : 4);
				break;
			case 4:
				this.m_Ⴍ.Ⴀ(this, (string)convertible);
				return;
			case 2:
			case 3:
			case 5:
				return;
			}
			num = num2;
		}
	}

	public string RebuildFilter()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool ⴗ2 = false;
		this.m_Ⴍ.Ⴗ = ⴗ2;
		IEnumerable enumerable = string.Empty;
		List<DgvBaseColumnFilter>.Enumerator enumerator = this.m_Ⴄ.GetEnumerator();
		try
		{
			int num = 7;
			object current = default(object);
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					continue;
				case 8:
					current = enumerator.Current;
					num = (((DgvBaseColumnFilter)current == null) ? (ⴃႭ[279] - 55803) : 9);
					continue;
				case 9:
					num = ((!((DgvBaseColumnFilter)current).Active) ? (ⴀ[18] - 58198) : 13);
					continue;
				case 5:
				case 11:
				case 13:
					num = ((!ColumnFilterEventArgs.Ⴀ(((DgvBaseColumnFilter)current).FilterExpression, string.Empty, 883, 828)) ? (ⴐ[275] - 24300) : 6);
					continue;
				case 6:
					num = ((UtilsCallsign.Ⴓ((string)enumerable, 447, 392) <= 0) ? 4 : (ⴐ[601] - 15640));
					continue;
				case 1:
				case 14:
					enumerable = ReverseBeaconClient.Ⴗ(enumerable as string, ArcLogInRqstExt.Ⴗ(1706507466, 10, 2), '\u0382', 'ϊ');
					num = 4;
					continue;
				case 4:
					enumerable = HelpAboutServer.Ⴗ((string)enumerable, ႣႼ.ႥႭ(null, 624735742, 6, null), (current as DgvBaseColumnFilter).FilterExpression, ႣႼ.Ⴜ(0, 365387623, 26), 1011, 'Ν');
					num = 10;
					continue;
				case 10:
					UtilsXml.ႨႨ(((DgvBaseColumnFilter)current).DataGridViewColumn, (current as DgvBaseColumnFilter).FilterCaption, 774, 883);
					num = ⴐ[166] - 64388;
					continue;
				case 12:
					UtilsXml.ႨႨ(((DgvBaseColumnFilter)current).DataGridViewColumn, (current as DgvBaseColumnFilter).OriginalDataGridViewColumnHeaderText, 167, 210);
					break;
				case 2:
					break;
				case 0:
					goto end_IL_0078;
				}
				num = (enumerator.MoveNext() ? 8 : 0);
				continue;
				end_IL_0078:
				break;
			}
		}
		finally
		{
			switch (0)
			{
			default:
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				break;
			case 2:
			case 3:
				break;
			}
		}
		int num2 = 7;
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				num2 = ((!ColumnFilterEventArgs.Ⴀ(enumerable as string, string.Empty, 192, 143)) ? 5 : (ⴃႤ[135] - 4056));
				continue;
			case 3:
			{
				bool ⴗ3 = true;
				this.m_Ⴍ.Ⴗ = ⴗ3;
				num2 = (FrmUpdating.ႠႥ(this.m_Ⴍ.Ⴐ, string.Empty, 964, 1016) ? 8 : (ⴗ[148] - 25106));
				continue;
			}
			case 0:
				obj = UtilsEmail.Ⴀ(this.m_Ⴍ.Ⴐ, ArcLogInRqstExt.Ⴗ(1706507467, 6, 3), enumerable as string, 709, 659);
				goto IL_0366;
			case 8:
				obj = enumerable as string;
				goto IL_0366;
			case 5:
				enumerable = this.m_Ⴍ.Ⴐ;
				num2 = 2;
				continue;
			case 1:
			case 2:
			case 10:
				if (Ⴐ != null)
				{
					num2 = 6;
					continue;
				}
				break;
			case 6:
				{
					Ⴐ(this, (string)enumerable);
					break;
				}
				IL_0366:
				enumerable = (IEnumerable)obj;
				num2 = ⴗ[75] - 9531;
				continue;
			}
			break;
		}
		try
		{
			int num3 = 7;
			while (true)
			{
				switch (num3)
				{
				default:
					num3 = ((this.m_Ⴍ.Ⴅ == null) ? 6 : 3);
					continue;
				case 3:
					num3 = ((!ColumnFilterEventArgs.Ⴀ(ColumnFilterEventArgs.ႨႠ(this.m_Ⴍ.Ⴅ, 182, 138), enumerable as string, 872, 807)) ? 2 : (ⴃႭ[135] - 16158));
					continue;
				case 1:
					this.m_Ⴍ.Ⴅ.Filter = enumerable as string;
					num3 = ⴀ[4] - 23043;
					continue;
				case 6:
				case 8:
					num3 = ((!(this.m_Ⴅ.RowFilter != enumerable as string)) ? 2 : 5);
					continue;
				case 5:
					this.m_Ⴅ.RowFilter = (string)enumerable;
					break;
				case 2:
					break;
				}
				break;
			}
		}
		catch
		{
			Console.WriteLine(DownloadUrl2.Ⴅ(7, null, 2018869035, 3) + (string)enumerable);
		}
		return 4 switch
		{
			_ => (string)enumerable, 
		};
	}

	private void Ⴗ()
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 1;
		object obj = default(object);
		ICloneable cloneable = default(ICloneable);
		ICloneable cloneable2 = default(ICloneable);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
			{
				IBindingList bindingList2 = null;
				this.m_Ⴍ.Ⴅ = bindingList2 as BindingSource;
				goto case 4;
			}
			case 4:
				obj = UtilsIdentity.ႤႤ(this.m_Ⴄ, 133, 174);
				num = 5;
				break;
			case 5:
			case 6:
				cloneable = ႰႨ.ႨႳ(this.m_Ⴄ, '«', '\u008f');
				cloneable2 = DownloadUrl2.Ⴅ(10, null, 2018869211, 6);
				goto IL_0211;
			case 3:
				if (obj == null)
				{
					num = 2;
					break;
				}
				goto IL_00f4;
			case 2:
				return;
				IL_0211:
				if (!(obj is DataView))
				{
					goto case 3;
				}
				num2 = 8;
				goto IL_00aa;
				IL_00aa:
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						return;
					case 4:
						break;
					case 11:
					case 12:
					{
						IBindingList bindingList = (BindingSource)obj;
						this.m_Ⴍ.Ⴅ = (BindingSource)bindingList;
						cloneable = HelpAboutServer.ႷႣ((BindingSource)obj, 430, 462);
						num2 = 9;
						continue;
					}
					case 9:
						obj = DirectoryMonitor.ႠႣ((BindingSource)obj, 474, 505);
						num2 = 6;
						continue;
					case 7:
						num2 = ((obj is DataSet) ? 1 : (ⴃႤ[322] - 16161));
						continue;
					case 1:
						obj = ArxServerClient.Ⴃ(DgvComboBoxColumnFilter.Ⴗ((DataSet)obj, 'ľ', 'Ę'), (string)cloneable, 'Ǥ', 'Ǡ');
						goto case 10;
					case 10:
						num2 = ⴐ[352] - 48422;
						continue;
					case 5:
						cloneable = string.Empty;
						num2 = 6;
						continue;
					case 0:
						num2 = ((!(obj is DataTable)) ? 3 : (ⴃႭ[108] - 41232));
						continue;
					case 14:
						obj = ((DataTable)obj).DefaultView;
						num2 = 8;
						continue;
					case 3:
						throw new Exception(cloneable2 as string);
					case 6:
						goto IL_0211;
					case 2:
					case 8:
						this.m_Ⴅ = (DataView)obj;
						return;
					}
					break;
				}
				goto IL_00f4;
				IL_00f4:
				num2 = ((!(obj is BindingSource)) ? (ⴃႣ[58] - 44947) : 12);
				goto IL_00aa;
			}
		}
	}

	private void Ⴃ(DataGridViewColumn P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 3;
		MemberInfo memberInfo = default(MemberInfo);
		object obj2 = default(object);
		while (true)
		{
			switch (num)
			{
			case 0:
			case 1:
				return;
			}
			if (!this.m_Ⴍ.Ⴓ)
			{
				num = 0;
				continue;
			}
			while (true)
			{
				object obj = new ColumnFilterEventArgs(P_0, null);
				while (true)
				{
					IL_00d9:
					int num2 = ((this.m_Ⴍ.Ⴍ != null) ? 8 : 0);
					while (true)
					{
						switch (num2)
						{
						default:
							/*OpCode not supported: LdMemberToken*/;
							return;
						case 24:
							break;
						case 22:
							goto IL_00d9;
						case 8:
							this.m_Ⴍ.Ⴍ(this, (ColumnFilterEventArgs)obj);
							goto case 0;
						case 0:
							num2 = ((((ColumnFilterEventArgs)obj).ColumnFilter != null) ? (ⴀ[48] - 14589) : 20);
							continue;
						case 19:
						case 20:
							memberInfo = null;
							num2 = ((!ColumnFilterEventArgs.Ⴀ(UtilsSql.Ⴍ(P_0, 701, 654), string.Empty, 162, 237)) ? 18 : 14);
							continue;
						case 14:
							memberInfo = ReverseBeaconClient.Ⴀ(LegalCfg.Ⴅ(LogFile.Ⴅ(ColumnFilterEventArgs.Ⴈ(this.m_Ⴅ, 775, 837), 684, 'ʠ'), UtilsSql.Ⴍ(P_0, 960, 1011), 'ú', 170), 453, 486);
							num2 = 25;
							continue;
						case 25:
							num2 = (((obj2 = AnnWxSpotExt.Ⴐ((MemberInfo)ArcUserCfg.ႠႭ((object)P_0, 165, 223), '\u035d', 825)) == null) ? 18 : (ⴃႭ[145] - 60708));
							continue;
						case 1:
							num2 = (FrmUpdating.ႠႥ(obj2 as string, DownloadUrl2.Ⴅ(5, null, 2018868248, 4), 648, 692) ? 10 : 2);
							continue;
						case 2:
							num2 = (FrmUpdating.ႠႥ((string)obj2, ႣႼ.ႥႭ(null, 624735345, 5, null), 918, 938) ? 16 : 23);
							continue;
						case 23:
							num2 = (FrmUpdating.ႠႥ((string)obj2, ႣႼ.Ⴜ(4, 365385959, 20), 880, 844) ? (ⴐ[300] - 16233) : 9);
							continue;
						case 9:
							num2 = (FrmUpdating.ႠႥ(obj2 as string, UtilsString.Ⴐ(null, 5, 192633746), 813, 785) ? (ⴃႣ[14] - 27588) : 17);
							continue;
						case 17:
							num2 = 18;
							continue;
						case 10:
							((ColumnFilterEventArgs)obj).ColumnFilter = new DgvTextBoxColumnFilter();
							num2 = 18;
							continue;
						case 16:
							(obj as ColumnFilterEventArgs).ColumnFilter = new DgvComboBoxColumnFilter();
							num2 = 18;
							continue;
						case 7:
							((ColumnFilterEventArgs)obj).ColumnFilter = new DgvCheckBoxColumnFilter();
							num2 = 18;
							continue;
						case 4:
							num2 = ((!ObjectCopierExt.Ⴈ((Type)memberInfo, typeof(DateTime), 'Έ', 'ά')) ? (ⴐ[214] - 10760) : (ⴐ[202] - 9413));
							continue;
						case 11:
							((ColumnFilterEventArgs)obj).ColumnFilter = new DgvDateColumnFilter();
							num2 = ⴀ[361] - 23633;
							continue;
						case 12:
							((ColumnFilterEventArgs)obj).ColumnFilter = new DgvTextBoxColumnFilter();
							goto case 18;
						case 18:
							this.m_Ⴄ[P_0.Index] = ((ColumnFilterEventArgs)obj).ColumnFilter;
							goto case 5;
						case 5:
							num2 = (((obj as ColumnFilterEventArgs).ColumnFilter == null) ? (ⴃႤ[210] - 27390) : 21);
							continue;
						case 21:
							num2 = ((this.m_Ⴍ.Ⴃ == null) ? 15 : 3);
							continue;
						case 3:
							this.m_Ⴍ.Ⴃ(this, (ColumnFilterEventArgs)obj);
							goto case 15;
						case 15:
							(obj as ColumnFilterEventArgs).ColumnFilter.Init(this, FilterHost, P_0, this.m_Ⴅ);
							return;
						case 6:
							return;
						}
						break;
					}
					break;
				}
			}
		}
	}

	[SecuritySafeCritical]
	static DgvFilterManager()
	{
		UtilsIdentity.Ⴐ();
	}

	[SecuritySafeCritical]
	internal static void Ⴍ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, short P_3) where _0021_00210 : EventHandler where _0021_00211 : ListControl
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 9;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 4;
				break;
			case 4:
				num = (((P_3 ^ P_2) - 123) ^ num2) switch
				{
					0 => ⴐ[50] - 37609, 
					_ => ⴃႤ[317] - 38166, 
				};
				break;
			case 3:
			case 8:
				num = ⴀ[259] - 39330;
				break;
			case 0:
			case 5:
				P_0.SelectedValueChanged += P_1;
				goto case 6;
			case 6:
				num2++;
				num = (((P_2 * P_2 + P_2) % 2 == 0) ? 1 : (ⴃႤ[145] - 47524));
				break;
			case 7:
				num = ⴀ[230] - 37251;
				break;
			case 1:
			case 2:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool Ⴜ<_0021_00210, _0021_00211>(_0021_00211 P_0, _0021_00210 P_1, char P_2, char P_3) where _0021_00211 : ArrayList
	{
		char[] ⴃႣ = TalkCfg.ႣႣ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		bool result = default(bool);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 11;
					continue;
				case 11:
					break;
				case 0:
				case 5:
					num2 = (((P_3 ^ P_2) - 89) ^ num) switch
					{
						0 => ⴃႣ[62] - 18495, 
						_ => 3, 
					};
					continue;
				case 3:
					result = false;
					goto case 8;
				case 8:
					num2 = 9;
					continue;
				case 1:
				case 6:
					result = P_0.Contains(P_1);
					num2 = 9;
					continue;
				case 9:
				{
					num++;
					int num3 = 26;
					int num4 = 613;
					num2 = ((4291 > num4 - num3 * 7) ? (ⴀ[29] - 14208) : 7);
					continue;
				}
				case 7:
					num2 = 5;
					continue;
				case 4:
					return result;
				case 2:
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႣ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, bool P_2, short P_3, short P_4) where _0021_00210 : string where _0021_00211 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 2;
		int num2 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 5;
				continue;
			case 5:
				num = (((P_4 ^ P_3) - 14) ^ num2) switch
				{
					0 => 7, 
					_ => ⴃႭ[276] - 32031, 
				};
				continue;
			case 1:
			case 8:
				num = ⴀ[12] - 15405;
				continue;
			case 7:
				File.Copy(P_0, P_1, P_2);
				goto case 4;
			case 4:
				num2++;
				num3 = 2250;
				num4 = 633;
				break;
			case 3:
				break;
			case 0:
				return;
			}
			int num6;
			if (750 >= num3 / 3 - num4)
			{
				char num5 = ⴀ[221];
				DxCfg.Ⴗ[98] = (char)((DxCfg.Ⴗ[98] * P_3) & 0x1F);
				num6 = num5 - 59529;
			}
			else
			{
				num6 = ⴃႤ[328] - ⴃႤ[582];
			}
			num = num6;
		}
	}

	[SecuritySafeCritical]
	internal static string ႭႭ<_0021_00210, _0021_00211, _0021_00212>(_0021_00212 P_0, _0021_00211 P_1, _0021_00210 P_2, int P_3, int P_4) where _0021_00210 : string where _0021_00211 : string where _0021_00212 : string
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		IEnumerable enumerable = default(IEnumerable);
		while (true)
		{
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = ⴃႭ[188] - 1893;
					continue;
				case 7:
					break;
				case 10:
					num2 = (((P_3 ^ P_4) - 98) ^ num) switch
					{
						0 => ⴗ[89] - 20998, 
						_ => 5, 
					};
					continue;
				case 0:
				case 5:
					enumerable = null;
					num2 = ⴐ[112] - 136;
					continue;
				case 6:
				case 9:
					enumerable = P_0.Replace(P_1, P_2);
					num2 = 4;
					continue;
				case 2:
				case 4:
				{
					num++;
					int num3 = 400;
					int num4 = 417;
					num2 = ((4170 <= num4 - num3 * 10) ? 1 : (ⴃႤ[375] - 43333));
					continue;
				}
				case 1:
					num2 = ⴀ[411] - 55799;
					continue;
				case 8:
					return enumerable as string;
				case 3:
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void ႭႤ<_0021_00210, _0021_00211>(_0021_00210 P_0, _0021_00211 P_1, char P_2, int P_3) where _0021_00210 : WwvSpot where _0021_00211 : string
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num2 = 0;
				num = 0;
				break;
			case 0:
				num = (((P_3 ^ P_2) - 38) ^ num2) switch
				{
					0 => ⴗ[27] - 94, 
					_ => ⴃႤ[415] - 54641, 
				};
				break;
			case 2:
			case 5:
				num = 4;
				break;
			case 1:
				P_0.K = P_1;
				goto case 4;
			case 4:
			{
				num2++;
				int num3 = 683;
				int num4 = 700;
				num = ((2100 > num4 - num3 * 3) ? 9 : 7);
				break;
			}
			case 7:
				num = ⴀ[177] - 56529;
				break;
			case 6:
			case 9:
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DataGridViewColumnCollection ႭႰ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : DataGridView
	{
		char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		ICollection collection = default(ICollection);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 3;
					continue;
				case 3:
					break;
				case 1:
				case 7:
				{
					int num4 = P_2 ^ P_1;
					NeedsCfg.ႣႤ[28] = (NeedsCfg.ႣႤ[28] | P_2) & 0x70;
					num2 = ((num4 - 38) ^ num) switch
					{
						0 => 4, 
						_ => 10, 
					};
					continue;
				}
				case 10:
					collection = null;
					num2 = ⴐ[565] - 40930;
					continue;
				case 4:
					collection = P_0.Columns;
					num2 = 6;
					continue;
				case 2:
				case 6:
					num++;
					num3 = P_1 * P_1;
					goto case 11;
				case 11:
					num3 = P_1 + num3;
					num2 = 8;
					continue;
				case 8:
					num2 = ((num3 % 2 != 0) ? (ⴃႭ[122] - 60700) : 5);
					continue;
				case 5:
					return (DataGridViewColumnCollection)collection;
				case 9:
					num2 = 1;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static DirectoryInfo ႭႷ<_0021_00210>(_0021_00210 P_0, char P_1, int P_2) where _0021_00210 : string
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴃႣ = TalkCfg.ႣႣ;
		FileSystemInfo fileSystemInfo = default(FileSystemInfo);
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = ⴀ[321] - 6691;
			while (true)
			{
				switch (num2)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num2 = 2;
					continue;
				case 0:
				case 2:
					break;
				case 11:
					num2 = (((P_2 ^ P_1) - 38) ^ num) switch
					{
						0 => 9, 
						_ => 6, 
					};
					continue;
				case 6:
					fileSystemInfo = null;
					num2 = ⴃႭ[253] - 35212;
					continue;
				case 9:
					fileSystemInfo = Directory.CreateDirectory(P_0);
					num2 = ⴀ[277] - 60582;
					continue;
				case 3:
					num++;
					num3 = P_1 * P_1;
					goto case 8;
				case 8:
					num3 = P_1 + num3;
					num2 = 1;
					continue;
				case 1:
				case 5:
					num2 = ((num3 % 2 != 0) ? 11 : (ⴃႤ[180] - 29625));
					continue;
				case 4:
					return (DirectoryInfo)fileSystemInfo;
				case 10:
					num2 = ⴃႣ[152] - 2903;
					continue;
				}
				break;
			}
		}
	}
}

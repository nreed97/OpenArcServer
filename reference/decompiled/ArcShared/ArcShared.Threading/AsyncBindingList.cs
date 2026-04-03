using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using ArcShared.ArcCfg;
using ArcShared.ArcIo.Arx;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace ArcShared.Threading;

public sealed class AsyncBindingList<T> : BindingList<T>
{
	private enum ႰႳ
	{

	}

	private sealed class ႰႠ
	{
		private ႰႳ m_Ⴅ;

		private object m_Ⴄ;

		private object m_Ⴅ;

		private int Ⴓ;

		public ႰႠ(ႰႳ P_0, object P_1, int P_2)
		{
			this.Ⴅ = P_0;
			this.Ⴄ = P_1;
			Ⴓ = P_2;
		}

		[SpecialName]
		public ႰႳ Ⴃ()
		{
			char[] ⴃႣ = TalkCfg.ႣႣ;
			ႰႳ ⴅ = this.Ⴅ;
			TalkCfg.ႣႣ[51] = (char)((TalkCfg.ႣႣ[51] ^ TalkCfg.ႣႣ[60]) & 0xBE);
			return ⴅ;
		}

		[SpecialName]
		public object Ⴍ()
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			object ⴄ = this.Ⴄ;
			DxCfg.Ⴗ[77] = (char)((DxCfg.Ⴗ[77] ^ DxCfg.Ⴗ[124]) & 0x6F);
			return ⴄ;
		}

		[SpecialName]
		public int Ⴄ()
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			return Ⴓ;
		}

		[SpecialName]
		public object Ⴐ()
		{
			return this.Ⴅ;
		}

		[SpecialName]
		public void Ⴅ(object P_0)
		{
			this.Ⴅ = P_0;
		}

		[SecuritySafeCritical]
		static ႰႠ()
		{
			UtilsIdentity.Ⴐ();
		}
	}

	private bool Ⴀ;

	private SynchronizationContext Ⴈ;

	private SendOrPostCallback Ⴗ;

	public new int Count
	{
		get
		{
			int[] ⴃႤ = NeedsCfg.ႣႤ;
			char[] ⴀ = UtilsNumeric.Ⴀ;
			char[] ⴃႭ = WxCfg.ႣႭ;
			object obj = default(object);
			while (true)
			{
				int num = ((!Ⴀ) ? 6 : (ⴀ[386] - 37900));
				while (true)
				{
					switch (num)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num = ⴃႤ[131] - 11841;
						continue;
					case 4:
					case 5:
						break;
					case 2:
						return base.Count;
					case 1:
					case 6:
						obj = new ႰႠ((ႰႳ)8, null, -1);
						DownloadUrl.Ⴗ(Ⴈ, Ⴗ, (object)(obj as ႰႠ), 'ɖ', 'ɿ');
						goto case 3;
					case 3:
						num = ⴃႭ[197] - 28511;
						continue;
					case 0:
						return (int)((ႰႠ)obj).Ⴐ();
					}
					break;
				}
			}
		}
	}

	public AsyncBindingList()
	{
		Ⴄ();
	}

	public AsyncBindingList(IList<T> list)
		: base(list)
	{
		Ⴄ();
	}

	private void Ⴄ()
	{
		Ⴈ = new WindowsFormsSynchronizationContext();
		Ⴗ = Ⴅ;
	}

	public new void Add(T item)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				if (!Ⴀ)
				{
					ArxServerClient.Ⴍ(Ⴈ, Ⴗ, (object)new ႰႠ((ႰႳ)5, item, -1), 27, '\\');
					return;
				}
				break;
			case 2:
				base.Add(item);
				return;
			}
			num = 2;
		}
	}

	protected override object AddNewCore()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		object obj = default(object);
		while (true)
		{
			int num = ((!Ⴀ) ? (ⴃႭ[103] - 40150) : 4);
			while (true)
			{
				switch (num)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					num = 3;
					continue;
				case 3:
					break;
				case 4:
					return base.AddNewCore();
				case 5:
					obj = new ႰႠ((ႰႳ)4, null, -1);
					DownloadUrl.Ⴗ(Ⴈ, Ⴗ, (object)(obj as ႰႠ), '\u0091', '\u00b8');
					goto case 7;
				case 7:
					num = ⴃႤ[232] - 11092;
					continue;
				case 6:
					return (obj as ႰႠ).Ⴐ();
				}
				break;
			}
		}
	}

	protected override void ClearItems()
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				if (!Ⴀ)
				{
					ArxServerClient.Ⴍ(Ⴈ, Ⴗ, (object)new ႰႠ((ႰႳ)0, null, -1), 220, '\u009b');
					return;
				}
				break;
			case 0:
			case 3:
				base.ClearItems();
				DataGridViewColumnSelector.Ⴐ[499] = (char)((DataGridViewColumnSelector.Ⴐ[499] - DataGridViewColumnSelector.Ⴐ[173]) & 0x4B);
				return;
			case 2:
				return;
			}
			num = 0;
		}
	}

	protected override void InsertItem(int index, T item)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				if (!Ⴀ)
				{
					object obj = new ႰႠ((ႰႳ)1, item, index);
					ArxServerClient.Ⴍ(Ⴈ, Ⴗ, (object)(ႰႠ)obj, 23, 'P');
					NeedsCfg.ႣႤ[281] = (NeedsCfg.ႣႤ[281] ^ DxCfg.Ⴗ[106]) & 0xBA;
					return;
				}
				break;
			case 1:
			case 3:
			case 4:
				base.InsertItem(index, item);
				return;
			case 2:
				return;
			}
			num = 4;
		}
	}

	protected override void RemoveItem(int index)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				if (!Ⴀ)
				{
					ArxServerClient.Ⴍ(Ⴈ, Ⴗ, (object)new ႰႠ((ႰႳ)2, null, index), 556, 'ɫ');
					return;
				}
				break;
			case 0:
			case 1:
			case 2:
			case 4:
				base.RemoveItem(index);
				return;
			}
			num = 1;
		}
	}

	protected override void SetItem(int index, T item)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (!Ⴀ)
				{
					ArxServerClient.Ⴍ(Ⴈ, Ⴗ, (object)new ႰႠ((ႰႳ)3, item, index), 405, 'ǒ');
					return;
				}
				break;
			case 0:
				base.SetItem(index, item);
				return;
			case 4:
				return;
			}
			num = 0;
		}
	}

	public override void CancelNew(int itemIndex)
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				if (!Ⴀ)
				{
					ArxServerClient.Ⴍ(Ⴈ, Ⴗ, (object)new ႰႠ((ႰႳ)7, null, itemIndex), 384, 'Ǉ');
					return;
				}
				break;
			case 2:
				base.CancelNew(itemIndex);
				return;
			case 0:
			case 1:
				return;
			}
			num = ⴃႤ[355] - 17423;
		}
	}

	public override void EndNew(int itemIndex)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (!Ⴀ)
				{
					ArxServerClient.Ⴍ(Ⴈ, Ⴗ, (object)new ႰႠ((ႰႳ)6, null, itemIndex), 361, 'Į');
					return;
				}
				break;
			case 3:
			case 4:
				base.EndNew(itemIndex);
				return;
			case 0:
				return;
			}
			num = 4;
		}
	}

	protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
	{
	}

	protected override void RemoveSortCore()
	{
	}

	protected override int FindCore(PropertyDescriptor prop, object key)
	{
		return -1;
	}

	private void Ⴅ(object P_0)
	{
		char[] ⴀ = UtilsNumeric.Ⴀ;
		int num = 3;
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			default:
				obj = P_0 as ႰႠ;
				break;
			case 0:
			case 1:
			case 2:
				break;
			case 4:
				return;
			}
			if (obj is ႰႠ)
			{
				break;
			}
			num = ⴀ[216] - 9817;
		}
		Ⴓ((ႰႠ)obj);
	}

	private void Ⴓ(ႰႠ P_0)
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		int num = 4;
		ႰႳ ⴐႳ = default(ႰႳ);
		while (true)
		{
			switch (num)
			{
			default:
				ⴐႳ = P_0.Ⴃ();
				break;
			case 1:
				break;
			case 2:
			case 3:
				return;
			}
			switch (ⴐႳ)
			{
			case (ႰႳ)0:
				base.ClearItems();
				return;
			case (ႰႳ)1:
				base.InsertItem(P_0.Ⴄ(), (T)P_0.Ⴍ());
				return;
			case (ႰႳ)2:
				base.RemoveItem(P_0.Ⴄ());
				return;
			case (ႰႳ)3:
				base.SetItem(P_0.Ⴄ(), (T)P_0.Ⴍ());
				return;
			case (ႰႳ)4:
				Ⴀ = true;
				try
				{
					object obj = base.AddNewCore();
					P_0.Ⴅ(obj);
					return;
				}
				finally
				{
					Ⴀ = false;
				}
			case (ႰႳ)5:
				Ⴀ = true;
				try
				{
					base.Add((T)P_0.Ⴍ());
					return;
				}
				finally
				{
					Ⴀ = false;
				}
			case (ႰႳ)6:
				switch (1)
				{
				default:
					base.EndNew(P_0.Ⴄ());
					return;
				case 3:
				case 4:
					return;
				case 2:
					break;
				}
				goto case (ႰႳ)7;
			case (ႰႳ)7:
				Ⴀ = true;
				try
				{
					base.CancelNew(P_0.Ⴄ());
					return;
				}
				finally
				{
					Ⴀ = false;
				}
			case (ႰႳ)8:
				switch (1)
				{
				case 3:
				case 4:
					return;
				}
				P_0.Ⴅ(base.Count);
				return;
			}
			num = ⴃႭ[81] - 32195;
		}
	}

	[SecuritySafeCritical]
	static AsyncBindingList()
	{
		UtilsIdentity.Ⴐ();
	}
}

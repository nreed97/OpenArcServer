using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using ArcShared.ArcCfg;
using ArcShared.ArcUtils;
using ArcShared.DgvUtils;

namespace ArcShared;

public sealed class ByteAppend<T> : IEnumerable<T>, IEnumerable
{
	private sealed class ႰႤ : IEnumerator<T>, IEnumerator, IDisposable
	{
		private T m_Ⴄ;

		private int m_Ⴗ;

		public ByteAppend<T> Ⴐ;

		public T[] Ⴄ;

		public T Ⴀ;

		public LinkedList<T[]>.Enumerator Ⴐ;

		public T[] Ⴓ;

		public int Ⴅ;

		private bool Ⴀ()
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			char[] ⴗ = DxCfg.Ⴗ;
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			char[] ⴃႣ = TalkCfg.ႣႣ;
			bool flag;
			try
			{
				int num = 6;
				int ⴗ2 = default(int);
				while (true)
				{
					switch (num)
					{
					default:
						ⴗ2 = this.Ⴗ;
						num = ((ⴗ2 == 0) ? 5 : 4);
						continue;
					case 4:
						num = ((ⴗ2 == 3) ? (ⴗ[134] - 54684) : (ⴃႭ[120] - 38918));
						continue;
					case 12:
						num = ⴐ[170] - 29934;
						continue;
					case 5:
						this.Ⴗ = -1;
						this.Ⴐ = this.Ⴐ.Ⴗ.GetEnumerator();
						this.Ⴗ = 1;
						num = 8;
						continue;
					case 1:
						this.Ⴄ = this.Ⴐ.Current;
						this.Ⴗ = 2;
						goto case 16;
					case 16:
						Ⴓ = this.Ⴄ;
						num = ⴃႣ[199] - 41505;
						continue;
					case 13:
					case 14:
						Ⴅ = 0;
						num = 2;
						continue;
					case 9:
						this.Ⴀ = Ⴓ[Ⴅ];
						this.Ⴄ = this.Ⴀ;
						num = 7;
						continue;
					case 7:
					case 15:
						this.Ⴗ = 3;
						flag = true;
						goto end_IL_001e;
					case 10:
						this.Ⴗ = 2;
						Ⴅ++;
						num = 2;
						continue;
					case 2:
						num = ((Ⴅ < Ⴓ.Length) ? (ⴃႭ[257] - 21108) : 3);
						continue;
					case 3:
						Ⴄ();
						goto case 8;
					case 8:
						num = (this.Ⴐ.MoveNext() ? 1 : 11);
						continue;
					case 11:
						Ⴃ();
						break;
					case 17:
						break;
					}
					flag = false;
					break;
					continue;
					end_IL_001e:
					break;
				}
			}
			catch
			{
				//try-fault
				switch (2)
				{
				default:
					Ⴗ();
					break;
				}
				throw;
			}
			return 4 switch
			{
				_ => flag, 
			};
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ⴀ
			return this.Ⴀ();
		}

		[SpecialName]
		private T Ⴈ()
		{
			char[] ⴐ = DataGridViewColumnSelector.Ⴐ;
			return this.Ⴄ;
		}

		T IEnumerator<T>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ⴈ
			return this.Ⴈ();
		}

		private void Ⴍ()
		{
			char[] ⴃႭ = WxCfg.ႣႭ;
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ⴍ
			this.Ⴍ();
		}

		private void Ⴗ()
		{
			int num = 2;
			int ⴗ = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					return;
				}
				switch (this.Ⴗ)
				{
				case 1:
				case 2:
				case 3:
					try
					{
						int num2 = 4;
						while (true)
						{
							switch (num2)
							{
							default:
								ⴗ = this.Ⴗ;
								goto case 3;
							case 3:
							case 6:
								num2 = ⴗ switch
								{
									2 => 5, 
									3 => 5, 
									_ => 2, 
								};
								break;
							case 1:
							case 2:
								num2 = 0;
								break;
							case 5:
								Ⴄ();
								return;
							case 0:
								return;
							}
						}
					}
					finally
					{
						Ⴃ();
					}
				}
				num = 4;
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ⴗ
			this.Ⴗ();
		}

		[SpecialName]
		private object Ⴐ()
		{
			object result = this.Ⴄ;
			DataGridViewColumnSelector.Ⴐ[387] = (char)((DataGridViewColumnSelector.Ⴐ[387] - WxCfg.ႣႭ[175]) & 0xDD);
			return result;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ⴐ
			return this.Ⴐ();
		}

		public ႰႤ(int P_0)
		{
			this.Ⴗ = P_0;
		}

		private void Ⴃ()
		{
			this.Ⴗ = -1;
			((IDisposable)this.Ⴐ/*cast due to .constrained prefix*/).Dispose();
		}

		private void Ⴄ()
		{
			this.Ⴗ = 1;
		}

		[SecuritySafeCritical]
		static ႰႤ()
		{
			UtilsIdentity.Ⴐ();
		}
	}

	private readonly LinkedList<T[]> Ⴗ = new LinkedList<T[]>();

	private int Ⴃ;

	public int Count
	{
		get
		{
			return Ⴃ;
		}
		private set
		{
			Ⴃ = ⴃ;
		}
	}

	public T this[int nIndex]
	{
		get
		{
			char[] ⴀ = UtilsNumeric.Ⴀ;
			int num;
			Array array = Ⴄ(nIndex, out num);
			return (array as T[])[nIndex - num];
		}
		set
		{
			int num;
			Array array = Ⴄ(nIndex, out num);
			(array as T[])[nIndex - num] = value;
		}
	}

	public T[] ToArray()
	{
		int[] ⴃႤ = NeedsCfg.ႣႤ;
		char[] ⴗ = DxCfg.Ⴗ;
		while (true)
		{
			object obj = new T[Count];
			while (true)
			{
				IL_004c:
				int num = 0;
				int num2 = 0;
				while (true)
				{
					switch (num2)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num2 = 7;
						continue;
					case 7:
						break;
					case 2:
						goto IL_004c;
					case 3:
						(obj as T[])[num] = this[num];
						num++;
						num2 = 0;
						continue;
					case 0:
					case 4:
						num2 = ((num < Count) ? (ⴗ[102] - 41112) : (ⴃႤ[584] - 2569));
						continue;
					case 5:
						return (T[])obj;
					}
					break;
				}
				break;
			}
		}
	}

	public void Add(T[] aItems)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 0:
			case 3:
				return;
			}
			if (aItems == null)
			{
				num = 3;
				continue;
			}
			while (true)
			{
				switch ((aItems.Length != 0) ? 3 : 6)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					return;
				case 1:
					return;
				case 5:
					break;
				case 6:
					return;
				case 0:
				case 3:
				case 4:
					Ⴗ.AddLast(aItems);
					Count += aItems.Length;
					return;
				}
			}
		}
	}

	private T[] Ⴄ(int P_0, out int P_1)
	{
		char[] ⴗ = DxCfg.Ⴗ;
		P_1 = 0;
		int num = 0;
		LinkedList<T[]>.Enumerator enumerator = Ⴗ.GetEnumerator();
		object obj = default(object);
		try
		{
			int num2 = 9;
			object current = default(object);
			while (true)
			{
				switch (num2)
				{
				default:
					num2 = ⴗ[47] - ⴗ[47];
					continue;
				case 7:
				case 8:
					current = enumerator.Current;
					num += (current as T[]).Length;
					num2 = 3;
					continue;
				case 3:
					num2 = ((num <= P_0) ? 1 : 10);
					continue;
				case 10:
					obj = current as T[];
					goto IL_012c;
				case 1:
				case 5:
					P_1 = num;
					num2 = 0;
					continue;
				case 0:
					num2 = (enumerator.MoveNext() ? 8 : 4);
					continue;
				case 2:
				case 4:
					break;
				}
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
			case 1:
				break;
			}
		}
		switch (4)
		{
		default:
			return null;
		case 1:
		case 2:
		case 5:
			break;
		}
		goto IL_012c;
		IL_012c:
		return obj as T[];
	}

	public IEnumerator<T> GetEnumerator()
	{
		char[] ⴃႭ = WxCfg.ႣႭ;
		object obj = new ႰႤ(0);
		(obj as ႰႤ).Ⴐ = this;
		return obj as ႰႤ;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[SecuritySafeCritical]
	static ByteAppend()
	{
		UtilsIdentity.Ⴐ();
	}
}

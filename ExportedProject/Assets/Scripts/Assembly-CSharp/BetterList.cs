using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x5913E8", Offset = "0x5913E8")]
public class BetterList<T>
{
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x591420", Offset = "0x591420")]
	private sealed class _003CGetEnumerator_003Ed__7 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x0")]
		private T _003C_003E2__current;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x0")]
		public BetterList<T> _003C_003E4__this;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x0")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000050")]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[Token(Token = "0x60001FA")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001FC")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F7")]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001F8")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001F9")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x0")]
	private T[] _buffer;

	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x0")]
	public int size;

	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x0")]
	public int MaxAutoExpansionSize;

	[Token(Token = "0x1700004D")]
	public T[] buffer
	{
		[Token(Token = "0x60001DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001DD")]
		private set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public T Item
	{
		[Token(Token = "0x60001DF")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x60001E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public int Capacity
	{
		[Token(Token = "0x60001E4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001E5")]
		private set
		{
		}
	}

	[Token(Token = "0x60001DB")]
	public BetterList(int capacity = 0, int maxAutoExpansionSize = 512)
	{
	}

	[Token(Token = "0x60001DE")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x611930", Offset = "0x611930")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	private void AllocateMore()
	{
	}

	[Token(Token = "0x60001E2")]
	public void ReserveAtLeast(int capacity)
	{
	}

	[Token(Token = "0x60001E3")]
	public void Resize(int newSize)
	{
	}

	[Token(Token = "0x60001E6")]
	public void Trim()
	{
	}

	[Token(Token = "0x60001E7")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001E8")]
	public void Release()
	{
	}

	[Token(Token = "0x60001E9")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x60001EA")]
	public void AddRange(T[] range)
	{
	}

	[Token(Token = "0x60001EB")]
	public void AddRange(T[] range, int start, int end)
	{
	}

	[Token(Token = "0x60001EC")]
	public void AddRange(BetterList<T> range)
	{
	}

	[Token(Token = "0x60001ED")]
	public void AddMultiple(T item, int n)
	{
	}

	[Token(Token = "0x60001EE")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x60001EF")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F0")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F1")]
	public T RemoveAt(int index)
	{
		return (T)null;
	}

	[Token(Token = "0x60001F2")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x60001F3")]
	public T[] TrimGetBuffer()
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	public T[] ToTrimmedArray()
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	public void Sort(Comparison<T> comparer)
	{
	}

	[Token(Token = "0x60001F6")]
	private static void MergeSort(ref T[] array, int start, int end, Comparison<T> comparer)
	{
	}
}

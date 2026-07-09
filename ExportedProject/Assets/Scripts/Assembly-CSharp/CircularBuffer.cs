using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000854")]
public class CircularBuffer<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
{
	[Token(Token = "0x2000855")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5968E0", Offset = "0x5968E0")]
	private sealed class _003CGetEnumerator_003Ed__37 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002EFD")]
		[FieldOffset(Offset = "0x0")]
		private T _003C_003E2__current;

		[Token(Token = "0x4002EFE")]
		[FieldOffset(Offset = "0x0")]
		public CircularBuffer<T> _003C_003E4__this;

		[Token(Token = "0x4002EFF")]
		[FieldOffset(Offset = "0x0")]
		private int _003CbufferIndex_003E5__2;

		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x0")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x170006F5")]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[Token(Token = "0x600367F")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x170006F6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003681")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600367C")]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600367D")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600367E")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003680")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002EF5")]
	[FieldOffset(Offset = "0x0")]
	private int capacity;

	[Token(Token = "0x4002EF6")]
	[FieldOffset(Offset = "0x0")]
	private int size;

	[Token(Token = "0x4002EF7")]
	[FieldOffset(Offset = "0x0")]
	private int head;

	[Token(Token = "0x4002EF8")]
	[FieldOffset(Offset = "0x0")]
	private int tail;

	[Token(Token = "0x4002EF9")]
	[FieldOffset(Offset = "0x0")]
	private T[] buffer;

	[NonSerialized]
	[Token(Token = "0x4002EFA")]
	[FieldOffset(Offset = "0x0")]
	private object syncRoot;

	[Token(Token = "0x4002EFB")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BB6C0", Offset = "0x5BB6C0")]
	private bool _003CAllowOverflow_003Ek__BackingField;

	[Token(Token = "0x170006EB")]
	public T Head
	{
		[Token(Token = "0x6003656")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6003657")]
		set
		{
		}
	}

	[Token(Token = "0x170006EC")]
	public T Tail
	{
		[Token(Token = "0x6003658")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6003659")]
		set
		{
		}
	}

	[Token(Token = "0x170006ED")]
	public int Count
	{
		[Token(Token = "0x600365A")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006EE")]
	public bool AllowOverflow
	{
		[Token(Token = "0x600365D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623480", Offset = "0x623480")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600365E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x623490", Offset = "0x623490")]
		set
		{
		}
	}

	[Token(Token = "0x170006EF")]
	public int Capacity
	{
		[Token(Token = "0x600365F")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003660")]
		set
		{
		}
	}

	[Token(Token = "0x170006F0")]
	private int System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ECount
	{
		[Token(Token = "0x6003672")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006F1")]
	private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly
	{
		[Token(Token = "0x6003673")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006F2")]
	private int System_002ECollections_002EICollection_002ECount
	{
		[Token(Token = "0x6003677")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006F3")]
	private bool System_002ECollections_002EICollection_002EIsSynchronized
	{
		[Token(Token = "0x6003678")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006F4")]
	private object System_002ECollections_002EICollection_002ESyncRoot
	{
		[Token(Token = "0x6003679")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600365B")]
	public CircularBuffer(int capacity)
	{
	}

	[Token(Token = "0x600365C")]
	public CircularBuffer(int capacity, bool allowOverflow)
	{
	}

	[Token(Token = "0x6003661")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6003662")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003663")]
	public int Push(T[] src)
	{
		return default(int);
	}

	[Token(Token = "0x6003664")]
	public int Push(T[] src, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6003665")]
	public void Push(T item)
	{
	}

	[Token(Token = "0x6003666")]
	public void Skip(int count)
	{
	}

	[Token(Token = "0x6003667")]
	public T[] Pop(int count)
	{
		return null;
	}

	[Token(Token = "0x6003668")]
	public int Pop(T[] dst)
	{
		return default(int);
	}

	[Token(Token = "0x6003669")]
	public int Pop(T[] dst, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x600366A")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x600366B")]
	public void CopyTo(T[] array)
	{
	}

	[Token(Token = "0x600366C")]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x600366D")]
	public void CopyTo(int index, T[] array, int arrayIndex, int count)
	{
	}

	[Token(Token = "0x600366E")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600366F")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6234A0", Offset = "0x6234A0")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6003670")]
	public T[] GetBuffer()
	{
		return null;
	}

	[Token(Token = "0x6003671")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6003674")]
	private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EAdd(T item)
	{
	}

	[Token(Token = "0x6003675")]
	private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ERemove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6003676")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600367A")]
	private void System_002ECollections_002EICollection_002ECopyTo(Array array, int arrayIndex)
	{
	}

	[Token(Token = "0x600367B")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}

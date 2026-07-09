using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20008DD")]
public class LazyReference<T> : ILazyReference, IEquatable<LazyReference<T>> where T : UnityEngine.Object
{
	[Token(Token = "0x20008DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596CC4", Offset = "0x596CC4")]
	private sealed class _003CASyncLoadResource_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003127")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003128")]
		[FieldOffset(Offset = "0x0")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003129")]
		[FieldOffset(Offset = "0x0")]
		public LazyReference<T> _003C_003E4__this;

		[Token(Token = "0x400312A")]
		[FieldOffset(Offset = "0x0")]
		private ResourceRequest _003Crequest_003E5__2;

		[Token(Token = "0x17000727")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600390A")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000728")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600390C")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003907")]
		[DebuggerHidden]
		public _003CASyncLoadResource_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003908")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003909")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600390B")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4003124")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected string _objectPath;

	[Token(Token = "0x4003125")]
	[FieldOffset(Offset = "0x0")]
	private UnityEngine.Object _value;

	[Token(Token = "0x4003126")]
	[FieldOffset(Offset = "0x0")]
	private bool _loaded;

	[Token(Token = "0x17000723")]
	public T Value
	{
		[Token(Token = "0x60038F6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000724")]
	public bool HasValue
	{
		[Token(Token = "0x60038F7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000725")]
	public virtual string Path
	{
		[Token(Token = "0x60038F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000726")]
	public virtual LazyReferenceUsageWrapper<T> Wrapper
	{
		[Token(Token = "0x60038F9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60038FA")]
	public virtual void Load()
	{
	}

	[Token(Token = "0x60038FB")]
	public bool Equals(LazyReference<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038FC")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60038FD")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60038FE")]
	public static bool operator ==(LazyReference<T> left, LazyReference<T> right)
	{
		return default(bool);
	}

	[Token(Token = "0x60038FF")]
	public static bool operator !=(LazyReference<T> left, LazyReference<T> right)
	{
		return default(bool);
	}

	[Token(Token = "0x6003900")]
	public static implicit operator T(LazyReference<T> sr)
	{
		return null;
	}

	[Token(Token = "0x6003901")]
	protected bool ValidateData()
	{
		return default(bool);
	}

	[Token(Token = "0x6003902")]
	protected virtual T LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x6003903")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x624400", Offset = "0x624400")]
	public IEnumerator ASyncLoadResource()
	{
		return null;
	}

	[Token(Token = "0x6003904")]
	public override void Release()
	{
	}

	[Token(Token = "0x6003905")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6003906")]
	public LazyReference()
	{
	}
}

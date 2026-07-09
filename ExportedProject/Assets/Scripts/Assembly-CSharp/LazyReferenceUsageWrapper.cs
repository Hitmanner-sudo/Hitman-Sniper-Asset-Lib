using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008E8")]
public class LazyReferenceUsageWrapper<T> : LazyReferenceUsageWrapperBase, IDisposable, IEquatable<T>, IEquatable<LazyReferenceUsageWrapper<T>> where T : UnityEngine.Object
{
	[Token(Token = "0x400312F")]
	[FieldOffset(Offset = "0x0")]
	private readonly LazyReference<T> _reference;

	[Token(Token = "0x1700072A")]
	public T Value
	{
		[Token(Token = "0x6003919")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003918")]
	public static implicit operator T(LazyReferenceUsageWrapper<T> r)
	{
		return null;
	}

	[Token(Token = "0x600391A")]
	public LazyReferenceUsageWrapper(LazyReference<T> reference, DisposeAction disposeAction = DisposeAction.Clear)
	{
	}

	[Token(Token = "0x600391B")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600391C")]
	public bool Equals(T other)
	{
		return default(bool);
	}

	[Token(Token = "0x600391D")]
	public bool Equals(LazyReferenceUsageWrapper<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600391E")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600391F")]
	public override int GetHashCode()
	{
		return default(int);
	}
}

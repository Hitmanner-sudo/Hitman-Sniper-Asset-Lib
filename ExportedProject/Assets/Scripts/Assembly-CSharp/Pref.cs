using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2000843")]
public abstract class Pref<T>
{
	[Token(Token = "0x4002EBC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected T _value;

	[Token(Token = "0x4002EBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected string _key;

	[Token(Token = "0x4002EBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private bool _loaded;

	[Token(Token = "0x170006DC")]
	public T Value
	{
		[Token(Token = "0x60035FD")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x60035FE")]
		set
		{
		}
	}

	[Token(Token = "0x60035FC")]
	protected Pref(bool skipCollisionCheck, string key, [Optional] T defaultValue)
	{
	}

	[Token(Token = "0x60035FF")]
	public static implicit operator T(Pref<T> pref)
	{
		return (T)null;
	}

	[Token(Token = "0x6003600")]
	protected abstract void Load(T defaultValue);

	[Token(Token = "0x6003601")]
	protected abstract void Save();

	[Token(Token = "0x6003602")]
	protected static string BuildKey(string key, Type prefType)
	{
		return null;
	}
}

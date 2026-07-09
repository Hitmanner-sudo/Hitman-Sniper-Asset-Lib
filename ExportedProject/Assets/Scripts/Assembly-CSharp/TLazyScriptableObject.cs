using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20008DF")]
public class TLazyScriptableObject<T> : LazyReference<T> where T : ScriptableObject
{
	[Token(Token = "0x600390D")]
	protected override T LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x600390E")]
	public TLazyScriptableObject()
	{
	}
}

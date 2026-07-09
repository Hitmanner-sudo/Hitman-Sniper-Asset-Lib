using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20008A3")]
public class LazyResourceUnlockable : TLazyScriptableObject<ResourceUnlockable>
{
	[Token(Token = "0x6003816")]
	[Address(RVA = "0x997740", Offset = "0x997740", VA = "0x997740", Slot = "9")]
	protected override ResourceUnlockable LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x6003817")]
	[Address(RVA = "0x9977D0", Offset = "0x9977D0", VA = "0x9977D0", Slot = "10")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6003818")]
	[Address(RVA = "0x997910", Offset = "0x997910", VA = "0x997910")]
	public LazyResourceUnlockable()
	{
	}
}

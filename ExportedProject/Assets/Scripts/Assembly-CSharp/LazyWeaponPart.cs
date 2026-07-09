using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20008A0")]
public class LazyWeaponPart : TLazyScriptableObject<WeaponPart>
{
	[Token(Token = "0x600380D")]
	[Address(RVA = "0x9980D8", Offset = "0x9980D8", VA = "0x9980D8", Slot = "9")]
	protected override WeaponPart LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x600380E")]
	[Address(RVA = "0x998168", Offset = "0x998168", VA = "0x998168", Slot = "10")]
	public override void Clear()
	{
	}

	[Token(Token = "0x600380F")]
	[Address(RVA = "0x9982A8", Offset = "0x9982A8", VA = "0x9982A8")]
	public LazyWeaponPart()
	{
	}
}

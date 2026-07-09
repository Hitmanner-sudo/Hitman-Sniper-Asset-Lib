using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20008A4")]
public class LazyIntelUnlockable : TLazyScriptableObject<IntelUnlockable>
{
	[Token(Token = "0x6003819")]
	[Address(RVA = "0x996F80", Offset = "0x996F80", VA = "0x996F80")]
	public void SetPath(string path)
	{
	}

	[Token(Token = "0x600381A")]
	[Address(RVA = "0x996F88", Offset = "0x996F88", VA = "0x996F88", Slot = "9")]
	protected override IntelUnlockable LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x600381B")]
	[Address(RVA = "0x997018", Offset = "0x997018", VA = "0x997018", Slot = "10")]
	public override void Clear()
	{
	}

	[Token(Token = "0x600381C")]
	[Address(RVA = "0x997158", Offset = "0x997158", VA = "0x997158")]
	public LazyIntelUnlockable()
	{
	}
}

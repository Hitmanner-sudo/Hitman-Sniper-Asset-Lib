using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200089E")]
public class LazyUnlockable : TLazyScriptableObject<Unlockable>
{
	[Token(Token = "0x6003807")]
	[Address(RVA = "0x997C54", Offset = "0x997C54", VA = "0x997C54", Slot = "9")]
	protected override Unlockable LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x6003808")]
	[Address(RVA = "0x997CE4", Offset = "0x997CE4", VA = "0x997CE4", Slot = "10")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6003809")]
	[Address(RVA = "0x997E24", Offset = "0x997E24", VA = "0x997E24")]
	public LazyUnlockable()
	{
	}
}

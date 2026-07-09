using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200089F")]
public class LazyWeaponUnlockable : TLazyScriptableObject<WeaponUnlockable>
{
	[Token(Token = "0x600380A")]
	[Address(RVA = "0x9983D8", Offset = "0x9983D8", VA = "0x9983D8", Slot = "9")]
	protected override WeaponUnlockable LoadValue(string path)
	{
		return null;
	}

	[Token(Token = "0x600380B")]
	[Address(RVA = "0x998468", Offset = "0x998468", VA = "0x998468", Slot = "10")]
	public override void Clear()
	{
	}

	[Token(Token = "0x600380C")]
	[Address(RVA = "0x9985A8", Offset = "0x9985A8", VA = "0x9985A8")]
	public LazyWeaponUnlockable()
	{
	}
}

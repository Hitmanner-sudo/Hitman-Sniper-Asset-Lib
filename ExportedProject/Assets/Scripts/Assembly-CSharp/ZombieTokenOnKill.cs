using System;
using Il2CppDummyDll;

[Token(Token = "0x200039F")]
public class ZombieTokenOnKill : WeaponMod
{
	[Token(Token = "0x400147B")]
	[FieldOffset(Offset = "0x70")]
	public int ZombieTokenOnKillAmount;

	[Token(Token = "0x1700038A")]
	public override string Description
	{
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x887AA0", Offset = "0x887AA0", VA = "0x887AA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600165B")]
	[Address(RVA = "0x887B50", Offset = "0x887B50", VA = "0x887B50", Slot = "9")]
	public override void UnEquip()
	{
	}

	[Token(Token = "0x600165C")]
	[Address(RVA = "0x887BF4", Offset = "0x887BF4", VA = "0x887BF4", Slot = "10")]
	protected override void OnWeaponAttached(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600165D")]
	[Address(RVA = "0x887C30", Offset = "0x887C30", VA = "0x887C30")]
	public ZombieTokenOnKill()
	{
	}
}

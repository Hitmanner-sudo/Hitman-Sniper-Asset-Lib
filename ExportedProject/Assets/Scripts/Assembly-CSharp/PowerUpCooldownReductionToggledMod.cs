using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x200042D")]
public class PowerUpCooldownReductionToggledMod : ToggledMod
{
	[Token(Token = "0x400171E")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B5BB4", Offset = "0x5B5BB4")]
	public float CooldownReduction;

	[Token(Token = "0x17000419")]
	public override string GetDescription
	{
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x94247C", Offset = "0x94247C", VA = "0x94247C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x942538", Offset = "0x942538", VA = "0x942538", Slot = "6")]
	public override void Activate()
	{
	}

	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x94257C", Offset = "0x94257C", VA = "0x94257C")]
	public PowerUpCooldownReductionToggledMod()
	{
	}
}

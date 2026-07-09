using System;
using Il2CppDummyDll;

[Token(Token = "0x2000607")]
public class WeaponSuggestionItemModel : DataModel
{
	[Token(Token = "0x400213E")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string WEAPON;

	[NonSerialized]
	[Token(Token = "0x400213F")]
	[FieldOffset(Offset = "0x48")]
	private WeaponUnlockable _weapon;

	[Token(Token = "0x600271C")]
	[Address(RVA = "0x98E44C", Offset = "0x98E44C", VA = "0x98E44C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600271D")]
	[Address(RVA = "0x98E580", Offset = "0x98E580", VA = "0x98E580")]
	public WeaponSuggestionItemModel()
	{
	}

	[Token(Token = "0x600271F")]
	[Address(RVA = "0x98E658", Offset = "0x98E658", VA = "0x98E658")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CF20", Offset = "0x61CF20")]
	private object _003CBindAllVariables_003Eb__2_0()
	{
		return null;
	}

	[Token(Token = "0x6002720")]
	[Address(RVA = "0x98E660", Offset = "0x98E660", VA = "0x98E660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CF30", Offset = "0x61CF30")]
	private void _003CBindAllVariables_003Eb__2_1(object w)
	{
	}
}

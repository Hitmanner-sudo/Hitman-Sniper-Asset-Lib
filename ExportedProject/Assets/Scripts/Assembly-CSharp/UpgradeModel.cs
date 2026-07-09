using Il2CppDummyDll;

[Token(Token = "0x2000604")]
public class UpgradeModel : DataModel
{
	[Token(Token = "0x40020DE")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string WEAPON_NAME;

	[Token(Token = "0x40020DF")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string IGC_CHANGED;

	[Token(Token = "0x40020E0")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string SURVIVOR_DATA;

	[Token(Token = "0x40020E1")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SURVIVOR_HEALTH_RATIO;

	[Token(Token = "0x40020E2")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string HEAL_COST;

	[Token(Token = "0x40020E3")]
	[FieldOffset(Offset = "0x48")]
	private string _weaponName;

	[Token(Token = "0x40020E4")]
	[FieldOffset(Offset = "0x50")]
	private bool _IGCChanged;

	[Token(Token = "0x40020E5")]
	[FieldOffset(Offset = "0x58")]
	private RogueData _survivorData;

	[Token(Token = "0x40020E6")]
	[FieldOffset(Offset = "0x60")]
	private float SurvivorHealthRatio;

	[Token(Token = "0x40020E7")]
	[FieldOffset(Offset = "0x64")]
	private int Heal_Cost;

	[Token(Token = "0x60026B5")]
	[Address(RVA = "0xB9D7B8", Offset = "0xB9D7B8", VA = "0xB9D7B8", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60026B6")]
	[Address(RVA = "0xB9DC04", Offset = "0xB9DC04", VA = "0xB9DC04")]
	public UpgradeModel()
	{
	}

	[Token(Token = "0x60026B8")]
	[Address(RVA = "0xB9DD50", Offset = "0xB9DD50", VA = "0xB9DD50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C940", Offset = "0x61C940")]
	private object _003CBindAllVariables_003Eb__10_0()
	{
		return null;
	}

	[Token(Token = "0x60026B9")]
	[Address(RVA = "0xB9DD58", Offset = "0xB9DD58", VA = "0xB9DD58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C950", Offset = "0x61C950")]
	private void _003CBindAllVariables_003Eb__10_1(object a)
	{
	}

	[Token(Token = "0x60026BA")]
	[Address(RVA = "0xB9DDC8", Offset = "0xB9DDC8", VA = "0xB9DDC8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C960", Offset = "0x61C960")]
	private bool _003CBindAllVariables_003Eb__10_2()
	{
		return default(bool);
	}

	[Token(Token = "0x60026BB")]
	[Address(RVA = "0xB9DDD0", Offset = "0xB9DDD0", VA = "0xB9DDD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C970", Offset = "0x61C970")]
	private void _003CBindAllVariables_003Eb__10_3(bool a)
	{
	}

	[Token(Token = "0x60026BC")]
	[Address(RVA = "0xB9DDDC", Offset = "0xB9DDDC", VA = "0xB9DDDC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C980", Offset = "0x61C980")]
	private object _003CBindAllVariables_003Eb__10_4()
	{
		return null;
	}

	[Token(Token = "0x60026BD")]
	[Address(RVA = "0xB9DDE4", Offset = "0xB9DDE4", VA = "0xB9DDE4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C990", Offset = "0x61C990")]
	private void _003CBindAllVariables_003Eb__10_5(object a)
	{
	}

	[Token(Token = "0x60026BE")]
	[Address(RVA = "0xB9DE70", Offset = "0xB9DE70", VA = "0xB9DE70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C9A0", Offset = "0x61C9A0")]
	private float _003CBindAllVariables_003Eb__10_6()
	{
		return default(float);
	}

	[Token(Token = "0x60026BF")]
	[Address(RVA = "0xB9DE78", Offset = "0xB9DE78", VA = "0xB9DE78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C9B0", Offset = "0x61C9B0")]
	private void _003CBindAllVariables_003Eb__10_7(float a)
	{
	}

	[Token(Token = "0x60026C0")]
	[Address(RVA = "0xB9DE80", Offset = "0xB9DE80", VA = "0xB9DE80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C9C0", Offset = "0x61C9C0")]
	private int _003CBindAllVariables_003Eb__10_8()
	{
		return default(int);
	}

	[Token(Token = "0x60026C1")]
	[Address(RVA = "0xB9DE88", Offset = "0xB9DE88", VA = "0xB9DE88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C9D0", Offset = "0x61C9D0")]
	private void _003CBindAllVariables_003Eb__10_9(int a)
	{
	}
}

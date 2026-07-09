using Il2CppDummyDll;

[Token(Token = "0x20005D6")]
public class BlueprintPartModel : DataModel
{
	[Token(Token = "0x4001F86")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string UNLOCKABLE_RESOURCE;

	[Token(Token = "0x4001F87")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string SHOW_PART_COUNT;

	[Token(Token = "0x4001F88")]
	[FieldOffset(Offset = "0x48")]
	private WeaponUnlockable.RequiredPartInfo _unlockableResource;

	[Token(Token = "0x4001F89")]
	[FieldOffset(Offset = "0x50")]
	private bool _showPartCounts;

	[Token(Token = "0x6002572")]
	[Address(RVA = "0xA775D4", Offset = "0xA775D4", VA = "0xA775D4", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002573")]
	[Address(RVA = "0xA777E4", Offset = "0xA777E4", VA = "0xA777E4")]
	public BlueprintPartModel()
	{
	}

	[Token(Token = "0x6002575")]
	[Address(RVA = "0xA77874", Offset = "0xA77874", VA = "0xA77874")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD50", Offset = "0x61BD50")]
	private object _003CBindAllVariables_003Eb__4_0()
	{
		return null;
	}

	[Token(Token = "0x6002576")]
	[Address(RVA = "0xA7787C", Offset = "0xA7787C", VA = "0xA7787C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD60", Offset = "0x61BD60")]
	private void _003CBindAllVariables_003Eb__4_1(object s)
	{
	}

	[Token(Token = "0x6002577")]
	[Address(RVA = "0xA77908", Offset = "0xA77908", VA = "0xA77908")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD70", Offset = "0x61BD70")]
	private bool _003CBindAllVariables_003Eb__4_2()
	{
		return default(bool);
	}

	[Token(Token = "0x6002578")]
	[Address(RVA = "0xA77910", Offset = "0xA77910", VA = "0xA77910")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BD80", Offset = "0x61BD80")]
	private void _003CBindAllVariables_003Eb__4_3(bool b)
	{
	}
}

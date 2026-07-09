using Il2CppDummyDll;

[Token(Token = "0x200039A")]
public class ScopeUpgrade : Attachment
{
	[Token(Token = "0x400142F")]
	[FieldOffset(Offset = "0x18")]
	public ScopeData.ScopeSetting Settings;

	[Token(Token = "0x60015FD")]
	[Address(RVA = "0xBB35E8", Offset = "0xBB35E8", VA = "0xBB35E8", Slot = "31")]
	public override float MinScopeFOVModifier(float minFOV)
	{
		return default(float);
	}

	[Token(Token = "0x60015FE")]
	[Address(RVA = "0xBB361C", Offset = "0xBB361C", VA = "0xBB361C", Slot = "32")]
	public override float MaxScopeFOVModifier(float maxFOV)
	{
		return default(float);
	}

	[Token(Token = "0x60015FF")]
	[Address(RVA = "0xBB3650", Offset = "0xBB3650", VA = "0xBB3650", Slot = "67")]
	protected override bool ModifiersOverlap(Attachment attach)
	{
		return default(bool);
	}

	[Token(Token = "0x6001600")]
	[Address(RVA = "0xBB3690", Offset = "0xBB3690", VA = "0xBB3690")]
	public ScopeUpgrade()
	{
	}
}

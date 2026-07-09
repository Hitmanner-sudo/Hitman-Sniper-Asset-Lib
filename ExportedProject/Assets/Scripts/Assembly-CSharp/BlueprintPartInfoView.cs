using Il2CppDummyDll;

[Token(Token = "0x20006E7")]
public class BlueprintPartInfoView : View
{
	[Token(Token = "0x20006E8")]
	public delegate void BlueprintPartInfoCallback();

	[Token(Token = "0x400275E")]
	[FieldOffset(Offset = "0x60")]
	public UILabel Title;

	[Token(Token = "0x400275F")]
	[FieldOffset(Offset = "0x68")]
	public UITexture PartTexture;

	[Token(Token = "0x4002760")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Description;

	[Token(Token = "0x4002761")]
	[FieldOffset(Offset = "0x78")]
	public BlueprintPartInfoCallback OnPurchase;

	[Token(Token = "0x4002762")]
	[FieldOffset(Offset = "0x80")]
	public BlueprintPartInfoCallback OnBack;

	[Token(Token = "0x4002763")]
	[FieldOffset(Offset = "0x88")]
	private AttachmentsUnlockable _part;

	[Token(Token = "0x4002764")]
	[FieldOffset(Offset = "0x90")]
	private float _cachedPartPrice;

	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0xA771A8", Offset = "0xA771A8", VA = "0xA771A8")]
	public void SetupPartInfoView(AttachmentsUnlockable part, BlueprintPartInfoCallback onPurchase, BlueprintPartInfoCallback onBack)
	{
	}

	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0xA77338", Offset = "0xA77338", VA = "0xA77338", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0xA7743C", Offset = "0xA7743C", VA = "0xA7743C", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0xA77464", Offset = "0xA77464", VA = "0xA77464")]
	private void UpdatePartPrice()
	{
	}

	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0xA775C4", Offset = "0xA775C4", VA = "0xA775C4")]
	public BlueprintPartInfoView()
	{
	}
}

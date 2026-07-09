using Il2CppDummyDll;

[Token(Token = "0x200051E")]
[Attribute(Name = "GameUpdateOrderAttribute", RVA = "0x594FDC", Offset = "0x594FDC")]
public class InScopeHUDController : UIController
{
	[Token(Token = "0x4001B05")]
	[FieldOffset(Offset = "0x50")]
	public ButtonHandler SlowMotionButton;

	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0xA19B1C", Offset = "0xA19B1C", VA = "0xA19B1C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0xA19BD0", Offset = "0xA19BD0", VA = "0xA19BD0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0xA19CD0", Offset = "0xA19CD0", VA = "0xA19CD0")]
	private void OnSlowMotionButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0xA19E34", Offset = "0xA19E34", VA = "0xA19E34")]
	public InScopeHUDController()
	{
	}
}

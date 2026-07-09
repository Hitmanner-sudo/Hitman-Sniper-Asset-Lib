using Il2CppDummyDll;

[Token(Token = "0x200052A")]
public class PauseButtonController : UIController
{
	[Token(Token = "0x4001B63")]
	[FieldOffset(Offset = "0x50")]
	public ButtonHandler PauseButton;

	[Token(Token = "0x600201C")]
	[Address(RVA = "0x8F7328", Offset = "0x8F7328", VA = "0x8F7328", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600201D")]
	[Address(RVA = "0x8F7360", Offset = "0x8F7360", VA = "0x8F7360", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600201E")]
	[Address(RVA = "0x8F7410", Offset = "0x8F7410", VA = "0x8F7410", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600201F")]
	[Address(RVA = "0x8F74FC", Offset = "0x8F74FC", VA = "0x8F74FC")]
	private void OnPauseButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002020")]
	[Address(RVA = "0x8F76F8", Offset = "0x8F76F8", VA = "0x8F76F8")]
	public PauseButtonController()
	{
	}
}

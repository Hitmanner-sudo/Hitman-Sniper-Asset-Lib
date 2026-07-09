using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D5")]
public class SetStartButtonActive : View
{
	[Token(Token = "0x4002685")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _startButtonLabel;

	[Token(Token = "0x4002686")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UISprite _startButtonBackground;

	[Token(Token = "0x4002687")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UISprite _startButtonIcon;

	[Token(Token = "0x4002688")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private BlinkButtonHandler _startButtonHandler;

	[Token(Token = "0x4002689")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Collider _startButtonCollider;

	[Token(Token = "0x400268A")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UILabel _socialManagerStatusDEBUG;

	[Token(Token = "0x6002CF5")]
	[Address(RVA = "0x83ABE4", Offset = "0x83ABE4", VA = "0x83ABE4", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x83AEE0", Offset = "0x83AEE0", VA = "0x83AEE0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x83AFF0", Offset = "0x83AFF0", VA = "0x83AFF0", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x83B0A4", Offset = "0x83B0A4", VA = "0x83B0A4")]
	private void OnSocialManagerStatusChanged(object sender, SocialManager.StatusEvent e)
	{
	}

	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x83ACB4", Offset = "0x83ACB4", VA = "0x83ACB4")]
	private void CheckEnabled()
	{
	}

	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x83B0A8", Offset = "0x83B0A8", VA = "0x83B0A8")]
	public static Color GetButtonColor(bool enabled, ColorModel.ColorModelEnum enabledColor, ColorModel.ColorModelEnum disabledColor)
	{
		return default(Color);
	}

	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x83B144", Offset = "0x83B144", VA = "0x83B144")]
	public SetStartButtonActive()
	{
	}
}

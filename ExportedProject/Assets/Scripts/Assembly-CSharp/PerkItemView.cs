using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B9")]
public class PerkItemView : View
{
	[Token(Token = "0x4002597")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UISprite _backgroundSprite;

	[Token(Token = "0x4002598")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _lockGameObject;

	[Token(Token = "0x4002599")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UITexture _iconTexture;

	[Token(Token = "0x400259A")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UILabel _nameLabel;

	[Token(Token = "0x400259B")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _statusBarLabel;

	[Token(Token = "0x400259C")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UISprite _statusBarBackgroundSprite;

	[Token(Token = "0x400259D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private BlinkButtonHandler _statusBarBackgroundBlinkButtonHandler;

	[Token(Token = "0x400259E")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private BoxCollider _statusBarBackgroundBoxCollider;

	[Token(Token = "0x400259F")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UISprite _statusBarForegroundSprite;

	[Token(Token = "0x40025A0")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Color _backgroundNotClaimedColor;

	[Token(Token = "0x40025A1")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Color _backgroundClaimedColor;

	[Token(Token = "0x40025A2")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Color _iconNotClaimedColor;

	[Token(Token = "0x40025A3")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Color _iconClaimedColor;

	[Token(Token = "0x40025A4")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Color _statusBarTextClaimedColor;

	[Token(Token = "0x40025A5")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private Color _statusBarTextCompletedColor;

	[Token(Token = "0x40025A6")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private Color _statusBarTextInProgressColor;

	[Token(Token = "0x40025A7")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private Color _statusBarBackgroundClaimedColor;

	[Token(Token = "0x40025A8")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private Color _statusBarBackgroundCompletedColor;

	[Token(Token = "0x40025A9")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private Color _statusBarBackgroundInProgressColor;

	[Token(Token = "0x40025AA")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private Color _statusBarForegroundClaimedColor;

	[Token(Token = "0x40025AB")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private Color _statusBarForegroundCompletedColor;

	[Token(Token = "0x40025AC")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	private Color _statusBarForegroundInProgressColor;

	[Token(Token = "0x6002C2A")]
	[Address(RVA = "0x8FFED0", Offset = "0x8FFED0", VA = "0x8FFED0", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C2B")]
	[Address(RVA = "0x8FFFBC", Offset = "0x8FFFBC", VA = "0x8FFFBC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002C2C")]
	[Address(RVA = "0x8FFF6C", Offset = "0x8FFF6C", VA = "0x8FFF6C")]
	private void OnPerkChanged(Perk perk)
	{
	}

	[Token(Token = "0x6002C2D")]
	[Address(RVA = "0x90015C", Offset = "0x90015C", VA = "0x90015C")]
	private void OnPerkClaimedChanged(bool claimed)
	{
	}

	[Token(Token = "0x6002C2E")]
	[Address(RVA = "0x900208", Offset = "0x900208", VA = "0x900208")]
	private void SetName(Perk perk)
	{
	}

	[Token(Token = "0x6002C2F")]
	[Address(RVA = "0x900344", Offset = "0x900344", VA = "0x900344")]
	private void SetBackground(Perk perk)
	{
	}

	[Token(Token = "0x6002C30")]
	[Address(RVA = "0x900430", Offset = "0x900430", VA = "0x900430")]
	private void SetIcon(Perk perk)
	{
	}

	[Token(Token = "0x6002C31")]
	[Address(RVA = "0x900570", Offset = "0x900570", VA = "0x900570")]
	private void SetStatusBar(Perk perk)
	{
	}

	[Token(Token = "0x6002C32")]
	[Address(RVA = "0x900678", Offset = "0x900678", VA = "0x900678")]
	private void ShowPerkClaimed()
	{
	}

	[Token(Token = "0x6002C33")]
	[Address(RVA = "0x90093C", Offset = "0x90093C", VA = "0x90093C")]
	private void ShowPerkCompleted()
	{
	}

	[Token(Token = "0x6002C34")]
	[Address(RVA = "0x900BEC", Offset = "0x900BEC", VA = "0x900BEC")]
	private void ShowPerkInProgress(Perk perk)
	{
	}

	[Token(Token = "0x6002C35")]
	[Address(RVA = "0x9005B0", Offset = "0x9005B0", VA = "0x9005B0")]
	private void SetLock(Perk perk)
	{
	}

	[Token(Token = "0x6002C36")]
	[Address(RVA = "0x900EF8", Offset = "0x900EF8", VA = "0x900EF8")]
	public Vector2 GetBackgroundSize()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002C37")]
	[Address(RVA = "0x900F90", Offset = "0x900F90", VA = "0x900F90", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002C38")]
	[Address(RVA = "0x9010C8", Offset = "0x9010C8", VA = "0x9010C8")]
	public PerkItemView()
	{
	}
}

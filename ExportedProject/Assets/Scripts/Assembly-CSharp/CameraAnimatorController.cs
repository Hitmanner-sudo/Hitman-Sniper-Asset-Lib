using Il2CppDummyDll;
using Sniper.Gameplay;

[Token(Token = "0x200047C")]
public class CameraAnimatorController : AnimatorController
{
	[Token(Token = "0x4001864")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int IS_RELOADING_HASH;

	[Token(Token = "0x4001865")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int IS_AUTOMATIC_RELOAD_HASH;

	[Token(Token = "0x4001866")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int QUICK_RELOAD_HASH;

	[Token(Token = "0x4001867")]
	[FieldOffset(Offset = "0x50")]
	private bool? _isReloadingCache;

	[Token(Token = "0x4001868")]
	[FieldOffset(Offset = "0x52")]
	private bool? _isAutomaticReloadCache;

	[Token(Token = "0x4001869")]
	[FieldOffset(Offset = "0x54")]
	private bool? _quickReloadCache;

	[Token(Token = "0x17000426")]
	public bool IsReloading
	{
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0xAF143C", Offset = "0xAF143C", VA = "0xAF143C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0xAF1550", Offset = "0xAF1550", VA = "0xAF1550")]
		set
		{
		}
	}

	[Token(Token = "0x17000427")]
	public bool IsAutomaticReload
	{
		[Token(Token = "0x6001AEF")]
		[Address(RVA = "0xAF1644", Offset = "0xAF1644", VA = "0xAF1644")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AF0")]
		[Address(RVA = "0xAF1758", Offset = "0xAF1758", VA = "0xAF1758")]
		set
		{
		}
	}

	[Token(Token = "0x17000428")]
	public bool QuickReload
	{
		[Token(Token = "0x6001AF1")]
		[Address(RVA = "0xAF184C", Offset = "0xAF184C", VA = "0xAF184C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0xAF1960", Offset = "0xAF1960", VA = "0xAF1960")]
		set
		{
		}
	}

	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0xAF1A54", Offset = "0xAF1A54", VA = "0xAF1A54", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0xAF1A60", Offset = "0xAF1A60", VA = "0xAF1A60")]
	public CameraAnimatorController()
	{
	}
}

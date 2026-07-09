using Il2CppDummyDll;
using Sniper.Gameplay;

[Token(Token = "0x20003A9")]
public class WeaponAnimatorController : AnimatorController
{
	[Token(Token = "0x40014B2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int IS_RELOADING_HASH;

	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int IS_AUTOMATIC_RELOAD_HASH;

	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int QUICK_RELOAD_HASH;

	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int BOLT_CYCLE_HASH;

	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int BOLT_CYCLE_SPEED_HASH;

	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x50")]
	private bool? _isReloadingCache;

	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x52")]
	private bool? _isAutomaticeReloadCache;

	[Token(Token = "0x40014B9")]
	[FieldOffset(Offset = "0x54")]
	private bool? _quickReloadCache;

	[Token(Token = "0x40014BA")]
	[FieldOffset(Offset = "0x56")]
	private bool? _boltCycleCache;

	[Token(Token = "0x17000395")]
	public bool IsReloading
	{
		[Token(Token = "0x60016A2")]
		[Address(RVA = "0x9837D0", Offset = "0x9837D0", VA = "0x9837D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016A3")]
		[Address(RVA = "0x9838E4", Offset = "0x9838E4", VA = "0x9838E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000396")]
	public bool IsAutomaticReload
	{
		[Token(Token = "0x60016A4")]
		[Address(RVA = "0x9839D8", Offset = "0x9839D8", VA = "0x9839D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016A5")]
		[Address(RVA = "0x983AEC", Offset = "0x983AEC", VA = "0x983AEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000397")]
	public bool QuickReload
	{
		[Token(Token = "0x60016A6")]
		[Address(RVA = "0x983BE0", Offset = "0x983BE0", VA = "0x983BE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60016A7")]
		[Address(RVA = "0x983CF4", Offset = "0x983CF4", VA = "0x983CF4")]
		set
		{
		}
	}

	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x983DE8", Offset = "0x983DE8", VA = "0x983DE8")]
	protected bool GetBoltCycle()
	{
		return default(bool);
	}

	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x983EFC", Offset = "0x983EFC", VA = "0x983EFC")]
	protected void SetBoltCycle(bool value)
	{
	}

	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x983FF0", Offset = "0x983FF0", VA = "0x983FF0")]
	public void SetBoltCycleSpeed(float speed)
	{
	}

	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x9840D0", Offset = "0x9840D0", VA = "0x9840D0")]
	public void TriggerBoltCycle()
	{
	}

	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x9841A0", Offset = "0x9841A0", VA = "0x9841A0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x9841C8", Offset = "0x9841C8", VA = "0x9841C8", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x9841D0", Offset = "0x9841D0", VA = "0x9841D0")]
	public WeaponAnimatorController()
	{
	}
}

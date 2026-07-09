using Il2CppDummyDll;
using Sniper.Gameplay;
using UnityEngine;

[Token(Token = "0x200047D")]
public class PlayerAnimatorController : AnimatorController
{
	[Token(Token = "0x400186A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int IS_RELOADING_HASH;

	[Token(Token = "0x400186B")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int ANIMATION_STAGE_HASH;

	[Token(Token = "0x400186C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int IS_AUTOMATIC_RELOAD_HASH;

	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int ANIMATOR_SPEED_HASH;

	[Token(Token = "0x400186E")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int TIMESCALE_HASH;

	[Token(Token = "0x400186F")]
	[FieldOffset(Offset = "0x14")]
	public static readonly int QUICK_RELOAD_HASH;

	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int BOLT_CYCLE_HASH;

	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0x1C")]
	private static readonly int BOLT_CYCLE_SPEED_HASH;

	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0x50")]
	private bool? _isReloadingCache;

	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x54")]
	private int? _animationStageCache;

	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0x5C")]
	private bool? _isAutomaticReloadCache;

	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0x60")]
	private float? _animatorSpeedCache;

	[Token(Token = "0x4001876")]
	[FieldOffset(Offset = "0x68")]
	private float? _timeScaleCache;

	[Token(Token = "0x4001877")]
	[FieldOffset(Offset = "0x70")]
	private bool? _quickReloadCache;

	[Token(Token = "0x4001878")]
	[FieldOffset(Offset = "0x72")]
	private bool? _boltCycleCache;

	[Token(Token = "0x4001879")]
	[FieldOffset(Offset = "0x78")]
	private AnimationEventProxy _animEvents;

	[Token(Token = "0x17000429")]
	public bool IsReloading
	{
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0xB82BE0", Offset = "0xB82BE0", VA = "0xB82BE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0xB82CF4", Offset = "0xB82CF4", VA = "0xB82CF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700042A")]
	public int AnimationStage
	{
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0xB82DE8", Offset = "0xB82DE8", VA = "0xB82DE8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700042B")]
	public bool IsAutomaticReload
	{
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0xB82EFC", Offset = "0xB82EFC", VA = "0xB82EFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0xB83010", Offset = "0xB83010", VA = "0xB83010")]
		set
		{
		}
	}

	[Token(Token = "0x1700042C")]
	public float AnimatorSpeed
	{
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0xB83104", Offset = "0xB83104", VA = "0xB83104")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700042D")]
	public float TimeScale
	{
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0xB83210", Offset = "0xB83210", VA = "0xB83210")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700042E")]
	public bool QuickReload
	{
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0xB8331C", Offset = "0xB8331C", VA = "0xB8331C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0xB83430", Offset = "0xB83430", VA = "0xB83430")]
		set
		{
		}
	}

	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0xB8299C", Offset = "0xB8299C", VA = "0xB8299C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0xB82AB4", Offset = "0xB82AB4", VA = "0xB82AB4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001B01")]
	[Address(RVA = "0xB83524", Offset = "0xB83524", VA = "0xB83524")]
	protected bool GetBoltCycle()
	{
		return default(bool);
	}

	[Token(Token = "0x6001B02")]
	[Address(RVA = "0xB83638", Offset = "0xB83638", VA = "0xB83638")]
	protected void SetBoltCycle(bool value)
	{
	}

	[Token(Token = "0x6001B03")]
	[Address(RVA = "0xB8372C", Offset = "0xB8372C", VA = "0xB8372C")]
	public void SetBoltCycleSpeed(float speed)
	{
	}

	[Token(Token = "0x6001B04")]
	[Address(RVA = "0xB8380C", Offset = "0xB8380C", VA = "0xB8380C")]
	public void TriggerBoltCycle()
	{
	}

	[Token(Token = "0x6001B05")]
	[Address(RVA = "0xB838DC", Offset = "0xB838DC", VA = "0xB838DC", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x6001B06")]
	[Address(RVA = "0xB838F4", Offset = "0xB838F4", VA = "0xB838F4")]
	private void OnSoundEvent(GameObject sender, AnimationEvent ev)
	{
	}

	[Token(Token = "0x6001B07")]
	[Address(RVA = "0xB83B38", Offset = "0xB83B38", VA = "0xB83B38")]
	public PlayerAnimatorController()
	{
	}
}

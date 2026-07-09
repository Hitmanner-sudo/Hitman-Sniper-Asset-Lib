using System;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20005CF")]
public class PowerUpData : DataModel
{
	[Token(Token = "0x4001F37")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ACTIVE_TIMER;

	[Token(Token = "0x4001F38")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string ACTIVE_TIME;

	[Token(Token = "0x4001F39")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string TOOLTIP;

	[Token(Token = "0x4001F3A")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string IS_ENABLED;

	[Token(Token = "0x4001F3B")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string POWERUP_OBJECT;

	[Token(Token = "0x4001F3C")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string IS_ACTIVE;

	[Token(Token = "0x4001F3D")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string IS_UNLOCKED;

	[Token(Token = "0x4001F3E")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string ACTIVE_PROGRESS;

	[Token(Token = "0x4001F3F")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string SHOW_TOOLTIP;

	[Token(Token = "0x4001F40")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string COOLDOWN_TIMER;

	[Token(Token = "0x4001F41")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string IS_ON_COOLDOWN;

	[Token(Token = "0x4001F42")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string SPECIFIC_ACTIVATE_SOUND;

	[Token(Token = "0x4001F43")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string REQUEST_START_COOLDOWN;

	[Token(Token = "0x4001F44")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string REQUEST_DEACTIVATE;

	[Token(Token = "0x4001F45")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string IS_BLOCKED_BY_SELF;

	[Token(Token = "0x4001F46")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string IS_BLOCKED_BY_ACTIVE_POWERUP;

	[Token(Token = "0x4001F47")]
	[FieldOffset(Offset = "0x80")]
	public static readonly string REQUEST_UPDATE_BLOCKED_POWERUPS;

	[Token(Token = "0x4001F48")]
	[FieldOffset(Offset = "0x88")]
	public static readonly string TOOLTIP_DEPTH;

	[Token(Token = "0x4001F49")]
	[FieldOffset(Offset = "0x48")]
	public float ActiveTime;

	[Token(Token = "0x4001F4A")]
	[FieldOffset(Offset = "0x50")]
	public SoundContainer SpecificActivateSound;

	[NonSerialized]
	[Token(Token = "0x4001F4B")]
	[FieldOffset(Offset = "0x58")]
	private GameTimer _activeTimer;

	[NonSerialized]
	[Token(Token = "0x4001F4C")]
	[FieldOffset(Offset = "0x60")]
	private PowerUp _powerUpObject;

	[NonSerialized]
	[Token(Token = "0x4001F4D")]
	[FieldOffset(Offset = "0x68")]
	private bool _isActive;

	[NonSerialized]
	[Token(Token = "0x4001F4E")]
	[FieldOffset(Offset = "0x69")]
	private bool _isUnlocked;

	[NonSerialized]
	[Token(Token = "0x4001F4F")]
	[FieldOffset(Offset = "0x6C")]
	private float _activeProgress;

	[NonSerialized]
	[Token(Token = "0x4001F50")]
	[FieldOffset(Offset = "0x70")]
	private bool _showTooltip;

	[NonSerialized]
	[Token(Token = "0x4001F51")]
	[FieldOffset(Offset = "0x78")]
	private GameTimer _cooldownTimer;

	[NonSerialized]
	[Token(Token = "0x4001F52")]
	[FieldOffset(Offset = "0x80")]
	private bool _isOnCooldown;

	[NonSerialized]
	[Token(Token = "0x4001F53")]
	[FieldOffset(Offset = "0x81")]
	private bool _requestStartCooldown;

	[NonSerialized]
	[Token(Token = "0x4001F54")]
	[FieldOffset(Offset = "0x82")]
	private bool _requestDeactivate;

	[NonSerialized]
	[Token(Token = "0x4001F55")]
	[FieldOffset(Offset = "0x83")]
	private bool _isBlockedByActivePowerUp;

	[NonSerialized]
	[Token(Token = "0x4001F56")]
	[FieldOffset(Offset = "0x84")]
	private bool _isBlockedBySelf;

	[NonSerialized]
	[Token(Token = "0x4001F57")]
	[FieldOffset(Offset = "0x85")]
	private bool _requestUpdateBlockedPowerUps;

	[NonSerialized]
	[Token(Token = "0x4001F58")]
	[FieldOffset(Offset = "0x88")]
	private int _tooltipDepth;

	[Token(Token = "0x17000523")]
	protected PlayerController Player
	{
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x942584", Offset = "0x942584", VA = "0x942584")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002509")]
	[Address(RVA = "0x9425D0", Offset = "0x9425D0", VA = "0x9425D0", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x600250A")]
	[Address(RVA = "0x942FCC", Offset = "0x942FCC", VA = "0x942FCC")]
	private bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x600250B")]
	[Address(RVA = "0x942FEC", Offset = "0x942FEC", VA = "0x942FEC")]
	private void SetEnabledControlVariable(ref bool controlVar, bool value)
	{
	}

	[Token(Token = "0x600250C")]
	[Address(RVA = "0x943160", Offset = "0x943160", VA = "0x943160")]
	public PowerUpData()
	{
	}

	[Token(Token = "0x600250E")]
	[Address(RVA = "0x94346C", Offset = "0x94346C", VA = "0x94346C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B880", Offset = "0x61B880")]
	private object _003CBindAllVariables_003Eb__36_0()
	{
		return null;
	}

	[Token(Token = "0x600250F")]
	[Address(RVA = "0x943474", Offset = "0x943474", VA = "0x943474")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B890", Offset = "0x61B890")]
	private float _003CBindAllVariables_003Eb__36_1()
	{
		return default(float);
	}

	[Token(Token = "0x6002510")]
	[Address(RVA = "0x94347C", Offset = "0x94347C", VA = "0x94347C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B8A0", Offset = "0x61B8A0")]
	private void _003CBindAllVariables_003Eb__36_2(float a)
	{
	}

	[Token(Token = "0x6002511")]
	[Address(RVA = "0x943484", Offset = "0x943484", VA = "0x943484")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B8B0", Offset = "0x61B8B0")]
	private bool _003CBindAllVariables_003Eb__36_3()
	{
		return default(bool);
	}

	[Token(Token = "0x6002512")]
	[Address(RVA = "0x9434A4", Offset = "0x9434A4", VA = "0x9434A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B8C0", Offset = "0x61B8C0")]
	private object _003CBindAllVariables_003Eb__36_4()
	{
		return null;
	}

	[Token(Token = "0x6002513")]
	[Address(RVA = "0x9434AC", Offset = "0x9434AC", VA = "0x9434AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B8D0", Offset = "0x61B8D0")]
	private void _003CBindAllVariables_003Eb__36_5(object a)
	{
	}

	[Token(Token = "0x6002514")]
	[Address(RVA = "0x943538", Offset = "0x943538", VA = "0x943538")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B8E0", Offset = "0x61B8E0")]
	private bool _003CBindAllVariables_003Eb__36_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002515")]
	[Address(RVA = "0x943540", Offset = "0x943540", VA = "0x943540")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B8F0", Offset = "0x61B8F0")]
	private void _003CBindAllVariables_003Eb__36_7(bool a)
	{
	}

	[Token(Token = "0x6002516")]
	[Address(RVA = "0x94354C", Offset = "0x94354C", VA = "0x94354C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B900", Offset = "0x61B900")]
	private bool _003CBindAllVariables_003Eb__36_8()
	{
		return default(bool);
	}

	[Token(Token = "0x6002517")]
	[Address(RVA = "0x943554", Offset = "0x943554", VA = "0x943554")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B910", Offset = "0x61B910")]
	private void _003CBindAllVariables_003Eb__36_9(bool a)
	{
	}

	[Token(Token = "0x6002518")]
	[Address(RVA = "0x943560", Offset = "0x943560", VA = "0x943560")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B920", Offset = "0x61B920")]
	private float _003CBindAllVariables_003Eb__36_10()
	{
		return default(float);
	}

	[Token(Token = "0x6002519")]
	[Address(RVA = "0x943568", Offset = "0x943568", VA = "0x943568")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B930", Offset = "0x61B930")]
	private void _003CBindAllVariables_003Eb__36_11(float a)
	{
	}

	[Token(Token = "0x600251A")]
	[Address(RVA = "0x943570", Offset = "0x943570", VA = "0x943570")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B940", Offset = "0x61B940")]
	private bool _003CBindAllVariables_003Eb__36_12()
	{
		return default(bool);
	}

	[Token(Token = "0x600251B")]
	[Address(RVA = "0x943578", Offset = "0x943578", VA = "0x943578")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B950", Offset = "0x61B950")]
	private void _003CBindAllVariables_003Eb__36_13(bool a)
	{
	}

	[Token(Token = "0x600251C")]
	[Address(RVA = "0x943584", Offset = "0x943584", VA = "0x943584")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B960", Offset = "0x61B960")]
	private object _003CBindAllVariables_003Eb__36_14()
	{
		return null;
	}

	[Token(Token = "0x600251D")]
	[Address(RVA = "0x94358C", Offset = "0x94358C", VA = "0x94358C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B970", Offset = "0x61B970")]
	private bool _003CBindAllVariables_003Eb__36_15()
	{
		return default(bool);
	}

	[Token(Token = "0x600251E")]
	[Address(RVA = "0x943594", Offset = "0x943594", VA = "0x943594")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B980", Offset = "0x61B980")]
	private void _003CBindAllVariables_003Eb__36_16(bool a)
	{
	}

	[Token(Token = "0x600251F")]
	[Address(RVA = "0x9435A0", Offset = "0x9435A0", VA = "0x9435A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B990", Offset = "0x61B990")]
	private object _003CBindAllVariables_003Eb__36_17()
	{
		return null;
	}

	[Token(Token = "0x6002520")]
	[Address(RVA = "0x9435A8", Offset = "0x9435A8", VA = "0x9435A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B9A0", Offset = "0x61B9A0")]
	private bool _003CBindAllVariables_003Eb__36_18()
	{
		return default(bool);
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0x9435B0", Offset = "0x9435B0", VA = "0x9435B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B9B0", Offset = "0x61B9B0")]
	private void _003CBindAllVariables_003Eb__36_19(bool a)
	{
	}

	[Token(Token = "0x6002522")]
	[Address(RVA = "0x9435BC", Offset = "0x9435BC", VA = "0x9435BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B9C0", Offset = "0x61B9C0")]
	private bool _003CBindAllVariables_003Eb__36_20()
	{
		return default(bool);
	}

	[Token(Token = "0x6002523")]
	[Address(RVA = "0x9435C4", Offset = "0x9435C4", VA = "0x9435C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B9D0", Offset = "0x61B9D0")]
	private void _003CBindAllVariables_003Eb__36_21(bool a)
	{
	}

	[Token(Token = "0x6002524")]
	[Address(RVA = "0x9435D0", Offset = "0x9435D0", VA = "0x9435D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B9E0", Offset = "0x61B9E0")]
	private bool _003CBindAllVariables_003Eb__36_22()
	{
		return default(bool);
	}

	[Token(Token = "0x6002525")]
	[Address(RVA = "0x9435D8", Offset = "0x9435D8", VA = "0x9435D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B9F0", Offset = "0x61B9F0")]
	private void _003CBindAllVariables_003Eb__36_23(bool a)
	{
	}

	[Token(Token = "0x6002526")]
	[Address(RVA = "0x9435E8", Offset = "0x9435E8", VA = "0x9435E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA00", Offset = "0x61BA00")]
	private bool _003CBindAllVariables_003Eb__36_24()
	{
		return default(bool);
	}

	[Token(Token = "0x6002527")]
	[Address(RVA = "0x9435F0", Offset = "0x9435F0", VA = "0x9435F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA10", Offset = "0x61BA10")]
	private void _003CBindAllVariables_003Eb__36_25(bool a)
	{
	}

	[Token(Token = "0x6002528")]
	[Address(RVA = "0x943600", Offset = "0x943600", VA = "0x943600")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA20", Offset = "0x61BA20")]
	private bool _003CBindAllVariables_003Eb__36_26()
	{
		return default(bool);
	}

	[Token(Token = "0x6002529")]
	[Address(RVA = "0x943608", Offset = "0x943608", VA = "0x943608")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA30", Offset = "0x61BA30")]
	private void _003CBindAllVariables_003Eb__36_27(bool a)
	{
	}

	[Token(Token = "0x600252A")]
	[Address(RVA = "0x943614", Offset = "0x943614", VA = "0x943614")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA40", Offset = "0x61BA40")]
	private int _003CBindAllVariables_003Eb__36_28()
	{
		return default(int);
	}

	[Token(Token = "0x600252B")]
	[Address(RVA = "0x94361C", Offset = "0x94361C", VA = "0x94361C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61BA50", Offset = "0x61BA50")]
	private void _003CBindAllVariables_003Eb__36_29(int i)
	{
	}
}

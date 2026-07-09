using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000606")]
public class WeaponHUDModel : DataModel
{
	[Token(Token = "0x40020F6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string SHOW_RELOAD_BUTTON;

	[Token(Token = "0x40020F7")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string IS_IN_SCOPE;

	[Token(Token = "0x40020F8")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string SHOW_RELOAD_WARNING;

	[Token(Token = "0x40020F9")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string MAX_AMMUNITION_COUNT;

	[Token(Token = "0x40020FA")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string CURRENT_AMMUNITION_COUNT;

	[Token(Token = "0x40020FB")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string LOW_AMMO_PERCENTAGE_TRESHOLD;

	[Token(Token = "0x40020FC")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string PULSE_LOW_AMMOW_DURATION;

	[Token(Token = "0x40020FD")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string IS_RELOADING;

	[Token(Token = "0x40020FE")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string RELOAD;

	[Token(Token = "0x40020FF")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string MAX_TAG_COUNT;

	[Token(Token = "0x4002100")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string CURRENT_TAG_COUNT;

	[Token(Token = "0x4002101")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string TAG_TARGET;

	[Token(Token = "0x4002102")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string SCOPE_TEXTURE;

	[Token(Token = "0x4002103")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string SCOPE_TEXTURE_COLOR;

	[Token(Token = "0x4002104")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string SCOPE_HUD_COLOR;

	[Token(Token = "0x4002105")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string SCOPE_TRANSFORM;

	[Token(Token = "0x4002106")]
	[FieldOffset(Offset = "0x80")]
	public static readonly string SCOPE_CAMERA;

	[Token(Token = "0x4002107")]
	[FieldOffset(Offset = "0x88")]
	public static readonly string SHOOT;

	[Token(Token = "0x4002108")]
	[FieldOffset(Offset = "0x90")]
	public static readonly string SHOW_SHOOT_BUTTON;

	[Token(Token = "0x4002109")]
	[FieldOffset(Offset = "0x98")]
	public static readonly string SHOW_RELOAD_TOOLTIP;

	[Token(Token = "0x400210A")]
	[FieldOffset(Offset = "0xA0")]
	public static readonly string SET_RELOAD_TOOLTIP_TEXT;

	[Token(Token = "0x400210B")]
	[FieldOffset(Offset = "0xA8")]
	public static readonly string SHOW_HOLD_BREATH_TOOLTIP;

	[Token(Token = "0x400210C")]
	[FieldOffset(Offset = "0xB0")]
	public static readonly string SET_HOLD_BREATH_TOOLTIP_TEXT;

	[Token(Token = "0x400210D")]
	[FieldOffset(Offset = "0xB8")]
	public static readonly string POWER_UPS_DISPLAYED;

	[Token(Token = "0x400210E")]
	[FieldOffset(Offset = "0xC0")]
	public static readonly string SHOW_POWER_UP_TOOLTIP;

	[Token(Token = "0x400210F")]
	[FieldOffset(Offset = "0xC8")]
	public static readonly string SET_POWER_UP_TOOLTIP_TEXT;

	[Token(Token = "0x4002110")]
	[FieldOffset(Offset = "0xD0")]
	public static readonly string POWER_UP_TOOLTIP_DISPLAYED;

	[Token(Token = "0x4002111")]
	[FieldOffset(Offset = "0xD8")]
	public static readonly string ONE_USE_ONLY_POWER_UP;

	[Token(Token = "0x4002112")]
	[FieldOffset(Offset = "0xE0")]
	public static readonly string HAS_INFINIT_AMMO;

	[Token(Token = "0x4002113")]
	[FieldOffset(Offset = "0xE8")]
	public static readonly string POWER_UP_HIGHLIGHT_ACTIVE;

	[Token(Token = "0x4002114")]
	[FieldOffset(Offset = "0xF0")]
	public static readonly string AMMO_COUNTER_HIGHLIGHT_ACTIVE;

	[Token(Token = "0x4002115")]
	[FieldOffset(Offset = "0xF8")]
	public static readonly string POWER_UP_TOOLTIP_INDEX;

	[Token(Token = "0x4002116")]
	[FieldOffset(Offset = "0x100")]
	public static readonly string RELOAD_ENABLED;

	[Token(Token = "0x4002117")]
	[FieldOffset(Offset = "0x108")]
	public static readonly string REQUEST_POWER_UPS_GRID_RESTORE;

	[Token(Token = "0x4002118")]
	[FieldOffset(Offset = "0x110")]
	public static readonly string POWERUP_GAME_OBJECTS;

	[Token(Token = "0x4002119")]
	[FieldOffset(Offset = "0x118")]
	public static readonly string HIDE_NO_AMMO_VISUALS;

	[Token(Token = "0x400211A")]
	[FieldOffset(Offset = "0x48")]
	public bool ShowReloadButton;

	[Token(Token = "0x400211B")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "ClampAttribute", RVA = "0x5B828C", Offset = "0x5B828C")]
	public float LowAmmoPercentageTreshold;

	[Token(Token = "0x400211C")]
	[FieldOffset(Offset = "0x50")]
	public float PulseLowAmmoDuration;

	[Token(Token = "0x400211D")]
	[FieldOffset(Offset = "0x58")]
	private LazyTexture2D _scopeTexture;

	[NonSerialized]
	[Token(Token = "0x400211E")]
	[FieldOffset(Offset = "0x60")]
	private bool _isInScope;

	[NonSerialized]
	[Token(Token = "0x400211F")]
	[FieldOffset(Offset = "0x61")]
	private bool _showReloadWarning;

	[NonSerialized]
	[Token(Token = "0x4002120")]
	[FieldOffset(Offset = "0x64")]
	private int _maxAmmunitionCount;

	[NonSerialized]
	[Token(Token = "0x4002121")]
	[FieldOffset(Offset = "0x68")]
	private int _currentAmmunitionCount;

	[NonSerialized]
	[Token(Token = "0x4002122")]
	[FieldOffset(Offset = "0x6C")]
	private bool _isReloading;

	[NonSerialized]
	[Token(Token = "0x4002123")]
	[FieldOffset(Offset = "0x6D")]
	private bool _reload;

	[NonSerialized]
	[Token(Token = "0x4002124")]
	[FieldOffset(Offset = "0x70")]
	private int _maxTagCount;

	[NonSerialized]
	[Token(Token = "0x4002125")]
	[FieldOffset(Offset = "0x74")]
	private int _currentTagCount;

	[NonSerialized]
	[Token(Token = "0x4002126")]
	[FieldOffset(Offset = "0x78")]
	private Transform _tagTarget;

	[NonSerialized]
	[Token(Token = "0x4002127")]
	[FieldOffset(Offset = "0x80")]
	private Color _scopeTextureColor;

	[NonSerialized]
	[Token(Token = "0x4002128")]
	[FieldOffset(Offset = "0x90")]
	private Color _scopeHUDColor;

	[NonSerialized]
	[Token(Token = "0x4002129")]
	[FieldOffset(Offset = "0xA0")]
	private Transform _scopeTransform;

	[NonSerialized]
	[Token(Token = "0x400212A")]
	[FieldOffset(Offset = "0xA8")]
	private Camera _scopeCamera;

	[NonSerialized]
	[Token(Token = "0x400212B")]
	[FieldOffset(Offset = "0xB0")]
	private bool _shoot;

	[NonSerialized]
	[Token(Token = "0x400212C")]
	[FieldOffset(Offset = "0xB1")]
	private bool _showShootButton;

	[NonSerialized]
	[Token(Token = "0x400212D")]
	[FieldOffset(Offset = "0xB2")]
	private bool _showReloadTooltip;

	[NonSerialized]
	[Token(Token = "0x400212E")]
	[FieldOffset(Offset = "0xB8")]
	private string _setReloadTooltipText;

	[NonSerialized]
	[Token(Token = "0x400212F")]
	[FieldOffset(Offset = "0xC0")]
	private bool _showHoldBreathTooltip;

	[NonSerialized]
	[Token(Token = "0x4002130")]
	[FieldOffset(Offset = "0xC8")]
	private string _setHoldBreathTooltipText;

	[NonSerialized]
	[Token(Token = "0x4002131")]
	[FieldOffset(Offset = "0xD0")]
	private bool _powerUpsDisplayed;

	[NonSerialized]
	[Token(Token = "0x4002132")]
	[FieldOffset(Offset = "0xD1")]
	private bool _showPowerUPTooltip;

	[NonSerialized]
	[Token(Token = "0x4002133")]
	[FieldOffset(Offset = "0xD8")]
	private string _setPowerUpTooltipText;

	[NonSerialized]
	[Token(Token = "0x4002134")]
	[FieldOffset(Offset = "0xE0")]
	private bool _powerUpTooltipDisplayed;

	[NonSerialized]
	[Token(Token = "0x4002135")]
	[FieldOffset(Offset = "0xE8")]
	private string _oneUseOnlyPowerUp;

	[NonSerialized]
	[Token(Token = "0x4002136")]
	[FieldOffset(Offset = "0xF0")]
	private bool _hasInfinitAmmo;

	[NonSerialized]
	[Token(Token = "0x4002137")]
	[FieldOffset(Offset = "0xF1")]
	private bool _powerUpHighlightActive;

	[NonSerialized]
	[Token(Token = "0x4002138")]
	[FieldOffset(Offset = "0xF2")]
	private bool _ammoCounterHighlightActive;

	[NonSerialized]
	[Token(Token = "0x4002139")]
	[FieldOffset(Offset = "0xF4")]
	private int _powerupTooltipIndex;

	[NonSerialized]
	[Token(Token = "0x400213A")]
	[FieldOffset(Offset = "0xF8")]
	private bool _reloadEnabled;

	[NonSerialized]
	[Token(Token = "0x400213B")]
	[FieldOffset(Offset = "0xF9")]
	private bool _requestPowerUpsGridRestore;

	[NonSerialized]
	[Token(Token = "0x400213C")]
	[FieldOffset(Offset = "0x100")]
	private List<GameObject> _powerUpGameObjects;

	[NonSerialized]
	[Token(Token = "0x400213D")]
	[FieldOffset(Offset = "0x108")]
	private bool _hideNoAmmoVisuals;

	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x988C3C", Offset = "0x988C3C", VA = "0x988C3C", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x98A160", Offset = "0x98A160", VA = "0x98A160")]
	public WeaponHUDModel()
	{
	}

	[Token(Token = "0x60026D6")]
	[Address(RVA = "0x98A644", Offset = "0x98A644", VA = "0x98A644")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CAC0", Offset = "0x61CAC0")]
	private bool _003CBindAllVariables_003Eb__72_0()
	{
		return default(bool);
	}

	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x98A64C", Offset = "0x98A64C", VA = "0x98A64C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CAD0", Offset = "0x61CAD0")]
	private void _003CBindAllVariables_003Eb__72_1(bool a)
	{
	}

	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x98A658", Offset = "0x98A658", VA = "0x98A658")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CAE0", Offset = "0x61CAE0")]
	private bool _003CBindAllVariables_003Eb__72_2()
	{
		return default(bool);
	}

	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x98A660", Offset = "0x98A660", VA = "0x98A660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CAF0", Offset = "0x61CAF0")]
	private void _003CBindAllVariables_003Eb__72_3(bool a)
	{
	}

	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x98A66C", Offset = "0x98A66C", VA = "0x98A66C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB00", Offset = "0x61CB00")]
	private bool _003CBindAllVariables_003Eb__72_4()
	{
		return default(bool);
	}

	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x98A674", Offset = "0x98A674", VA = "0x98A674")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB10", Offset = "0x61CB10")]
	private void _003CBindAllVariables_003Eb__72_5(bool a)
	{
	}

	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x98A680", Offset = "0x98A680", VA = "0x98A680")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB20", Offset = "0x61CB20")]
	private int _003CBindAllVariables_003Eb__72_6()
	{
		return default(int);
	}

	[Token(Token = "0x60026DD")]
	[Address(RVA = "0x98A688", Offset = "0x98A688", VA = "0x98A688")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB30", Offset = "0x61CB30")]
	private void _003CBindAllVariables_003Eb__72_7(int a)
	{
	}

	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x98A690", Offset = "0x98A690", VA = "0x98A690")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB40", Offset = "0x61CB40")]
	private int _003CBindAllVariables_003Eb__72_8()
	{
		return default(int);
	}

	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x98A698", Offset = "0x98A698", VA = "0x98A698")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB50", Offset = "0x61CB50")]
	private void _003CBindAllVariables_003Eb__72_9(int a)
	{
	}

	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x98A6A0", Offset = "0x98A6A0", VA = "0x98A6A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB60", Offset = "0x61CB60")]
	private float _003CBindAllVariables_003Eb__72_10()
	{
		return default(float);
	}

	[Token(Token = "0x60026E1")]
	[Address(RVA = "0x98A6A8", Offset = "0x98A6A8", VA = "0x98A6A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB70", Offset = "0x61CB70")]
	private float _003CBindAllVariables_003Eb__72_11()
	{
		return default(float);
	}

	[Token(Token = "0x60026E2")]
	[Address(RVA = "0x98A6B0", Offset = "0x98A6B0", VA = "0x98A6B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB80", Offset = "0x61CB80")]
	private bool _003CBindAllVariables_003Eb__72_12()
	{
		return default(bool);
	}

	[Token(Token = "0x60026E3")]
	[Address(RVA = "0x98A6B8", Offset = "0x98A6B8", VA = "0x98A6B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CB90", Offset = "0x61CB90")]
	private void _003CBindAllVariables_003Eb__72_13(bool a)
	{
	}

	[Token(Token = "0x60026E4")]
	[Address(RVA = "0x98A6C4", Offset = "0x98A6C4", VA = "0x98A6C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CBA0", Offset = "0x61CBA0")]
	private bool _003CBindAllVariables_003Eb__72_14()
	{
		return default(bool);
	}

	[Token(Token = "0x60026E5")]
	[Address(RVA = "0x98A6CC", Offset = "0x98A6CC", VA = "0x98A6CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CBB0", Offset = "0x61CBB0")]
	private void _003CBindAllVariables_003Eb__72_15(bool a)
	{
	}

	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x98A6D8", Offset = "0x98A6D8", VA = "0x98A6D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CBC0", Offset = "0x61CBC0")]
	private int _003CBindAllVariables_003Eb__72_16()
	{
		return default(int);
	}

	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x98A6E0", Offset = "0x98A6E0", VA = "0x98A6E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CBD0", Offset = "0x61CBD0")]
	private void _003CBindAllVariables_003Eb__72_17(int a)
	{
	}

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0x98A6E8", Offset = "0x98A6E8", VA = "0x98A6E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CBE0", Offset = "0x61CBE0")]
	private int _003CBindAllVariables_003Eb__72_18()
	{
		return default(int);
	}

	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x98A6F0", Offset = "0x98A6F0", VA = "0x98A6F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CBF0", Offset = "0x61CBF0")]
	private void _003CBindAllVariables_003Eb__72_19(int a)
	{
	}

	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x98A6F8", Offset = "0x98A6F8", VA = "0x98A6F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC00", Offset = "0x61CC00")]
	private object _003CBindAllVariables_003Eb__72_20()
	{
		return null;
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x98A700", Offset = "0x98A700", VA = "0x98A700")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC10", Offset = "0x61CC10")]
	private void _003CBindAllVariables_003Eb__72_21(object a)
	{
	}

	[Token(Token = "0x60026EC")]
	[Address(RVA = "0x98A78C", Offset = "0x98A78C", VA = "0x98A78C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC20", Offset = "0x61CC20")]
	private object _003CBindAllVariables_003Eb__72_22()
	{
		return null;
	}

	[Token(Token = "0x60026ED")]
	[Address(RVA = "0x98A794", Offset = "0x98A794", VA = "0x98A794")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC30", Offset = "0x61CC30")]
	private void _003CBindAllVariables_003Eb__72_23(object a)
	{
	}

	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x98A820", Offset = "0x98A820", VA = "0x98A820")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC40", Offset = "0x61CC40")]
	private object _003CBindAllVariables_003Eb__72_24()
	{
		return null;
	}

	[Token(Token = "0x60026EF")]
	[Address(RVA = "0x98A880", Offset = "0x98A880", VA = "0x98A880")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC50", Offset = "0x61CC50")]
	private void _003CBindAllVariables_003Eb__72_25(object a)
	{
	}

	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x98A904", Offset = "0x98A904", VA = "0x98A904")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC60", Offset = "0x61CC60")]
	private object _003CBindAllVariables_003Eb__72_26()
	{
		return null;
	}

	[Token(Token = "0x60026F1")]
	[Address(RVA = "0x98A964", Offset = "0x98A964", VA = "0x98A964")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC70", Offset = "0x61CC70")]
	private void _003CBindAllVariables_003Eb__72_27(object a)
	{
	}

	[Token(Token = "0x60026F2")]
	[Address(RVA = "0x98A9E8", Offset = "0x98A9E8", VA = "0x98A9E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC80", Offset = "0x61CC80")]
	private object _003CBindAllVariables_003Eb__72_28()
	{
		return null;
	}

	[Token(Token = "0x60026F3")]
	[Address(RVA = "0x98A9F0", Offset = "0x98A9F0", VA = "0x98A9F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CC90", Offset = "0x61CC90")]
	private void _003CBindAllVariables_003Eb__72_29(object a)
	{
	}

	[Token(Token = "0x60026F4")]
	[Address(RVA = "0x98AA7C", Offset = "0x98AA7C", VA = "0x98AA7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CCA0", Offset = "0x61CCA0")]
	private object _003CBindAllVariables_003Eb__72_30()
	{
		return null;
	}

	[Token(Token = "0x60026F5")]
	[Address(RVA = "0x98AA84", Offset = "0x98AA84", VA = "0x98AA84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CCB0", Offset = "0x61CCB0")]
	private void _003CBindAllVariables_003Eb__72_31(object a)
	{
	}

	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x98AAF4", Offset = "0x98AAF4", VA = "0x98AAF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CCC0", Offset = "0x61CCC0")]
	private bool _003CBindAllVariables_003Eb__72_32()
	{
		return default(bool);
	}

	[Token(Token = "0x60026F7")]
	[Address(RVA = "0x98AAFC", Offset = "0x98AAFC", VA = "0x98AAFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CCD0", Offset = "0x61CCD0")]
	private void _003CBindAllVariables_003Eb__72_33(bool a)
	{
	}

	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x98AB08", Offset = "0x98AB08", VA = "0x98AB08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CCE0", Offset = "0x61CCE0")]
	private bool _003CBindAllVariables_003Eb__72_34()
	{
		return default(bool);
	}

	[Token(Token = "0x60026F9")]
	[Address(RVA = "0x98AB10", Offset = "0x98AB10", VA = "0x98AB10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CCF0", Offset = "0x61CCF0")]
	private void _003CBindAllVariables_003Eb__72_35(bool a)
	{
	}

	[Token(Token = "0x60026FA")]
	[Address(RVA = "0x98AB1C", Offset = "0x98AB1C", VA = "0x98AB1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD00", Offset = "0x61CD00")]
	private bool _003CBindAllVariables_003Eb__72_36()
	{
		return default(bool);
	}

	[Token(Token = "0x60026FB")]
	[Address(RVA = "0x98AB24", Offset = "0x98AB24", VA = "0x98AB24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD10", Offset = "0x61CD10")]
	private void _003CBindAllVariables_003Eb__72_37(bool a)
	{
	}

	[Token(Token = "0x60026FC")]
	[Address(RVA = "0x98AB30", Offset = "0x98AB30", VA = "0x98AB30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD20", Offset = "0x61CD20")]
	private object _003CBindAllVariables_003Eb__72_38()
	{
		return null;
	}

	[Token(Token = "0x60026FD")]
	[Address(RVA = "0x98AB38", Offset = "0x98AB38", VA = "0x98AB38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD30", Offset = "0x61CD30")]
	private void _003CBindAllVariables_003Eb__72_39(object a)
	{
	}

	[Token(Token = "0x60026FE")]
	[Address(RVA = "0x98ABA8", Offset = "0x98ABA8", VA = "0x98ABA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD40", Offset = "0x61CD40")]
	private bool _003CBindAllVariables_003Eb__72_40()
	{
		return default(bool);
	}

	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x98ABB0", Offset = "0x98ABB0", VA = "0x98ABB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD50", Offset = "0x61CD50")]
	private void _003CBindAllVariables_003Eb__72_41(bool a)
	{
	}

	[Token(Token = "0x6002700")]
	[Address(RVA = "0x98ABBC", Offset = "0x98ABBC", VA = "0x98ABBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD60", Offset = "0x61CD60")]
	private object _003CBindAllVariables_003Eb__72_42()
	{
		return null;
	}

	[Token(Token = "0x6002701")]
	[Address(RVA = "0x98ABC4", Offset = "0x98ABC4", VA = "0x98ABC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD70", Offset = "0x61CD70")]
	private void _003CBindAllVariables_003Eb__72_43(object a)
	{
	}

	[Token(Token = "0x6002702")]
	[Address(RVA = "0x98AC34", Offset = "0x98AC34", VA = "0x98AC34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD80", Offset = "0x61CD80")]
	private bool _003CBindAllVariables_003Eb__72_44()
	{
		return default(bool);
	}

	[Token(Token = "0x6002703")]
	[Address(RVA = "0x98AC3C", Offset = "0x98AC3C", VA = "0x98AC3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CD90", Offset = "0x61CD90")]
	private void _003CBindAllVariables_003Eb__72_45(bool a)
	{
	}

	[Token(Token = "0x6002704")]
	[Address(RVA = "0x98AC48", Offset = "0x98AC48", VA = "0x98AC48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CDA0", Offset = "0x61CDA0")]
	private bool _003CBindAllVariables_003Eb__72_46()
	{
		return default(bool);
	}

	[Token(Token = "0x6002705")]
	[Address(RVA = "0x98AC50", Offset = "0x98AC50", VA = "0x98AC50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CDB0", Offset = "0x61CDB0")]
	private void _003CBindAllVariables_003Eb__72_47(bool a)
	{
	}

	[Token(Token = "0x6002706")]
	[Address(RVA = "0x98AC5C", Offset = "0x98AC5C", VA = "0x98AC5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CDC0", Offset = "0x61CDC0")]
	private object _003CBindAllVariables_003Eb__72_48()
	{
		return null;
	}

	[Token(Token = "0x6002707")]
	[Address(RVA = "0x98AC64", Offset = "0x98AC64", VA = "0x98AC64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CDD0", Offset = "0x61CDD0")]
	private void _003CBindAllVariables_003Eb__72_49(object a)
	{
	}

	[Token(Token = "0x6002708")]
	[Address(RVA = "0x98ACD4", Offset = "0x98ACD4", VA = "0x98ACD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CDE0", Offset = "0x61CDE0")]
	private bool _003CBindAllVariables_003Eb__72_50()
	{
		return default(bool);
	}

	[Token(Token = "0x6002709")]
	[Address(RVA = "0x98ACDC", Offset = "0x98ACDC", VA = "0x98ACDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CDF0", Offset = "0x61CDF0")]
	private void _003CBindAllVariables_003Eb__72_51(bool a)
	{
	}

	[Token(Token = "0x600270A")]
	[Address(RVA = "0x98ACE8", Offset = "0x98ACE8", VA = "0x98ACE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE00", Offset = "0x61CE00")]
	private object _003CBindAllVariables_003Eb__72_52()
	{
		return null;
	}

	[Token(Token = "0x600270B")]
	[Address(RVA = "0x98ACF0", Offset = "0x98ACF0", VA = "0x98ACF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE10", Offset = "0x61CE10")]
	private void _003CBindAllVariables_003Eb__72_53(object a)
	{
	}

	[Token(Token = "0x600270C")]
	[Address(RVA = "0x98AD60", Offset = "0x98AD60", VA = "0x98AD60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE20", Offset = "0x61CE20")]
	private bool _003CBindAllVariables_003Eb__72_54()
	{
		return default(bool);
	}

	[Token(Token = "0x600270D")]
	[Address(RVA = "0x98AD68", Offset = "0x98AD68", VA = "0x98AD68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE30", Offset = "0x61CE30")]
	private void _003CBindAllVariables_003Eb__72_55(bool a)
	{
	}

	[Token(Token = "0x600270E")]
	[Address(RVA = "0x98AD74", Offset = "0x98AD74", VA = "0x98AD74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE40", Offset = "0x61CE40")]
	private bool _003CBindAllVariables_003Eb__72_56()
	{
		return default(bool);
	}

	[Token(Token = "0x600270F")]
	[Address(RVA = "0x98AD7C", Offset = "0x98AD7C", VA = "0x98AD7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE50", Offset = "0x61CE50")]
	private void _003CBindAllVariables_003Eb__72_57(bool a)
	{
	}

	[Token(Token = "0x6002710")]
	[Address(RVA = "0x98AD88", Offset = "0x98AD88", VA = "0x98AD88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE60", Offset = "0x61CE60")]
	private bool _003CBindAllVariables_003Eb__72_58()
	{
		return default(bool);
	}

	[Token(Token = "0x6002711")]
	[Address(RVA = "0x98AD90", Offset = "0x98AD90", VA = "0x98AD90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE70", Offset = "0x61CE70")]
	private void _003CBindAllVariables_003Eb__72_59(bool a)
	{
	}

	[Token(Token = "0x6002712")]
	[Address(RVA = "0x98AD9C", Offset = "0x98AD9C", VA = "0x98AD9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE80", Offset = "0x61CE80")]
	private int _003CBindAllVariables_003Eb__72_60()
	{
		return default(int);
	}

	[Token(Token = "0x6002713")]
	[Address(RVA = "0x98ADA4", Offset = "0x98ADA4", VA = "0x98ADA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CE90", Offset = "0x61CE90")]
	private void _003CBindAllVariables_003Eb__72_61(int a)
	{
	}

	[Token(Token = "0x6002714")]
	[Address(RVA = "0x98ADAC", Offset = "0x98ADAC", VA = "0x98ADAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CEA0", Offset = "0x61CEA0")]
	private bool _003CBindAllVariables_003Eb__72_62()
	{
		return default(bool);
	}

	[Token(Token = "0x6002715")]
	[Address(RVA = "0x98ADB4", Offset = "0x98ADB4", VA = "0x98ADB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CEB0", Offset = "0x61CEB0")]
	private void _003CBindAllVariables_003Eb__72_63(bool a)
	{
	}

	[Token(Token = "0x6002716")]
	[Address(RVA = "0x98ADC0", Offset = "0x98ADC0", VA = "0x98ADC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CEC0", Offset = "0x61CEC0")]
	private bool _003CBindAllVariables_003Eb__72_64()
	{
		return default(bool);
	}

	[Token(Token = "0x6002717")]
	[Address(RVA = "0x98ADC8", Offset = "0x98ADC8", VA = "0x98ADC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CED0", Offset = "0x61CED0")]
	private void _003CBindAllVariables_003Eb__72_65(bool a)
	{
	}

	[Token(Token = "0x6002718")]
	[Address(RVA = "0x98ADD4", Offset = "0x98ADD4", VA = "0x98ADD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CEE0", Offset = "0x61CEE0")]
	private object _003CBindAllVariables_003Eb__72_66()
	{
		return null;
	}

	[Token(Token = "0x6002719")]
	[Address(RVA = "0x98ADDC", Offset = "0x98ADDC", VA = "0x98ADDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CEF0", Offset = "0x61CEF0")]
	private void _003CBindAllVariables_003Eb__72_67(object a)
	{
	}

	[Token(Token = "0x600271A")]
	[Address(RVA = "0x98AE68", Offset = "0x98AE68", VA = "0x98AE68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CF00", Offset = "0x61CF00")]
	private bool _003CBindAllVariables_003Eb__72_68()
	{
		return default(bool);
	}

	[Token(Token = "0x600271B")]
	[Address(RVA = "0x98AE70", Offset = "0x98AE70", VA = "0x98AE70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61CF10", Offset = "0x61CF10")]
	private void _003CBindAllVariables_003Eb__72_69(bool b)
	{
	}
}

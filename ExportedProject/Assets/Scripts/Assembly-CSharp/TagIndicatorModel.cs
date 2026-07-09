using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005FA")]
public class TagIndicatorModel : DataModel
{
	[Token(Token = "0x4002058")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string IS_CLICKABLE;

	[Token(Token = "0x4002059")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string SHOW_FILLED_BORDER;

	[Token(Token = "0x400205A")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string SHOW_BORDER;

	[Token(Token = "0x400205B")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string SHOW_FILLED_BACKGROUND;

	[Token(Token = "0x400205C")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string SHOW_BACKGROUND;

	[Token(Token = "0x400205D")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string SHOW_ICON;

	[Token(Token = "0x400205E")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string ICON_NAME;

	[Token(Token = "0x400205F")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string ICON_COLOR;

	[Token(Token = "0x4002060")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string HAS_COLOR_OVERRIDE;

	[Token(Token = "0x4002061")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string IDENTIFICATION_PROGRESS;

	[Token(Token = "0x4002062")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string LOOK_AT_TRANSFORM;

	[Token(Token = "0x4002063")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string IS_IN_SCOPE;

	[Token(Token = "0x4002064")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string SHOW_MANUAL_TAG_ICON;

	[Token(Token = "0x4002065")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string ALERT_LEVEL;

	[Token(Token = "0x4002066")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string IS_SCARED;

	[Token(Token = "0x4002067")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string DONT_SHOW_ALERT_ICON;

	[NonSerialized]
	[Token(Token = "0x4002068")]
	[FieldOffset(Offset = "0x48")]
	private bool _isClickable;

	[NonSerialized]
	[Token(Token = "0x4002069")]
	[FieldOffset(Offset = "0x49")]
	private bool _showFilledBorder;

	[NonSerialized]
	[Token(Token = "0x400206A")]
	[FieldOffset(Offset = "0x4A")]
	private bool _showBorder;

	[NonSerialized]
	[Token(Token = "0x400206B")]
	[FieldOffset(Offset = "0x4B")]
	private bool _showFilledBackground;

	[NonSerialized]
	[Token(Token = "0x400206C")]
	[FieldOffset(Offset = "0x4C")]
	private bool _showBackground;

	[NonSerialized]
	[Token(Token = "0x400206D")]
	[FieldOffset(Offset = "0x4D")]
	private bool _showIcon;

	[NonSerialized]
	[Token(Token = "0x400206E")]
	[FieldOffset(Offset = "0x50")]
	private string _iconName;

	[NonSerialized]
	[Token(Token = "0x400206F")]
	[FieldOffset(Offset = "0x58")]
	private Color _iconColor;

	[NonSerialized]
	[Token(Token = "0x4002070")]
	[FieldOffset(Offset = "0x68")]
	private bool _hasColorOverride;

	[NonSerialized]
	[Token(Token = "0x4002071")]
	[FieldOffset(Offset = "0x6C")]
	private float _identificationProgress;

	[NonSerialized]
	[Token(Token = "0x4002072")]
	[FieldOffset(Offset = "0x70")]
	private Transform _lookAtTransform;

	[NonSerialized]
	[Token(Token = "0x4002073")]
	[FieldOffset(Offset = "0x78")]
	private bool _isInScope;

	[NonSerialized]
	[Token(Token = "0x4002074")]
	[FieldOffset(Offset = "0x79")]
	private bool _showManualTagIcon;

	[NonSerialized]
	[Token(Token = "0x4002075")]
	[FieldOffset(Offset = "0x7C")]
	private AlertLevel _alertLevel;

	[NonSerialized]
	[Token(Token = "0x4002076")]
	[FieldOffset(Offset = "0x80")]
	private bool _isScared;

	[NonSerialized]
	[Token(Token = "0x4002077")]
	[FieldOffset(Offset = "0x81")]
	private bool _dontShowAlertIcon;

	[Token(Token = "0x6002646")]
	[Address(RVA = "0xB4B5A4", Offset = "0xB4B5A4", VA = "0xB4B5A4", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002647")]
	[Address(RVA = "0xB4BFE8", Offset = "0xB4BFE8", VA = "0xB4BFE8")]
	public TagIndicatorModel()
	{
	}

	[Token(Token = "0x6002649")]
	[Address(RVA = "0xB4C238", Offset = "0xB4C238", VA = "0xB4C238")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C3B0", Offset = "0x61C3B0")]
	private bool _003CBindAllVariables_003Eb__32_0()
	{
		return default(bool);
	}

	[Token(Token = "0x600264A")]
	[Address(RVA = "0xB4C240", Offset = "0xB4C240", VA = "0xB4C240")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C3C0", Offset = "0x61C3C0")]
	private void _003CBindAllVariables_003Eb__32_1(bool b)
	{
	}

	[Token(Token = "0x600264B")]
	[Address(RVA = "0xB4C24C", Offset = "0xB4C24C", VA = "0xB4C24C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C3D0", Offset = "0x61C3D0")]
	private bool _003CBindAllVariables_003Eb__32_2()
	{
		return default(bool);
	}

	[Token(Token = "0x600264C")]
	[Address(RVA = "0xB4C254", Offset = "0xB4C254", VA = "0xB4C254")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C3E0", Offset = "0x61C3E0")]
	private void _003CBindAllVariables_003Eb__32_3(bool b)
	{
	}

	[Token(Token = "0x600264D")]
	[Address(RVA = "0xB4C260", Offset = "0xB4C260", VA = "0xB4C260")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C3F0", Offset = "0x61C3F0")]
	private bool _003CBindAllVariables_003Eb__32_4()
	{
		return default(bool);
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0xB4C268", Offset = "0xB4C268", VA = "0xB4C268")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C400", Offset = "0x61C400")]
	private void _003CBindAllVariables_003Eb__32_5(bool b)
	{
	}

	[Token(Token = "0x600264F")]
	[Address(RVA = "0xB4C274", Offset = "0xB4C274", VA = "0xB4C274")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C410", Offset = "0x61C410")]
	private bool _003CBindAllVariables_003Eb__32_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002650")]
	[Address(RVA = "0xB4C27C", Offset = "0xB4C27C", VA = "0xB4C27C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C420", Offset = "0x61C420")]
	private void _003CBindAllVariables_003Eb__32_7(bool b)
	{
	}

	[Token(Token = "0x6002651")]
	[Address(RVA = "0xB4C288", Offset = "0xB4C288", VA = "0xB4C288")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C430", Offset = "0x61C430")]
	private bool _003CBindAllVariables_003Eb__32_8()
	{
		return default(bool);
	}

	[Token(Token = "0x6002652")]
	[Address(RVA = "0xB4C290", Offset = "0xB4C290", VA = "0xB4C290")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C440", Offset = "0x61C440")]
	private void _003CBindAllVariables_003Eb__32_9(bool b)
	{
	}

	[Token(Token = "0x6002653")]
	[Address(RVA = "0xB4C29C", Offset = "0xB4C29C", VA = "0xB4C29C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C450", Offset = "0x61C450")]
	private bool _003CBindAllVariables_003Eb__32_10()
	{
		return default(bool);
	}

	[Token(Token = "0x6002654")]
	[Address(RVA = "0xB4C2A4", Offset = "0xB4C2A4", VA = "0xB4C2A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C460", Offset = "0x61C460")]
	private void _003CBindAllVariables_003Eb__32_11(bool b)
	{
	}

	[Token(Token = "0x6002655")]
	[Address(RVA = "0xB4C2B0", Offset = "0xB4C2B0", VA = "0xB4C2B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C470", Offset = "0x61C470")]
	private object _003CBindAllVariables_003Eb__32_12()
	{
		return null;
	}

	[Token(Token = "0x6002656")]
	[Address(RVA = "0xB4C2B8", Offset = "0xB4C2B8", VA = "0xB4C2B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C480", Offset = "0x61C480")]
	private void _003CBindAllVariables_003Eb__32_13(object b)
	{
	}

	[Token(Token = "0x6002657")]
	[Address(RVA = "0xB4C328", Offset = "0xB4C328", VA = "0xB4C328")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C490", Offset = "0x61C490")]
	private object _003CBindAllVariables_003Eb__32_14()
	{
		return null;
	}

	[Token(Token = "0x6002658")]
	[Address(RVA = "0xB4C388", Offset = "0xB4C388", VA = "0xB4C388")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C4A0", Offset = "0x61C4A0")]
	private void _003CBindAllVariables_003Eb__32_15(object c)
	{
	}

	[Token(Token = "0x6002659")]
	[Address(RVA = "0xB4C40C", Offset = "0xB4C40C", VA = "0xB4C40C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C4B0", Offset = "0x61C4B0")]
	private bool _003CBindAllVariables_003Eb__32_16()
	{
		return default(bool);
	}

	[Token(Token = "0x600265A")]
	[Address(RVA = "0xB4C414", Offset = "0xB4C414", VA = "0xB4C414")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C4C0", Offset = "0x61C4C0")]
	private void _003CBindAllVariables_003Eb__32_17(bool b)
	{
	}

	[Token(Token = "0x600265B")]
	[Address(RVA = "0xB4C420", Offset = "0xB4C420", VA = "0xB4C420")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C4D0", Offset = "0x61C4D0")]
	private float _003CBindAllVariables_003Eb__32_18()
	{
		return default(float);
	}

	[Token(Token = "0x600265C")]
	[Address(RVA = "0xB4C428", Offset = "0xB4C428", VA = "0xB4C428")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C4E0", Offset = "0x61C4E0")]
	private void _003CBindAllVariables_003Eb__32_19(float f)
	{
	}

	[Token(Token = "0x600265D")]
	[Address(RVA = "0xB4C430", Offset = "0xB4C430", VA = "0xB4C430")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C4F0", Offset = "0x61C4F0")]
	private object _003CBindAllVariables_003Eb__32_20()
	{
		return null;
	}

	[Token(Token = "0x600265E")]
	[Address(RVA = "0xB4C438", Offset = "0xB4C438", VA = "0xB4C438")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C500", Offset = "0x61C500")]
	private void _003CBindAllVariables_003Eb__32_21(object t)
	{
	}

	[Token(Token = "0x600265F")]
	[Address(RVA = "0xB4C4C4", Offset = "0xB4C4C4", VA = "0xB4C4C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C510", Offset = "0x61C510")]
	private bool _003CBindAllVariables_003Eb__32_22()
	{
		return default(bool);
	}

	[Token(Token = "0x6002660")]
	[Address(RVA = "0xB4C4CC", Offset = "0xB4C4CC", VA = "0xB4C4CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C520", Offset = "0x61C520")]
	private void _003CBindAllVariables_003Eb__32_23(bool b)
	{
	}

	[Token(Token = "0x6002661")]
	[Address(RVA = "0xB4C4D8", Offset = "0xB4C4D8", VA = "0xB4C4D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C530", Offset = "0x61C530")]
	private bool _003CBindAllVariables_003Eb__32_24()
	{
		return default(bool);
	}

	[Token(Token = "0x6002662")]
	[Address(RVA = "0xB4C4E0", Offset = "0xB4C4E0", VA = "0xB4C4E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C540", Offset = "0x61C540")]
	private void _003CBindAllVariables_003Eb__32_25(bool b)
	{
	}

	[Token(Token = "0x6002663")]
	[Address(RVA = "0xB4C4EC", Offset = "0xB4C4EC", VA = "0xB4C4EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C550", Offset = "0x61C550")]
	private int _003CBindAllVariables_003Eb__32_26()
	{
		return default(int);
	}

	[Token(Token = "0x6002664")]
	[Address(RVA = "0xB4C4F4", Offset = "0xB4C4F4", VA = "0xB4C4F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C560", Offset = "0x61C560")]
	private void _003CBindAllVariables_003Eb__32_27(int a)
	{
	}

	[Token(Token = "0x6002665")]
	[Address(RVA = "0xB4C4FC", Offset = "0xB4C4FC", VA = "0xB4C4FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C570", Offset = "0x61C570")]
	private bool _003CBindAllVariables_003Eb__32_28()
	{
		return default(bool);
	}

	[Token(Token = "0x6002666")]
	[Address(RVA = "0xB4C504", Offset = "0xB4C504", VA = "0xB4C504")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C580", Offset = "0x61C580")]
	private void _003CBindAllVariables_003Eb__32_29(bool a)
	{
	}

	[Token(Token = "0x6002667")]
	[Address(RVA = "0xB4C510", Offset = "0xB4C510", VA = "0xB4C510")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C590", Offset = "0x61C590")]
	private bool _003CBindAllVariables_003Eb__32_30()
	{
		return default(bool);
	}

	[Token(Token = "0x6002668")]
	[Address(RVA = "0xB4C518", Offset = "0xB4C518", VA = "0xB4C518")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61C5A0", Offset = "0x61C5A0")]
	private void _003CBindAllVariables_003Eb__32_31(bool b)
	{
	}
}

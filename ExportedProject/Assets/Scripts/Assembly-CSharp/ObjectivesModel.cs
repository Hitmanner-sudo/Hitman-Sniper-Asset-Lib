using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C8")]
public class ObjectivesModel : DataModel
{
	[Token(Token = "0x4001F0B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string TWEEN_COLORS_ANIMATION_CURVE;

	[Token(Token = "0x4001F0C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string OBJECTIVES_HIGHLIGHT_ACTIVE;

	[Token(Token = "0x4001F0D")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string SHOW_TOOLTIP;

	[Token(Token = "0x4001F0E")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string TOOLTIP_TEXT;

	[Token(Token = "0x4001F0F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AnimationCurve _tweenColorsAnimationCurve;

	[NonSerialized]
	[Token(Token = "0x4001F10")]
	[FieldOffset(Offset = "0x50")]
	private bool _objectivesHighlightActive;

	[NonSerialized]
	[Token(Token = "0x4001F11")]
	[FieldOffset(Offset = "0x51")]
	private bool _showTooltip;

	[NonSerialized]
	[Token(Token = "0x4001F12")]
	[FieldOffset(Offset = "0x58")]
	private string _tooltipText;

	[Token(Token = "0x60024C2")]
	[Address(RVA = "0x9EDB08", Offset = "0x9EDB08", VA = "0x9EDB08", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x9EDE48", Offset = "0x9EDE48", VA = "0x9EDE48")]
	public ObjectivesModel()
	{
	}

	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x9EDF18", Offset = "0x9EDF18", VA = "0x9EDF18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B5C0", Offset = "0x61B5C0")]
	private object _003CBindAllVariables_003Eb__8_0()
	{
		return null;
	}

	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x9EDF20", Offset = "0x9EDF20", VA = "0x9EDF20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B5D0", Offset = "0x61B5D0")]
	private void _003CBindAllVariables_003Eb__8_1(object a)
	{
	}

	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x9EDFAC", Offset = "0x9EDFAC", VA = "0x9EDFAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B5E0", Offset = "0x61B5E0")]
	private bool _003CBindAllVariables_003Eb__8_2()
	{
		return default(bool);
	}

	[Token(Token = "0x60024C8")]
	[Address(RVA = "0x9EDFB4", Offset = "0x9EDFB4", VA = "0x9EDFB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B5F0", Offset = "0x61B5F0")]
	private void _003CBindAllVariables_003Eb__8_3(bool a)
	{
	}

	[Token(Token = "0x60024C9")]
	[Address(RVA = "0x9EDFC0", Offset = "0x9EDFC0", VA = "0x9EDFC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B600", Offset = "0x61B600")]
	private bool _003CBindAllVariables_003Eb__8_4()
	{
		return default(bool);
	}

	[Token(Token = "0x60024CA")]
	[Address(RVA = "0x9EDFC8", Offset = "0x9EDFC8", VA = "0x9EDFC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B610", Offset = "0x61B610")]
	private void _003CBindAllVariables_003Eb__8_5(bool a)
	{
	}

	[Token(Token = "0x60024CB")]
	[Address(RVA = "0x9EDFD4", Offset = "0x9EDFD4", VA = "0x9EDFD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B620", Offset = "0x61B620")]
	private object _003CBindAllVariables_003Eb__8_6()
	{
		return null;
	}

	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x9EDFDC", Offset = "0x9EDFDC", VA = "0x9EDFDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B630", Offset = "0x61B630")]
	private void _003CBindAllVariables_003Eb__8_7(object a)
	{
	}
}

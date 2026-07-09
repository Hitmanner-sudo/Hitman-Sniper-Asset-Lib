using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A5")]
public class UIProgressBar : UIWidgetContainer
{
	[Token(Token = "0x4002B0A")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Background;

	[Token(Token = "0x4002B0B")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget Foreground;

	[Token(Token = "0x4002B0C")]
	[FieldOffset(Offset = "0x28")]
	public List<Transform> RightEdgeElements;

	[Token(Token = "0x4002B0D")]
	[FieldOffset(Offset = "0x30")]
	public float ForegroundWidthOffset;

	[Token(Token = "0x4002B0E")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "ClampAttribute", RVA = "0x5BAAFC", Offset = "0x5BAAFC")]
	public float MinValue;

	[Token(Token = "0x4002B0F")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "ClampAttribute", RVA = "0x5BAB14", Offset = "0x5BAB14")]
	public float MaxValue;

	[Token(Token = "0x4002B10")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BAB2C", Offset = "0x5BAB2C")]
	private float _003C_value_003Ek__BackingField;

	[Token(Token = "0x17000677")]
	protected float _value
	{
		[Token(Token = "0x6003287")]
		[Address(RVA = "0x142CAB0", Offset = "0x142CAB0", VA = "0x142CAB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x622600", Offset = "0x622600")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6003288")]
		[Address(RVA = "0x142CAB8", Offset = "0x142CAB8", VA = "0x142CAB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x622610", Offset = "0x622610")]
		set
		{
		}
	}

	[Token(Token = "0x17000678")]
	public virtual float Value
	{
		[Token(Token = "0x6003289")]
		[Address(RVA = "0x142CAC0", Offset = "0x142CAC0", VA = "0x142CAC0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600328A")]
		[Address(RVA = "0x142CAC8", Offset = "0x142CAC8", VA = "0x142CAC8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x600328B")]
	[Address(RVA = "0x142CDE0", Offset = "0x142CDE0", VA = "0x142CDE0")]
	public UIProgressBar()
	{
	}
}

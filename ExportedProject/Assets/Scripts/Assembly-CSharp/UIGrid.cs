using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x590EE8", Offset = "0x590EE8")]
[ExecuteInEditMode]
public class UIGrid : UIWidgetContainer
{
	[Token(Token = "0x2000031")]
	public enum Arrangement
	{
		[Token(Token = "0x40000E2")]
		Horizontal = 0,
		[Token(Token = "0x40000E3")]
		Vertical = 1
	}

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x18")]
	public bool Centered;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x19")]
	public bool UseCenterAlignment;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x1A")]
	public bool Reversed;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x1B")]
	public bool ReversePosition;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x1C")]
	public bool KeepOffsets;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x1D")]
	public bool SkipRepositionOnStart;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x20")]
	public Arrangement arrangement;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x24")]
	public int maxPerLine;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x28")]
	public float cellWidth;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x2C")]
	public bool AutoWidth;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x30")]
	public float cellHeight;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x34")]
	public float paddingX;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x38")]
	public float paddingY;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x3C")]
	public bool repositionNow;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x3D")]
	public bool sorted;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x3E")]
	public bool hideInactive;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x40")]
	public Func<Transform, bool> ValidateChildFunction;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x48")]
	private bool mStarted;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x17A18B8", Offset = "0x17A18B8", VA = "0x17A18B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x17A1CFC", Offset = "0x17A1CFC", VA = "0x17A1CFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x17A1D14", Offset = "0x17A1D14", VA = "0x17A1D14")]
	public static int SortByName(Transform a, Transform b)
	{
		return default(int);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x17A1D60", Offset = "0x17A1D60", VA = "0x17A1D60")]
	public int ChildCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x17A18D4", Offset = "0x17A18D4", VA = "0x17A18D4")]
	public void Reposition(bool immediately = false)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x17A1EA4", Offset = "0x17A1EA4", VA = "0x17A1EA4")]
	private List<Transform> GetChildList()
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x17A2088", Offset = "0x17A2088", VA = "0x17A2088")]
	private void SetPosition(Transform t, float x, int y)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x17A2190", Offset = "0x17A2190", VA = "0x17A2190")]
	public UIGrid()
	{
	}
}

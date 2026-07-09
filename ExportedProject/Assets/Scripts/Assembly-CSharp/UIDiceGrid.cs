using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A0")]
[ExecuteInEditMode]
public class UIDiceGrid : UIWidget
{
	[Token(Token = "0x4002AF1")]
	[FieldOffset(Offset = "0xF4")]
	public bool Reversed;

	[Token(Token = "0x4002AF2")]
	[FieldOffset(Offset = "0xF8")]
	public float cellWidth;

	[Token(Token = "0x4002AF3")]
	[FieldOffset(Offset = "0xFC")]
	public float cellHeight;

	[Token(Token = "0x4002AF4")]
	[FieldOffset(Offset = "0x100")]
	public float StaggerOffsetX;

	[Token(Token = "0x4002AF5")]
	[FieldOffset(Offset = "0x104")]
	public bool repositionNow;

	[Token(Token = "0x4002AF6")]
	[FieldOffset(Offset = "0x105")]
	public bool sorted;

	[Token(Token = "0x4002AF7")]
	[FieldOffset(Offset = "0x106")]
	public bool hideInactive;

	[Token(Token = "0x4002AF8")]
	[FieldOffset(Offset = "0x107")]
	private bool _started;

	[Token(Token = "0x6003273")]
	[Address(RVA = "0x15834F8", Offset = "0x15834F8", VA = "0x15834F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003274")]
	[Address(RVA = "0x1583B70", Offset = "0x1583B70", VA = "0x1583B70", Slot = "18")]
	public override void Update()
	{
	}

	[Token(Token = "0x6003275")]
	[Address(RVA = "0x1583B8C", Offset = "0x1583B8C", VA = "0x1583B8C")]
	public static int SortByName(UIWidget a, UIWidget b)
	{
		return default(int);
	}

	[Token(Token = "0x6003276")]
	[Address(RVA = "0x1583504", Offset = "0x1583504", VA = "0x1583504")]
	public void Reposition()
	{
	}

	[Token(Token = "0x6003277")]
	[Address(RVA = "0x1583BD8", Offset = "0x1583BD8", VA = "0x1583BD8")]
	public UIDiceGrid()
	{
	}
}

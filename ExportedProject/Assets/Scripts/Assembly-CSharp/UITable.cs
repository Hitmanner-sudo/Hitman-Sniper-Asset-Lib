using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000041")]
[Attribute(Name = "AddComponentMenu", RVA = "0x5911B4", Offset = "0x5911B4")]
[ExecuteInEditMode]
public class UITable : UIWidgetContainer
{
	[Token(Token = "0x2000042")]
	public delegate void OnReposition();

	[Token(Token = "0x2000043")]
	public enum Direction
	{
		[Token(Token = "0x400016A")]
		Down = 0,
		[Token(Token = "0x400016B")]
		Up = 1
	}

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x18")]
	public int columns;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x1C")]
	public Direction direction;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x20")]
	public bool sorted;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x21")]
	public bool hideInactive;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x22")]
	public bool keepWithinPanel;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x23")]
	public bool repositionNow;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x28")]
	public OnReposition onReposition;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 padding;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x38")]
	private UIPanel mPanel;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x40")]
	private UIDraggablePanel mDrag;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x48")]
	private bool mStarted;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x50")]
	private List<Transform> mChildren;

	[Token(Token = "0x1700003B")]
	public List<Transform> children
	{
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x116BBAC", Offset = "0x116BBAC", VA = "0x116BBAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x116BB60", Offset = "0x116BB60", VA = "0x116BB60")]
	public static int SortByName(Transform a, Transform b)
	{
		return default(int);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x116BE24", Offset = "0x116BE24", VA = "0x116BE24")]
	private void RepositionVariableSize(List<Transform> children)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x116C45C", Offset = "0x116C45C", VA = "0x116C45C")]
	public void Reposition()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x116C5E8", Offset = "0x116C5E8", VA = "0x116C5E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x116C6BC", Offset = "0x116C6BC", VA = "0x116C6BC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x116C6D0", Offset = "0x116C6D0", VA = "0x116C6D0")]
	public UITable()
	{
	}
}

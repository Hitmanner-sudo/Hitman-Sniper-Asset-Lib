using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000507")]
public class ComboBox
{
	[Token(Token = "0x2000508")]
	public enum ListLocation
	{
		[Token(Token = "0x4001AC1")]
		ListUnder = 0,
		[Token(Token = "0x4001AC2")]
		ListRight = 1
	}

	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x0")]
	private static bool forceToUnShow;

	[Token(Token = "0x4001AB4")]
	[FieldOffset(Offset = "0x4")]
	private static int useControlID;

	[Token(Token = "0x4001AB5")]
	[FieldOffset(Offset = "0x10")]
	private bool isClickedComboButton;

	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x14")]
	private int selectedItemIndex;

	[Token(Token = "0x4001AB7")]
	[FieldOffset(Offset = "0x18")]
	public Rect Rect;

	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x28")]
	public GUIContent buttonContent;

	[Token(Token = "0x4001AB9")]
	[FieldOffset(Offset = "0x30")]
	public GUIContent[] listContent;

	[Token(Token = "0x4001ABA")]
	[FieldOffset(Offset = "0x38")]
	public GUIStyle buttonStyle;

	[Token(Token = "0x4001ABB")]
	[FieldOffset(Offset = "0x40")]
	public GUIStyle boxStyle;

	[Token(Token = "0x4001ABC")]
	[FieldOffset(Offset = "0x48")]
	private GUIStyle listStyle;

	[Token(Token = "0x4001ABD")]
	[FieldOffset(Offset = "0x50")]
	private float listWidth;

	[Token(Token = "0x4001ABE")]
	[FieldOffset(Offset = "0x58")]
	public object UserData;

	[Token(Token = "0x4001ABF")]
	[FieldOffset(Offset = "0x60")]
	public ListLocation listLocation;

	[Token(Token = "0x170004C4")]
	public GUIStyle ListStyle
	{
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x8DB6AC", Offset = "0x8DB6AC", VA = "0x8DB6AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x8DB6B4", Offset = "0x8DB6B4", VA = "0x8DB6B4")]
		set
		{
		}
	}

	[Token(Token = "0x170004C5")]
	public int SelectedItemIndex
	{
		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x8DBBF4", Offset = "0x8DBBF4", VA = "0x8DBBF4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x8DBBFC", Offset = "0x8DBBFC", VA = "0x8DBBFC")]
		set
		{
		}
	}

	[Token(Token = "0x170004C6")]
	public GUIContent SelectedItem
	{
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x8DBC40", Offset = "0x8DBC40", VA = "0x8DBC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004C7")]
	public bool IsClicked
	{
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x8DBC80", Offset = "0x8DBC80", VA = "0x8DBC80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x8DBC88", Offset = "0x8DBC88", VA = "0x8DBC88")]
		set
		{
		}
	}

	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x8DB76C", Offset = "0x8DB76C", VA = "0x8DB76C")]
	public ComboBox(Rect rect, GUIContent buttonContent, GUIContent[] listContent)
	{
	}

	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x8DB7D4", Offset = "0x8DB7D4", VA = "0x8DB7D4")]
	public int Show()
	{
		return default(int);
	}
}

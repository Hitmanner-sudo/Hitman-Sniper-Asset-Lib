using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A5")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591F48", Offset = "0x591F48")]
public class UITextList : MonoBehaviour
{
	[Token(Token = "0x20000A6")]
	public enum Style
	{
		[Token(Token = "0x4000410")]
		Text = 0,
		[Token(Token = "0x4000411")]
		Chat = 1
	}

	[Token(Token = "0x20000A7")]
	protected class Paragraph
	{
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x18")]
		public string[] lines;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xA3E5C0", Offset = "0xA3E5C0", VA = "0xA3E5C0")]
		public Paragraph()
		{
		}
	}

	[Token(Token = "0x4000405")]
	[FieldOffset(Offset = "0x18")]
	public Style style;

	[Token(Token = "0x4000406")]
	[FieldOffset(Offset = "0x20")]
	public UILabel textLabel;

	[Token(Token = "0x4000407")]
	[FieldOffset(Offset = "0x28")]
	public float maxHeight;

	[Token(Token = "0x4000408")]
	[FieldOffset(Offset = "0x2C")]
	public int maxEntries;

	[Token(Token = "0x4000409")]
	[FieldOffset(Offset = "0x30")]
	public bool supportScrollWheel;

	[Token(Token = "0x400040A")]
	[FieldOffset(Offset = "0x38")]
	protected char[] mSeparator;

	[Token(Token = "0x400040B")]
	[FieldOffset(Offset = "0x40")]
	protected List<Paragraph> mParagraphs;

	[Token(Token = "0x400040C")]
	[FieldOffset(Offset = "0x48")]
	protected float mScroll;

	[Token(Token = "0x400040D")]
	[FieldOffset(Offset = "0x4C")]
	protected bool mSelected;

	[Token(Token = "0x400040E")]
	[FieldOffset(Offset = "0x50")]
	protected int mTotalLines;

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x116C764", Offset = "0x116C764", VA = "0x116C764")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x116CB04", Offset = "0x116CB04", VA = "0x116CB04")]
	public void Add(string text)
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x116CB0C", Offset = "0x116CB0C", VA = "0x116CB0C")]
	protected void Add(string text, bool updateVisible)
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x116CD98", Offset = "0x116CD98", VA = "0x116CD98")]
	private void Awake()
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x116CF08", Offset = "0x116CF08", VA = "0x116CF08")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x116C7C0", Offset = "0x116C7C0", VA = "0x116C7C0")]
	protected void UpdateVisibleText()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x116CF14", Offset = "0x116CF14", VA = "0x116CF14")]
	private void OnScroll(float val)
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x116CF80", Offset = "0x116CF80", VA = "0x116CF80")]
	public UITextList()
	{
	}
}

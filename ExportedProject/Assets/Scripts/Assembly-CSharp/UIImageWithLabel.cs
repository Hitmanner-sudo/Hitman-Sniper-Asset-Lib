using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A3")]
[ExecuteInEditMode]
public class UIImageWithLabel : UIWidgetContainer
{
	[Token(Token = "0x4002AFE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x4002AFF")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget Image;

	[Token(Token = "0x4002B00")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget.Pivot Direction;

	[Token(Token = "0x4002B01")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 Offset;

	[Token(Token = "0x4002B02")]
	[FieldOffset(Offset = "0x34")]
	public bool ForceUpdate;

	[Token(Token = "0x4002B03")]
	[FieldOffset(Offset = "0x38")]
	private UIWidget.Pivot _cachedPivot;

	[Token(Token = "0x4002B04")]
	[FieldOffset(Offset = "0x3C")]
	private Vector2 _cachedOffset;

	[Token(Token = "0x17000675")]
	public Color color
	{
		[Token(Token = "0x600327D")]
		[Address(RVA = "0x17A2648", Offset = "0x17A2648", VA = "0x17A2648")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x17A2668", Offset = "0x17A2668", VA = "0x17A2668")]
		set
		{
		}
	}

	[Token(Token = "0x17000676")]
	public Vector2 CenterOffset
	{
		[Token(Token = "0x6003283")]
		[Address(RVA = "0x17A3154", Offset = "0x17A3154", VA = "0x17A3154")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x600327F")]
	[Address(RVA = "0x17A26E0", Offset = "0x17A26E0", VA = "0x17A26E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003280")]
	[Address(RVA = "0x17A26EC", Offset = "0x17A26EC", VA = "0x17A26EC")]
	public void DoUpdateNow()
	{
	}

	[Token(Token = "0x6003281")]
	[Address(RVA = "0x17A2F6C", Offset = "0x17A2F6C", VA = "0x17A2F6C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003282")]
	[Address(RVA = "0x17A2720", Offset = "0x17A2720", VA = "0x17A2720")]
	private void UpdateDirection()
	{
	}

	[Token(Token = "0x6003284")]
	[Address(RVA = "0x17A3264", Offset = "0x17A3264", VA = "0x17A3264")]
	public UIImageWithLabel()
	{
	}
}

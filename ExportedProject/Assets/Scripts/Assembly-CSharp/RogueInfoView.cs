using System;
using Il2CppDummyDll;

[Token(Token = "0x20006C3")]
public class RogueInfoView : View
{
	[Token(Token = "0x40025F9")]
	[FieldOffset(Offset = "0x60")]
	public ButtonHandler SelfButton;

	[Token(Token = "0x40025FA")]
	[FieldOffset(Offset = "0x68")]
	public TweenScale TouchTweenScale;

	[Token(Token = "0x40025FB")]
	[FieldOffset(Offset = "0x70")]
	public UISprite SelectionBar;

	[Token(Token = "0x40025FC")]
	[FieldOffset(Offset = "0x78")]
	public UISprite Picture;

	[NonSerialized]
	[Token(Token = "0x40025FD")]
	[FieldOffset(Offset = "0x80")]
	public RoguesView ParentRoguesView;

	[Token(Token = "0x40025FE")]
	[FieldOffset(Offset = "0x88")]
	private RogueData _data;

	[Token(Token = "0x40025FF")]
	[FieldOffset(Offset = "0x90")]
	private bool _selected;

	[Token(Token = "0x4002600")]
	[FieldOffset(Offset = "0x91")]
	private bool _available;

	[Token(Token = "0x170005BA")]
	public bool Available
	{
		[Token(Token = "0x6002C81")]
		[Address(RVA = "0x972814", Offset = "0x972814", VA = "0x972814")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005BB")]
	public bool IsNew
	{
		[Token(Token = "0x6002C82")]
		[Address(RVA = "0x97281C", Offset = "0x97281C", VA = "0x97281C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005BC")]
	public RogueData Data
	{
		[Token(Token = "0x6002C83")]
		[Address(RVA = "0x972844", Offset = "0x972844", VA = "0x972844")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002C84")]
		[Address(RVA = "0x97284C", Offset = "0x97284C", VA = "0x97284C")]
		set
		{
		}
	}

	[Token(Token = "0x170005BD")]
	public bool Selected
	{
		[Token(Token = "0x6002C85")]
		[Address(RVA = "0x9729A0", Offset = "0x9729A0", VA = "0x9729A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002C86")]
		[Address(RVA = "0x9729A8", Offset = "0x9729A8", VA = "0x9729A8")]
		set
		{
		}
	}

	[Token(Token = "0x6002C87")]
	[Address(RVA = "0x972A94", Offset = "0x972A94", VA = "0x972A94", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002C88")]
	[Address(RVA = "0x972B50", Offset = "0x972B50", VA = "0x972B50", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002C89")]
	[Address(RVA = "0x972898", Offset = "0x972898", VA = "0x972898")]
	private void OnDataChanged()
	{
	}

	[Token(Token = "0x6002C8A")]
	[Address(RVA = "0x9729B4", Offset = "0x9729B4", VA = "0x9729B4")]
	private void OnSelectedChanged()
	{
	}

	[Token(Token = "0x6002C8B")]
	[Address(RVA = "0x972C48", Offset = "0x972C48", VA = "0x972C48")]
	private void OnSelfClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002C8C")]
	[Address(RVA = "0x972EF8", Offset = "0x972EF8", VA = "0x972EF8")]
	public RogueInfoView()
	{
	}
}

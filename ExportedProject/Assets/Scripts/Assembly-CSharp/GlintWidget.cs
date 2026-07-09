using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200078B")]
public class GlintWidget : GameMonoBehaviour
{
	[Token(Token = "0x200078C")]
	public enum Phase
	{
		[Token(Token = "0x4002A84")]
		Move = 0,
		[Token(Token = "0x4002A85")]
		Fade = 1,
		[Token(Token = "0x4002A86")]
		Wait = 2
	}

	[Token(Token = "0x4002A78")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget GlintLeftTarget;

	[Token(Token = "0x4002A79")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget GlintRightTarget;

	[Token(Token = "0x4002A7A")]
	[FieldOffset(Offset = "0x58")]
	public UISprite Glint;

	[Token(Token = "0x4002A7B")]
	[FieldOffset(Offset = "0x60")]
	public float MoveDuration;

	[Token(Token = "0x4002A7C")]
	[FieldOffset(Offset = "0x64")]
	public float FadeDuration;

	[Token(Token = "0x4002A7D")]
	[FieldOffset(Offset = "0x68")]
	public float EndDelay;

	[Token(Token = "0x4002A7E")]
	[FieldOffset(Offset = "0x6C")]
	public float LeftOffset;

	[Token(Token = "0x4002A7F")]
	[FieldOffset(Offset = "0x70")]
	public float MaxAlpha;

	[Token(Token = "0x4002A80")]
	[FieldOffset(Offset = "0x74")]
	public bool ForceClip;

	[Token(Token = "0x4002A81")]
	[FieldOffset(Offset = "0x78")]
	private Phase _currentPhase;

	[Token(Token = "0x4002A82")]
	[FieldOffset(Offset = "0x7C")]
	private float _duration;

	[Token(Token = "0x6003203")]
	[Address(RVA = "0xC82114", Offset = "0xC82114", VA = "0xC82114", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003204")]
	[Address(RVA = "0xC821B8", Offset = "0xC821B8", VA = "0xC821B8")]
	public void Update()
	{
	}

	[Token(Token = "0x6003205")]
	[Address(RVA = "0xC82460", Offset = "0xC82460", VA = "0xC82460")]
	private void UpdateWidth()
	{
	}

	[Token(Token = "0x6003206")]
	[Address(RVA = "0xC82634", Offset = "0xC82634", VA = "0xC82634")]
	public GlintWidget()
	{
	}
}

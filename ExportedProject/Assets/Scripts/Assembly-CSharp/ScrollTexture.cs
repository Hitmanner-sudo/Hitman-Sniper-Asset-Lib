using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000948")]
public class ScrollTexture : MonoBehaviour
{
	[Token(Token = "0x4003258")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5BBC14", Offset = "0x5BBC14")]
	public bool playOnStart;

	[Token(Token = "0x4003259")]
	[FieldOffset(Offset = "0x1C")]
	public float startDelay;

	[Token(Token = "0x400325A")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5BBC4C", Offset = "0x5BBC4C")]
	public bool allMaterials;

	[Token(Token = "0x400325B")]
	[FieldOffset(Offset = "0x24")]
	public int materialIndex;

	[Token(Token = "0x400325C")]
	[FieldOffset(Offset = "0x28")]
	public string textureName;

	[Token(Token = "0x400325D")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5BBC84", Offset = "0x5BBC84")]
	public Vector2 startUV;

	[Token(Token = "0x400325E")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 endUV;

	[Token(Token = "0x400325F")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 uvPerSecond;

	[Token(Token = "0x4003260")]
	[FieldOffset(Offset = "0x48")]
	public bool loopForever;

	[Token(Token = "0x4003261")]
	[FieldOffset(Offset = "0x49")]
	public bool forceUpdate;

	[Token(Token = "0x4003262")]
	[FieldOffset(Offset = "0x4A")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5BBCBC", Offset = "0x5BBCBC")]
	public bool pauseDuringLoop;

	[Token(Token = "0x4003263")]
	[FieldOffset(Offset = "0x4C")]
	public float pauseDuration;

	[Token(Token = "0x4003264")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 pauseUV;

	[Token(Token = "0x4003265")]
	[FieldOffset(Offset = "0x58")]
	private bool _inPause;

	[Token(Token = "0x4003266")]
	[FieldOffset(Offset = "0x5C")]
	private float _pauseEnd;

	[Token(Token = "0x4003267")]
	[FieldOffset(Offset = "0x60")]
	private bool _inPlay;

	[Token(Token = "0x4003268")]
	[FieldOffset(Offset = "0x68")]
	private Renderer _renderer;

	[Token(Token = "0x4003269")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 uvOffset;

	[Token(Token = "0x400326A")]
	[FieldOffset(Offset = "0x78")]
	private Vector2 _startUV;

	[Token(Token = "0x400326B")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 _endUV;

	[Token(Token = "0x400326C")]
	[FieldOffset(Offset = "0x88")]
	private Vector2 _uvPerSecond;

	[Token(Token = "0x6003ABD")]
	[Address(RVA = "0xB67D94", Offset = "0xB67D94", VA = "0xB67D94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003ABE")]
	[Address(RVA = "0xB67DB0", Offset = "0xB67DB0", VA = "0xB67DB0")]
	private void UpdateUV()
	{
	}

	[Token(Token = "0x6003ABF")]
	[Address(RVA = "0xB67F4C", Offset = "0xB67F4C", VA = "0xB67F4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003AC0")]
	[Address(RVA = "0xB67F5C", Offset = "0xB67F5C", VA = "0xB67F5C")]
	public void Play()
	{
	}

	[Token(Token = "0x6003AC1")]
	[Address(RVA = "0xB67FD0", Offset = "0xB67FD0", VA = "0xB67FD0")]
	public void ReversePlay()
	{
	}

	[Token(Token = "0x6003AC2")]
	[Address(RVA = "0xB67FF8", Offset = "0xB67FF8", VA = "0xB67FF8")]
	public void ScrollToEnd()
	{
	}

	[Token(Token = "0x6003AC3")]
	[Address(RVA = "0xB68004", Offset = "0xB68004", VA = "0xB68004")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6003AC4")]
	[Address(RVA = "0xB681AC", Offset = "0xB681AC", VA = "0xB681AC")]
	public ScrollTexture()
	{
	}
}

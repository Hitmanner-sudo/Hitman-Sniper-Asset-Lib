using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000570")]
public class FadeOutTime : MonoBehaviour
{
	[Token(Token = "0x4001CA9")]
	[FieldOffset(Offset = "0x18")]
	public float FadeDelay;

	[Token(Token = "0x4001CAA")]
	[FieldOffset(Offset = "0x1C")]
	public float FadeTime;

	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0x20")]
	public float FadeTo;

	[Token(Token = "0x4001CAC")]
	[FieldOffset(Offset = "0x28")]
	private UIWidget _labelToFade;

	[Token(Token = "0x4001CAD")]
	[FieldOffset(Offset = "0x30")]
	private bool _isFading;

	[Token(Token = "0x4001CAE")]
	[FieldOffset(Offset = "0x38")]
	private GameTimer _timer;

	[Token(Token = "0x600224B")]
	[Address(RVA = "0x951DBC", Offset = "0x951DBC", VA = "0x951DBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600224C")]
	[Address(RVA = "0x951E50", Offset = "0x951E50", VA = "0x951E50")]
	private void Update()
	{
	}

	[Token(Token = "0x600224D")]
	[Address(RVA = "0x951F1C", Offset = "0x951F1C", VA = "0x951F1C")]
	public FadeOutTime()
	{
	}
}

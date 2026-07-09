using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000B0")]
public class RequestChars : MonoBehaviour
{
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x18")]
	public Font font;

	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x20")]
	public string text;

	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x28")]
	public int size;

	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x2C")]
	public FontStyle style;

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x96657C", Offset = "0x96657C", VA = "0x96657C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x966614", Offset = "0x966614", VA = "0x966614")]
	public RequestChars()
	{
	}
}

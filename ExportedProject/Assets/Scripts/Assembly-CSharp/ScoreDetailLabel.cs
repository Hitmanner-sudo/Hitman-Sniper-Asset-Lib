using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000796")]
public class ScoreDetailLabel : MonoBehaviour
{
	[Token(Token = "0x4002ABE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel DescriptionLabel;

	[Token(Token = "0x4002ABF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ScoreLabel;

	[Token(Token = "0x4002AC0")]
	[FieldOffset(Offset = "0x28")]
	public UITweener[] PreScoreDetailTweener;

	[Token(Token = "0x4002AC1")]
	[FieldOffset(Offset = "0x30")]
	public UITweener[] PostScoreDetailTweener;

	[Token(Token = "0x600323E")]
	[Address(RVA = "0xBB7808", Offset = "0xBB7808", VA = "0xBB7808")]
	public ScoreDetailLabel()
	{
	}
}

using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200062C")]
public class SingleCharacterGlow : GameMonoBehaviour
{
	[Token(Token = "0x400221A")]
	[FieldOffset(Offset = "0x48")]
	public UITweener[] GlowOutTweener;

	[Token(Token = "0x400221B")]
	[FieldOffset(Offset = "0x50")]
	public UILabel[] Labels;

	[Token(Token = "0x6002809")]
	[Address(RVA = "0x846020", Offset = "0x846020", VA = "0x846020")]
	public SingleCharacterGlow()
	{
	}
}

using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000763")]
public class TallyScoreItem : View
{
	[Token(Token = "0x40029C0")]
	[FieldOffset(Offset = "0x60")]
	public UILabel Title;

	[Token(Token = "0x40029C1")]
	[FieldOffset(Offset = "0x68")]
	public UILabel Ammount;

	[Token(Token = "0x40029C2")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Bonus;

	[Token(Token = "0x40029C3")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private int _titleAmountPadding;

	[Token(Token = "0x600311C")]
	[Address(RVA = "0xB501F4", Offset = "0xB501F4", VA = "0xB501F4")]
	public void AdjustTitleWidth()
	{
	}

	[Token(Token = "0x600311D")]
	[Address(RVA = "0xB5029C", Offset = "0xB5029C", VA = "0xB5029C")]
	public TallyScoreItem()
	{
	}
}

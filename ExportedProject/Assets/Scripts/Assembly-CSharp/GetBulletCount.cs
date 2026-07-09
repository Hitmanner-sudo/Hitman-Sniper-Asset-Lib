using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000453")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5942D8", Offset = "0x5942D8")]
public class GetBulletCount : FsmStateAction
{
	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6578", Offset = "0x5B6578")]
	public FsmInt CurrentBulletCount;

	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B658C", Offset = "0x5B658C")]
	public FsmInt MaxBulletCount;

	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x105D7AC", Offset = "0x105D7AC", VA = "0x105D7AC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0x105D8D8", Offset = "0x105D8D8", VA = "0x105D8D8")]
	public GetBulletCount()
	{
	}
}

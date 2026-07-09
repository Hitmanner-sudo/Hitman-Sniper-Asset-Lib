using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200044F")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5941A8", Offset = "0x5941A8")]
public class EndGame : FsmStateAction
{
	[Token(Token = "0x40017D8")]
	[FieldOffset(Offset = "0x50")]
	public FsmBool Success;

	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0xE12C5C", Offset = "0xE12C5C", VA = "0xE12C5C", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0xE12C90", Offset = "0xE12C90", VA = "0xE12C90", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A40")]
	[Address(RVA = "0xE12D60", Offset = "0xE12D60", VA = "0xE12D60")]
	public EndGame()
	{
	}
}

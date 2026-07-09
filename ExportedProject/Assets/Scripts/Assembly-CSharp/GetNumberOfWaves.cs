using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20000AD")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5921C0", Offset = "0x5921C0")]
public class GetNumberOfWaves : FsmStateAction
{
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B02B8", Offset = "0x5B02B8")]
	public ZombieProperties ZombieProperties;

	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0x58")]
	public FsmInt OutNumWaves;

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x1066E84", Offset = "0x1066E84", VA = "0x1066E84", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x1066F88", Offset = "0x1066F88", VA = "0x1066F88")]
	public GetNumberOfWaves()
	{
	}
}

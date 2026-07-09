using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20000AE")]
public class SendEventImmediate : FsmStateAction
{
	[Token(Token = "0x4000430")]
	[FieldOffset(Offset = "0x50")]
	public FsmEventTarget Target;

	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent EventToSend;

	[Token(Token = "0x6000566")]
	[Address(RVA = "0xB70D74", Offset = "0xB70D74", VA = "0xB70D74", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0xB70DB0", Offset = "0xB70DB0", VA = "0xB70DB0", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0xB70DB8", Offset = "0xB70DB8", VA = "0xB70DB8")]
	public SendEventImmediate()
	{
	}
}

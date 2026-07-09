using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000467")]
public class PlayerIsReloadingCheck : FsmStateAction
{
	[Token(Token = "0x4001823")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent IsReloading;

	[Token(Token = "0x4001824")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent NotReloading;

	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0xB8B288", Offset = "0xB8B288", VA = "0xB8B288", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0xB8B36C", Offset = "0xB8B36C", VA = "0xB8B36C")]
	public PlayerIsReloadingCheck()
	{
	}
}

using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200047A")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594B40", Offset = "0x594B40")]
public class ZombieGetSurvivorInfo : FsmStateAction
{
	[Token(Token = "0x400185F")]
	[FieldOffset(Offset = "0x50")]
	public FsmInt InSurvivorIndex;

	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0x58")]
	public FsmEvent active;

	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent inactive;

	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x8831B8", Offset = "0x8831B8", VA = "0x8831B8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x883350", Offset = "0x883350", VA = "0x883350")]
	public ZombieGetSurvivorInfo()
	{
	}
}

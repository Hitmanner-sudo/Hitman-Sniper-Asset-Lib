using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200047B")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594B78", Offset = "0x594B78")]
public class ZombieSetSurvivorInfo : FsmStateAction
{
	[Token(Token = "0x4001862")]
	[FieldOffset(Offset = "0x50")]
	public FsmBool InSurvivorIsDead;

	[Token(Token = "0x4001863")]
	[FieldOffset(Offset = "0x58")]
	public FsmInt InSurvivorIndex;

	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x885D38", Offset = "0x885D38", VA = "0x885D38", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x885D40", Offset = "0x885D40", VA = "0x885D40")]
	public ZombieSetSurvivorInfo()
	{
	}
}

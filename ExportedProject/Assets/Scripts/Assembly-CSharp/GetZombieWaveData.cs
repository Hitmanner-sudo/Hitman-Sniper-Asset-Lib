using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003FD")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5939EC", Offset = "0x5939EC")]
public class GetZombieWaveData : FsmStateAction
{
	[Token(Token = "0x4001649")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B54EC", Offset = "0x5B54EC")]
	public FsmInt OutZombieWave;

	[Token(Token = "0x600186E")]
	[Address(RVA = "0xC81E6C", Offset = "0xC81E6C", VA = "0xC81E6C", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600186F")]
	[Address(RVA = "0xC81FE4", Offset = "0xC81FE4", VA = "0xC81FE4")]
	public GetZombieWaveData()
	{
	}
}

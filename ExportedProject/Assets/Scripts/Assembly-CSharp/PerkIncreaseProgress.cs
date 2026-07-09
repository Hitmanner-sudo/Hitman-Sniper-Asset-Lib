using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000463")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594678", Offset = "0x594678")]
public class PerkIncreaseProgress : FsmStateAction
{
	[Token(Token = "0x400181A")]
	[FieldOffset(Offset = "0x50")]
	public Perk Perk;

	[Token(Token = "0x400181B")]
	[FieldOffset(Offset = "0x58")]
	public FsmInt InIncreaseProgressValue;

	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x8FE0F8", Offset = "0x8FE0F8", VA = "0x8FE0F8", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A91")]
	[Address(RVA = "0x8FE19C", Offset = "0x8FE19C", VA = "0x8FE19C")]
	public PerkIncreaseProgress()
	{
	}
}

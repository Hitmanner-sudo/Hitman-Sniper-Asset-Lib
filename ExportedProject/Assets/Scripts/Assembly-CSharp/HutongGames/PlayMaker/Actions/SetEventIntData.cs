using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001178")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7C6C", Offset = "0x5A7C6C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7C6C", Offset = "0x5A7C6C")]
	public class SetEventIntData : FsmStateAction
	{
		[Token(Token = "0x40052F7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F894C", Offset = "0x5F894C")]
		public FsmInt intData;

		[Token(Token = "0x6006719")]
		[Address(RVA = "0x10397C4", Offset = "0x10397C4", VA = "0x10397C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600671A")]
		[Address(RVA = "0x10397CC", Offset = "0x10397CC", VA = "0x10397CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600671B")]
		[Address(RVA = "0x103985C", Offset = "0x103985C", VA = "0x103985C")]
		public SetEventIntData()
		{
		}
	}
}

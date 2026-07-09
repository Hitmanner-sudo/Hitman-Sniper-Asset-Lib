using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F5D0", Offset = "0x59F5D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F5D0", Offset = "0x59F5D0")]
	public class GetTagCount : FsmStateAction
	{
		[Token(Token = "0x4004ABC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7A10", Offset = "0x5D7A10")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7A10", Offset = "0x5D7A10")]
		public FsmString tag;

		[Token(Token = "0x4004ABD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7A60", Offset = "0x5D7A60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7A60", Offset = "0x5D7A60")]
		public FsmInt storeResult;

		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0xC80114", Offset = "0xC80114", VA = "0xC80114", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0xC80168", Offset = "0xC80168", VA = "0xC80168", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0xC801C4", Offset = "0xC801C4", VA = "0xC801C4")]
		public GetTagCount()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F68")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CE58", Offset = "0x59CE58")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CE58", Offset = "0x59CE58")]
	public class Comment : FsmStateAction
	{
		[Token(Token = "0x40048C9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D04BC", Offset = "0x5D04BC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D04BC", Offset = "0x5D04BC")]
		public string comment;

		[Token(Token = "0x6005E18")]
		[Address(RVA = "0x8DBDB8", Offset = "0x8DBDB8", VA = "0x8DBDB8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E19")]
		[Address(RVA = "0x8DBE04", Offset = "0x8DBE04", VA = "0x8DBE04", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0x8DBE0C", Offset = "0x8DBE0C", VA = "0x8DBE0C")]
		public Comment()
		{
		}
	}
}

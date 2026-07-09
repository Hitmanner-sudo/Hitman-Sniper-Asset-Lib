using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001048")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1610", Offset = "0x5A1610")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1610", Offset = "0x5A1610")]
	public class BoolFlip : FsmStateAction
	{
		[Token(Token = "0x4004C7B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF128", Offset = "0x5DF128")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF128", Offset = "0x5DF128")]
		[RequiredField]
		public FsmBool boolVariable;

		[Token(Token = "0x6006184")]
		[Address(RVA = "0xA7F4B0", Offset = "0xA7F4B0", VA = "0xA7F4B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006185")]
		[Address(RVA = "0xA7F4B8", Offset = "0xA7F4B8", VA = "0xA7F4B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006186")]
		[Address(RVA = "0xA7F500", Offset = "0xA7F500", VA = "0xA7F500")]
		public BoolFlip()
		{
		}
	}
}

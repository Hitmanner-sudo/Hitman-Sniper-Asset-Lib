using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F07")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B100", Offset = "0x59B100")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B100", Offset = "0x59B100")]
	public class GetScreenWidth : FsmStateAction
	{
		[Token(Token = "0x400470D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9468", Offset = "0x5C9468")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9468", Offset = "0x5C9468")]
		[RequiredField]
		public FsmFloat storeScreenWidth;

		[Token(Token = "0x400470E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C94C8", Offset = "0x5C94C8")]
		public bool everyFrame;

		[Token(Token = "0x6005C77")]
		[Address(RVA = "0xC7EADC", Offset = "0xC7EADC", VA = "0xC7EADC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C78")]
		[Address(RVA = "0xC7EAE8", Offset = "0xC7EAE8", VA = "0xC7EAE8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C79")]
		[Address(RVA = "0xC7EB3C", Offset = "0xC7EB3C", VA = "0xC7EB3C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005C7A")]
		[Address(RVA = "0xC7EB70", Offset = "0xC7EB70", VA = "0xC7EB70")]
		public GetScreenWidth()
		{
		}
	}
}

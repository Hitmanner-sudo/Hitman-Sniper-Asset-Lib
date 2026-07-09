using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200118F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A89B4", Offset = "0x5A89B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A89B4", Offset = "0x5A89B4")]
	public class GetSubstring : FsmStateAction
	{
		[Token(Token = "0x400538B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA5FC", Offset = "0x5FA5FC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA5FC", Offset = "0x5FA5FC")]
		public FsmString stringVariable;

		[Token(Token = "0x400538C")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA65C", Offset = "0x5FA65C")]
		public FsmInt startIndex;

		[Token(Token = "0x400538D")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA6A8", Offset = "0x5FA6A8")]
		public FsmInt length;

		[Token(Token = "0x400538E")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA6F4", Offset = "0x5FA6F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA6F4", Offset = "0x5FA6F4")]
		public FsmString storeResult;

		[Token(Token = "0x400538F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA754", Offset = "0x5FA754")]
		public bool everyFrame;

		[Token(Token = "0x6006788")]
		[Address(RVA = "0xC7FD38", Offset = "0xC7FD38", VA = "0xC7FD38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006789")]
		[Address(RVA = "0xC7FD7C", Offset = "0xC7FD7C", VA = "0xC7FD7C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600678A")]
		[Address(RVA = "0xC7FE44", Offset = "0xC7FE44", VA = "0xC7FE44", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600678B")]
		[Address(RVA = "0xC7FDB8", Offset = "0xC7FDB8", VA = "0xC7FDB8")]
		private void DoGetSubstring()
		{
		}

		[Token(Token = "0x600678C")]
		[Address(RVA = "0xC7FE48", Offset = "0xC7FE48", VA = "0xC7FE48")]
		public GetSubstring()
		{
		}
	}
}

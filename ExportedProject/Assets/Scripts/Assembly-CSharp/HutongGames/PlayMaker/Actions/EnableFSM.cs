using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001147")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A64EC", Offset = "0x5A64EC")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A64EC", Offset = "0x5A64EC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A64EC", Offset = "0x5A64EC")]
	public class EnableFSM : FsmStateAction
	{
		[Token(Token = "0x4005201")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F57DC", Offset = "0x5F57DC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005202")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5828", Offset = "0x5F5828")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5828", Offset = "0x5F5828")]
		public FsmString fsmName;

		[Token(Token = "0x4005203")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5878", Offset = "0x5F5878")]
		public FsmBool enable;

		[Token(Token = "0x4005204")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F58B0", Offset = "0x5F58B0")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005205")]
		[FieldOffset(Offset = "0x70")]
		private PlayMakerFSM fsmComponent;

		[Token(Token = "0x600663C")]
		[Address(RVA = "0xE0D58C", Offset = "0xE0D58C", VA = "0xE0D58C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600663D")]
		[Address(RVA = "0xE0D604", Offset = "0xE0D604", VA = "0xE0D604", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600663E")]
		[Address(RVA = "0xE0D62C", Offset = "0xE0D62C", VA = "0xE0D62C")]
		private void DoEnableFSM()
		{
		}

		[Token(Token = "0x600663F")]
		[Address(RVA = "0xE0D86C", Offset = "0xE0D86C", VA = "0xE0D86C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006640")]
		[Address(RVA = "0xE0D92C", Offset = "0xE0D92C", VA = "0xE0D92C")]
		public EnableFSM()
		{
		}
	}
}

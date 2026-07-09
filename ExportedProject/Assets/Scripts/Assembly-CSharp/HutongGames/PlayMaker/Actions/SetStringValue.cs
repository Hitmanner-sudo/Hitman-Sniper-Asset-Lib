using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001191")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8A54", Offset = "0x5A8A54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8A54", Offset = "0x5A8A54")]
	public class SetStringValue : FsmStateAction
	{
		[Token(Token = "0x4005393")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA8D0", Offset = "0x5FA8D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA8D0", Offset = "0x5FA8D0")]
		public FsmString stringVariable;

		[Token(Token = "0x4005394")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA930", Offset = "0x5FA930")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA930", Offset = "0x5FA930")]
		public FsmString stringValue;

		[Token(Token = "0x4005395")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA980", Offset = "0x5FA980")]
		public bool everyFrame;

		[Token(Token = "0x6006791")]
		[Address(RVA = "0x83B14C", Offset = "0x83B14C", VA = "0x83B14C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006792")]
		[Address(RVA = "0x83B158", Offset = "0x83B158", VA = "0x83B158", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006793")]
		[Address(RVA = "0x83B1E0", Offset = "0x83B1E0", VA = "0x83B1E0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006794")]
		[Address(RVA = "0x83B1AC", Offset = "0x83B1AC", VA = "0x83B1AC")]
		private void DoSetStringValue()
		{
		}

		[Token(Token = "0x6006795")]
		[Address(RVA = "0x83B214", Offset = "0x83B214", VA = "0x83B214")]
		public SetStringValue()
		{
		}
	}
}

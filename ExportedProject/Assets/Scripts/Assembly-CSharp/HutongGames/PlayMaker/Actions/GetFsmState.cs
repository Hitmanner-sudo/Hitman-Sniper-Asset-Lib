using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200115D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7084", Offset = "0x5A7084")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7084", Offset = "0x5A7084")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A7084", Offset = "0x5A7084")]
	public class GetFsmState : FsmStateAction
	{
		[Token(Token = "0x4005274")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7180", Offset = "0x5F7180")]
		public PlayMakerFSM fsmComponent;

		[Token(Token = "0x4005275")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F71B8", Offset = "0x5F71B8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005276")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F71F0", Offset = "0x5F71F0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F71F0", Offset = "0x5F71F0")]
		public FsmString fsmName;

		[Token(Token = "0x4005277")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F7240", Offset = "0x5F7240")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7240", Offset = "0x5F7240")]
		public FsmString storeResult;

		[Token(Token = "0x4005278")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F72A0", Offset = "0x5F72A0")]
		public bool everyFrame;

		[Token(Token = "0x4005279")]
		[FieldOffset(Offset = "0x78")]
		private PlayMakerFSM fsm;

		[Token(Token = "0x6006695")]
		[Address(RVA = "0x106242C", Offset = "0x106242C", VA = "0x106242C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006696")]
		[Address(RVA = "0x1062488", Offset = "0x1062488", VA = "0x1062488", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006697")]
		[Address(RVA = "0x1062668", Offset = "0x1062668", VA = "0x1062668", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006698")]
		[Address(RVA = "0x10624C4", Offset = "0x10624C4", VA = "0x10624C4")]
		private void DoGetFsmState()
		{
		}

		[Token(Token = "0x6006699")]
		[Address(RVA = "0x106266C", Offset = "0x106266C", VA = "0x106266C")]
		public GetFsmState()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001092")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2C50", Offset = "0x5A2C50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2C50", Offset = "0x5A2C50")]
	public class GetJointBreak2dInfo : FsmStateAction
	{
		[Token(Token = "0x4004DFB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5688", Offset = "0x5E5688")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5E5688", Offset = "0x5E5688")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5688", Offset = "0x5E5688")]
		public FsmObject brokenJoint;

		[Token(Token = "0x4004DFC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5720", Offset = "0x5E5720")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5720", Offset = "0x5E5720")]
		public FsmVector2 reactionForce;

		[Token(Token = "0x4004DFD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5770", Offset = "0x5E5770")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5770", Offset = "0x5E5770")]
		public FsmFloat reactionForceMagnitude;

		[Token(Token = "0x4004DFE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E57C0", Offset = "0x5E57C0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E57C0", Offset = "0x5E57C0")]
		public FsmFloat reactionTorque;

		[Token(Token = "0x6006302")]
		[Address(RVA = "0x1063854", Offset = "0x1063854", VA = "0x1063854", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006303")]
		[Address(RVA = "0x1063860", Offset = "0x1063860", VA = "0x1063860")]
		private void StoreInfo()
		{
		}

		[Token(Token = "0x6006304")]
		[Address(RVA = "0x1063980", Offset = "0x1063980", VA = "0x1063980", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006305")]
		[Address(RVA = "0x10639A8", Offset = "0x10639A8", VA = "0x10639A8")]
		public GetJointBreak2dInfo()
		{
		}
	}
}

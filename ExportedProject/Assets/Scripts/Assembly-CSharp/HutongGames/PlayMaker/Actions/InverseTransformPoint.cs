using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9094", Offset = "0x5A9094")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9094", Offset = "0x5A9094")]
	public class InverseTransformPoint : FsmStateAction
	{
		[Token(Token = "0x4005415")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC408", Offset = "0x5FC408")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005416")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC454", Offset = "0x5FC454")]
		public FsmVector3 worldPosition;

		[Token(Token = "0x4005417")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FC4A0", Offset = "0x5FC4A0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC4A0", Offset = "0x5FC4A0")]
		public FsmVector3 storeResult;

		[Token(Token = "0x4005418")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC500", Offset = "0x5FC500")]
		public bool everyFrame;

		[Token(Token = "0x60067F1")]
		[Address(RVA = "0xB1BB88", Offset = "0xB1BB88", VA = "0xB1BB88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067F2")]
		[Address(RVA = "0xB1BB98", Offset = "0xB1BB98", VA = "0xB1BB98", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067F3")]
		[Address(RVA = "0xB1BCB4", Offset = "0xB1BCB4", VA = "0xB1BCB4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067F4")]
		[Address(RVA = "0xB1BBD4", Offset = "0xB1BBD4", VA = "0xB1BBD4")]
		private void DoInverseTransformPoint()
		{
		}

		[Token(Token = "0x60067F5")]
		[Address(RVA = "0xB1BCB8", Offset = "0xB1BCB8", VA = "0xB1BCB8")]
		public InverseTransformPoint()
		{
		}
	}
}

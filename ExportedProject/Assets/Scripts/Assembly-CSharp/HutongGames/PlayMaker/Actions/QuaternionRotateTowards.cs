using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A42FC", Offset = "0x5A42FC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A42FC", Offset = "0x5A42FC")]
	public class QuaternionRotateTowards : QuaternionBaseAction
	{
		[Token(Token = "0x4004F75")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBD08", Offset = "0x5EBD08")]
		[RequiredField]
		public FsmQuaternion fromQuaternion;

		[Token(Token = "0x4004F76")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBD54", Offset = "0x5EBD54")]
		public FsmQuaternion toQuaternion;

		[Token(Token = "0x4004F77")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBDA0", Offset = "0x5EBDA0")]
		[RequiredField]
		public FsmFloat maxDegreesDelta;

		[Token(Token = "0x4004F78")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EBDEC", Offset = "0x5EBDEC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBDEC", Offset = "0x5EBDEC")]
		public FsmQuaternion storeResult;

		[Token(Token = "0x6006454")]
		[Address(RVA = "0xB3D96C", Offset = "0xB3D96C", VA = "0xB3D96C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006455")]
		[Address(RVA = "0xB3DA18", Offset = "0xB3DA18", VA = "0xB3DA18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006456")]
		[Address(RVA = "0xB3DB08", Offset = "0xB3DB08", VA = "0xB3DB08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006457")]
		[Address(RVA = "0xB3DB18", Offset = "0xB3DB18", VA = "0xB3DB18", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006458")]
		[Address(RVA = "0xB3DB2C", Offset = "0xB3DB2C", VA = "0xB3DB2C", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006459")]
		[Address(RVA = "0xB3DA54", Offset = "0xB3DA54", VA = "0xB3DA54")]
		private void DoQuatRotateTowards()
		{
		}

		[Token(Token = "0x600645A")]
		[Address(RVA = "0xB3DB40", Offset = "0xB3DB40", VA = "0xB3DB40")]
		public QuaternionRotateTowards()
		{
		}
	}
}

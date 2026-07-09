using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011A7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9044", Offset = "0x5A9044")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9044", Offset = "0x5A9044")]
	public class InverseTransformDirection : FsmStateAction
	{
		[Token(Token = "0x4005411")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC2D8", Offset = "0x5FC2D8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005412")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC324", Offset = "0x5FC324")]
		public FsmVector3 worldDirection;

		[Token(Token = "0x4005413")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC370", Offset = "0x5FC370")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FC370", Offset = "0x5FC370")]
		public FsmVector3 storeResult;

		[Token(Token = "0x4005414")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FC3D0", Offset = "0x5FC3D0")]
		public bool everyFrame;

		[Token(Token = "0x60067EC")]
		[Address(RVA = "0xB1BA50", Offset = "0xB1BA50", VA = "0xB1BA50", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067ED")]
		[Address(RVA = "0xB1BA60", Offset = "0xB1BA60", VA = "0xB1BA60", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067EE")]
		[Address(RVA = "0xB1BB7C", Offset = "0xB1BB7C", VA = "0xB1BB7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067EF")]
		[Address(RVA = "0xB1BA9C", Offset = "0xB1BA9C", VA = "0xB1BA9C")]
		private void DoInverseTransformDirection()
		{
		}

		[Token(Token = "0x60067F0")]
		[Address(RVA = "0xB1BB80", Offset = "0xB1BB80", VA = "0xB1BB80")]
		public InverseTransformDirection()
		{
		}
	}
}

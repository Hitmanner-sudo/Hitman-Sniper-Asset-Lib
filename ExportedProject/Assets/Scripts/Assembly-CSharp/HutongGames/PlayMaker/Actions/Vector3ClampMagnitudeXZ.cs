using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001275")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACDB4", Offset = "0x5ACDB4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACDB4", Offset = "0x5ACDB4")]
	public class Vector3ClampMagnitudeXZ : FsmStateAction
	{
		[Token(Token = "0x4005852")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B2C0", Offset = "0x60B2C0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B2C0", Offset = "0x60B2C0")]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005853")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B320", Offset = "0x60B320")]
		[RequiredField]
		public FsmFloat maxLength;

		[Token(Token = "0x4005854")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B36C", Offset = "0x60B36C")]
		public bool everyFrame;

		[Token(Token = "0x6006BD8")]
		[Address(RVA = "0x13C7C2C", Offset = "0x13C7C2C", VA = "0x13C7C2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BD9")]
		[Address(RVA = "0x13C7C38", Offset = "0x13C7C38", VA = "0x13C7C38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BDA")]
		[Address(RVA = "0x13C7D0C", Offset = "0x13C7D0C", VA = "0x13C7D0C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BDB")]
		[Address(RVA = "0x13C7C74", Offset = "0x13C7C74", VA = "0x13C7C74")]
		private void DoVector3ClampMagnitudeXZ()
		{
		}

		[Token(Token = "0x6006BDC")]
		[Address(RVA = "0x13C7D10", Offset = "0x13C7D10", VA = "0x13C7D10")]
		public Vector3ClampMagnitudeXZ()
		{
		}
	}
}

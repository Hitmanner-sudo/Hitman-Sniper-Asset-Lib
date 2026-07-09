using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001272")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACCC4", Offset = "0x5ACCC4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACCC4", Offset = "0x5ACCC4")]
	public class Vector3Add : FsmStateAction
	{
		[Token(Token = "0x4005845")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AF48", Offset = "0x60AF48")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60AF48", Offset = "0x60AF48")]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005846")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AFA8", Offset = "0x60AFA8")]
		[RequiredField]
		public FsmVector3 addVector;

		[Token(Token = "0x4005847")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AFF4", Offset = "0x60AFF4")]
		public bool everyFrame;

		[Token(Token = "0x4005848")]
		[FieldOffset(Offset = "0x61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B02C", Offset = "0x60B02C")]
		public bool perSecond;

		[Token(Token = "0x6006BC9")]
		[Address(RVA = "0x13C7880", Offset = "0x13C7880", VA = "0x13C7880", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BCA")]
		[Address(RVA = "0x13C78F4", Offset = "0x13C78F4", VA = "0x13C78F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BCB")]
		[Address(RVA = "0x13C79DC", Offset = "0x13C79DC", VA = "0x13C79DC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BCC")]
		[Address(RVA = "0x13C7930", Offset = "0x13C7930", VA = "0x13C7930")]
		private void DoVector3Add()
		{
		}

		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0x13C79E0", Offset = "0x13C79E0", VA = "0x13C79E0")]
		public Vector3Add()
		{
		}
	}
}

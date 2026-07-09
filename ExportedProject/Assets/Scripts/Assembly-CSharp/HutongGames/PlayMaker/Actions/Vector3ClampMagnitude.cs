using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001274")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACD64", Offset = "0x5ACD64")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACD64", Offset = "0x5ACD64")]
	public class Vector3ClampMagnitude : FsmStateAction
	{
		[Token(Token = "0x400584F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B1DC", Offset = "0x60B1DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B1DC", Offset = "0x60B1DC")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005850")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B23C", Offset = "0x60B23C")]
		[RequiredField]
		public FsmFloat maxLength;

		[Token(Token = "0x4005851")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B288", Offset = "0x60B288")]
		public bool everyFrame;

		[Token(Token = "0x6006BD3")]
		[Address(RVA = "0x13C7B58", Offset = "0x13C7B58", VA = "0x13C7B58", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BD4")]
		[Address(RVA = "0x13C7B64", Offset = "0x13C7B64", VA = "0x13C7B64", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BD5")]
		[Address(RVA = "0x13C7C20", Offset = "0x13C7C20", VA = "0x13C7C20", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BD6")]
		[Address(RVA = "0x13C7BA0", Offset = "0x13C7BA0", VA = "0x13C7BA0")]
		private void DoVector3ClampMagnitude()
		{
		}

		[Token(Token = "0x6006BD7")]
		[Address(RVA = "0x13C7C24", Offset = "0x13C7C24", VA = "0x13C7C24")]
		public Vector3ClampMagnitude()
		{
		}
	}
}

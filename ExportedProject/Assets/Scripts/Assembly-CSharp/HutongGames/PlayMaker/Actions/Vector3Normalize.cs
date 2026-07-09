using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200127C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACFE4", Offset = "0x5ACFE4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACFE4", Offset = "0x5ACFE4")]
	public class Vector3Normalize : FsmStateAction
	{
		[Token(Token = "0x400586E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60B9B8", Offset = "0x60B9B8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60B9B8", Offset = "0x60B9B8")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x400586F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BA18", Offset = "0x60BA18")]
		public bool everyFrame;

		[Token(Token = "0x6006BF6")]
		[Address(RVA = "0x13C8950", Offset = "0x13C8950", VA = "0x13C8950", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BF7")]
		[Address(RVA = "0x13C895C", Offset = "0x13C895C", VA = "0x13C895C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BF8")]
		[Address(RVA = "0x13C89D0", Offset = "0x13C89D0", VA = "0x13C89D0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BF9")]
		[Address(RVA = "0x13C8A2C", Offset = "0x13C8A2C", VA = "0x13C8A2C")]
		public Vector3Normalize()
		{
		}
	}
}

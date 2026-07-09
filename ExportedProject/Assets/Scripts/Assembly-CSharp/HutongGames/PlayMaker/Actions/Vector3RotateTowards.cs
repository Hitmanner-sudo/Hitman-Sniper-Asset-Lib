using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001280")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD0D4", Offset = "0x5AD0D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD0D4", Offset = "0x5AD0D4")]
	public class Vector3RotateTowards : FsmStateAction
	{
		[Token(Token = "0x4005885")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BC90", Offset = "0x60BC90")]
		public FsmVector3 currentDirection;

		[Token(Token = "0x4005886")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BCDC", Offset = "0x60BCDC")]
		public FsmVector3 targetDirection;

		[Token(Token = "0x4005887")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BD28", Offset = "0x60BD28")]
		public FsmFloat rotateSpeed;

		[Token(Token = "0x4005888")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BD74", Offset = "0x60BD74")]
		public FsmFloat maxMagnitude;

		[Token(Token = "0x6006C03")]
		[Address(RVA = "0x13C8E50", Offset = "0x13C8E50", VA = "0x13C8E50", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C04")]
		[Address(RVA = "0x13C8F08", Offset = "0x13C8F08", VA = "0x13C8F08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C05")]
		[Address(RVA = "0x13C8FF0", Offset = "0x13C8FF0", VA = "0x13C8FF0")]
		public Vector3RotateTowards()
		{
		}
	}
}

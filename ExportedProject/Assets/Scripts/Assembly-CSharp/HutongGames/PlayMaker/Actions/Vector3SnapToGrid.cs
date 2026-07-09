using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001281")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD124", Offset = "0x5AD124")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD124", Offset = "0x5AD124")]
	public class Vector3SnapToGrid : FsmStateAction
	{
		[Token(Token = "0x4005889")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60BDC0", Offset = "0x60BDC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BDC0", Offset = "0x60BDC0")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x400588A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BE20", Offset = "0x60BE20")]
		public FsmFloat gridSize;

		[Token(Token = "0x400588B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BE58", Offset = "0x60BE58")]
		public bool everyFrame;

		[Token(Token = "0x6006C06")]
		[Address(RVA = "0x13C8FF8", Offset = "0x13C8FF8", VA = "0x13C8FF8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006C07")]
		[Address(RVA = "0x13C9068", Offset = "0x13C9068", VA = "0x13C9068", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006C08")]
		[Address(RVA = "0x13C92A8", Offset = "0x13C92A8", VA = "0x13C92A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006C09")]
		[Address(RVA = "0x13C90A4", Offset = "0x13C90A4", VA = "0x13C90A4")]
		private void DoSnapToGrid()
		{
		}

		[Token(Token = "0x6006C0A")]
		[Address(RVA = "0x13C92AC", Offset = "0x13C92AC", VA = "0x13C92AC")]
		public Vector3SnapToGrid()
		{
		}
	}
}

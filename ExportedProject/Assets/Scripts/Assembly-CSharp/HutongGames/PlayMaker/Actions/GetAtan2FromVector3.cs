using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011BF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A97E8", Offset = "0x5A97E8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A97E8", Offset = "0x5A97E8")]
	public class GetAtan2FromVector3 : FsmStateAction
	{
		[Token(Token = "0x20011C0")]
		public enum aTan2EnumAxis
		{
			[Token(Token = "0x40054C6")]
			x = 0,
			[Token(Token = "0x40054C7")]
			y = 1,
			[Token(Token = "0x40054C8")]
			z = 2
		}

		[Token(Token = "0x40054BF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEA10", Offset = "0x5FEA10")]
		[RequiredField]
		public FsmVector3 vector3;

		[Token(Token = "0x40054C0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEA5C", Offset = "0x5FEA5C")]
		[RequiredField]
		public aTan2EnumAxis xAxis;

		[Token(Token = "0x40054C1")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEAA8", Offset = "0x5FEAA8")]
		[RequiredField]
		public aTan2EnumAxis yAxis;

		[Token(Token = "0x40054C2")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEAF4", Offset = "0x5FEAF4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FEAF4", Offset = "0x5FEAF4")]
		public FsmFloat angle;

		[Token(Token = "0x40054C3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEB54", Offset = "0x5FEB54")]
		public FsmBool RadToDeg;

		[Token(Token = "0x40054C4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEB8C", Offset = "0x5FEB8C")]
		public bool everyFrame;

		[Token(Token = "0x600687D")]
		[Address(RVA = "0x105D104", Offset = "0x105D104", VA = "0x105D104", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600687E")]
		[Address(RVA = "0x105D144", Offset = "0x105D144", VA = "0x105D144", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600687F")]
		[Address(RVA = "0x105D284", Offset = "0x105D284", VA = "0x105D284", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006880")]
		[Address(RVA = "0x105D180", Offset = "0x105D180", VA = "0x105D180")]
		private void DoATan()
		{
		}

		[Token(Token = "0x6006881")]
		[Address(RVA = "0x105D288", Offset = "0x105D288", VA = "0x105D288")]
		public GetAtan2FromVector3()
		{
		}
	}
}

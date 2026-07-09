using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200127D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AD034", Offset = "0x5AD034")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AD034", Offset = "0x5AD034")]
	public class Vector3Operator : FsmStateAction
	{
		[Token(Token = "0x200127E")]
		public enum Vector3Operation
		{
			[Token(Token = "0x4005877")]
			DotProduct = 0,
			[Token(Token = "0x4005878")]
			CrossProduct = 1,
			[Token(Token = "0x4005879")]
			Distance = 2,
			[Token(Token = "0x400587A")]
			Angle = 3,
			[Token(Token = "0x400587B")]
			Project = 4,
			[Token(Token = "0x400587C")]
			Reflect = 5,
			[Token(Token = "0x400587D")]
			Add = 6,
			[Token(Token = "0x400587E")]
			Subtract = 7,
			[Token(Token = "0x400587F")]
			Multiply = 8,
			[Token(Token = "0x4005880")]
			Divide = 9,
			[Token(Token = "0x4005881")]
			Min = 10,
			[Token(Token = "0x4005882")]
			Max = 11
		}

		[Token(Token = "0x4005870")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BA50", Offset = "0x60BA50")]
		public FsmVector3 vector1;

		[Token(Token = "0x4005871")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BA9C", Offset = "0x60BA9C")]
		public FsmVector3 vector2;

		[Token(Token = "0x4005872")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BAE8", Offset = "0x60BAE8")]
		public Vector3Operation operation;

		[Token(Token = "0x4005873")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60BB20", Offset = "0x60BB20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BB20", Offset = "0x60BB20")]
		public FsmVector3 storeVector3Result;

		[Token(Token = "0x4005874")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60BB70", Offset = "0x60BB70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BB70", Offset = "0x60BB70")]
		public FsmFloat storeFloatResult;

		[Token(Token = "0x4005875")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60BBC0", Offset = "0x60BBC0")]
		public bool everyFrame;

		[Token(Token = "0x6006BFA")]
		[Address(RVA = "0x13C8A34", Offset = "0x13C8A34", VA = "0x13C8A34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BFB")]
		[Address(RVA = "0x13C8A4C", Offset = "0x13C8A4C", VA = "0x13C8A4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BFC")]
		[Address(RVA = "0x13C8D30", Offset = "0x13C8D30", VA = "0x13C8D30", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BFD")]
		[Address(RVA = "0x13C8A88", Offset = "0x13C8A88", VA = "0x13C8A88")]
		private void DoVector3Operator()
		{
		}

		[Token(Token = "0x6006BFE")]
		[Address(RVA = "0x13C8D34", Offset = "0x13C8D34", VA = "0x13C8D34")]
		public Vector3Operator()
		{
		}
	}
}

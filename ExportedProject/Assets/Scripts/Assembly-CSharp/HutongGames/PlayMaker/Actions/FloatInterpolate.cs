using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200104F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1840", Offset = "0x5A1840")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1840", Offset = "0x5A1840")]
	public class FloatInterpolate : FsmStateAction
	{
		[Token(Token = "0x4004C90")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF77C", Offset = "0x5DF77C")]
		public InterpolationType mode;

		[Token(Token = "0x4004C91")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF7B4", Offset = "0x5DF7B4")]
		public FsmFloat fromFloat;

		[Token(Token = "0x4004C92")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF800", Offset = "0x5DF800")]
		[RequiredField]
		public FsmFloat toFloat;

		[Token(Token = "0x4004C93")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF84C", Offset = "0x5DF84C")]
		public FsmFloat time;

		[Token(Token = "0x4004C94")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF898", Offset = "0x5DF898")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF898", Offset = "0x5DF898")]
		[RequiredField]
		public FsmFloat storeResult;

		[Token(Token = "0x4004C95")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF8F8", Offset = "0x5DF8F8")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4004C96")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF930", Offset = "0x5DF930")]
		public bool realTime;

		[Token(Token = "0x4004C97")]
		[FieldOffset(Offset = "0x7C")]
		private float startTime;

		[Token(Token = "0x4004C98")]
		[FieldOffset(Offset = "0x80")]
		private float currentTime;

		[Token(Token = "0x60061A4")]
		[Address(RVA = "0x959284", Offset = "0x959284", VA = "0x959284", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061A5")]
		[Address(RVA = "0x9592C4", Offset = "0x9592C4", VA = "0x9592C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061A6")]
		[Address(RVA = "0x959324", Offset = "0x959324", VA = "0x959324", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061A7")]
		[Address(RVA = "0x959464", Offset = "0x959464", VA = "0x959464")]
		public FloatInterpolate()
		{
		}
	}
}

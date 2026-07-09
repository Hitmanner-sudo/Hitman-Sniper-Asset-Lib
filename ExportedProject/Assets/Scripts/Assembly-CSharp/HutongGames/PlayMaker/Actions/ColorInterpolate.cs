using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F4F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C7D0", Offset = "0x59C7D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C7D0", Offset = "0x59C7D0")]
	public class ColorInterpolate : FsmStateAction
	{
		[Token(Token = "0x4004862")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEBB0", Offset = "0x5CEBB0")]
		[RequiredField]
		public FsmColor[] colors;

		[Token(Token = "0x4004863")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEBFC", Offset = "0x5CEBFC")]
		public FsmFloat time;

		[Token(Token = "0x4004864")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CEC48", Offset = "0x5CEC48")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CEC48", Offset = "0x5CEC48")]
		public FsmColor storeColor;

		[Token(Token = "0x4004865")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CECA8", Offset = "0x5CECA8")]
		public FsmEvent finishEvent;

		[Token(Token = "0x4004866")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CECE0", Offset = "0x5CECE0")]
		public bool realTime;

		[Token(Token = "0x4004867")]
		[FieldOffset(Offset = "0x74")]
		private float startTime;

		[Token(Token = "0x4004868")]
		[FieldOffset(Offset = "0x78")]
		private float currentTime;

		[Token(Token = "0x6005DA1")]
		[Address(RVA = "0x8DA310", Offset = "0x8DA310", VA = "0x8DA310", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DA2")]
		[Address(RVA = "0x8DA37C", Offset = "0x8DA37C", VA = "0x8DA37C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DA3")]
		[Address(RVA = "0x8DA408", Offset = "0x8DA408", VA = "0x8DA408", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DA4")]
		[Address(RVA = "0x8DA638", Offset = "0x8DA638", VA = "0x8DA638", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005DA5")]
		[Address(RVA = "0x8DA698", Offset = "0x8DA698", VA = "0x8DA698")]
		public ColorInterpolate()
		{
		}
	}
}

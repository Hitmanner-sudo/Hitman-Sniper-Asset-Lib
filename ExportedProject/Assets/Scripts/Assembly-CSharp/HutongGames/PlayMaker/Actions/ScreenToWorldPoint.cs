using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F3D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C280", Offset = "0x59C280")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C280", Offset = "0x59C280")]
	public class ScreenToWorldPoint : FsmStateAction
	{
		[Token(Token = "0x40047E4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CCAF0", Offset = "0x5CCAF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCAF0", Offset = "0x5CCAF0")]
		public FsmVector3 screenVector;

		[Token(Token = "0x40047E5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCB40", Offset = "0x5CCB40")]
		public FsmFloat screenX;

		[Token(Token = "0x40047E6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCB78", Offset = "0x5CCB78")]
		public FsmFloat screenY;

		[Token(Token = "0x40047E7")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCBB0", Offset = "0x5CCBB0")]
		public FsmFloat screenZ;

		[Token(Token = "0x40047E8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCBE8", Offset = "0x5CCBE8")]
		public FsmBool normalized;

		[Token(Token = "0x40047E9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CCC20", Offset = "0x5CCC20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCC20", Offset = "0x5CCC20")]
		public FsmVector3 storeWorldVector;

		[Token(Token = "0x40047EA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CCC70", Offset = "0x5CCC70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCC70", Offset = "0x5CCC70")]
		public FsmFloat storeWorldX;

		[Token(Token = "0x40047EB")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CCCC0", Offset = "0x5CCCC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCCC0", Offset = "0x5CCCC0")]
		public FsmFloat storeWorldY;

		[Token(Token = "0x40047EC")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CCD10", Offset = "0x5CCD10")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCD10", Offset = "0x5CCD10")]
		public FsmFloat storeWorldZ;

		[Token(Token = "0x40047ED")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCD60", Offset = "0x5CCD60")]
		public bool everyFrame;

		[Token(Token = "0x6005D49")]
		[Address(RVA = "0xB6747C", Offset = "0xB6747C", VA = "0xB6747C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D4A")]
		[Address(RVA = "0xB67540", Offset = "0xB67540", VA = "0xB67540", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D4B")]
		[Address(RVA = "0xB67794", Offset = "0xB67794", VA = "0xB67794", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0xB6757C", Offset = "0xB6757C", VA = "0xB6757C")]
		private void DoScreenToWorldPoint()
		{
		}

		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0xB67798", Offset = "0xB67798", VA = "0xB67798")]
		public ScreenToWorldPoint()
		{
		}
	}
}

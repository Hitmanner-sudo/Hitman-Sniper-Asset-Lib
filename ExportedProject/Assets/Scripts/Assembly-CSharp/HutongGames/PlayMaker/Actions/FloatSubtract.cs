using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001053")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1930", Offset = "0x5A1930")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1930", Offset = "0x5A1930")]
	public class FloatSubtract : FsmStateAction
	{
		[Token(Token = "0x4004CA9")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DFBB4", Offset = "0x5DFBB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFBB4", Offset = "0x5DFBB4")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004CAA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFC14", Offset = "0x5DFC14")]
		[RequiredField]
		public FsmFloat subtract;

		[Token(Token = "0x4004CAB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFC60", Offset = "0x5DFC60")]
		public bool everyFrame;

		[Token(Token = "0x4004CAC")]
		[FieldOffset(Offset = "0x61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFC98", Offset = "0x5DFC98")]
		public bool perSecond;

		[Token(Token = "0x60061B1")]
		[Address(RVA = "0x959850", Offset = "0x959850", VA = "0x959850", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061B2")]
		[Address(RVA = "0x95985C", Offset = "0x95985C", VA = "0x95985C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061B3")]
		[Address(RVA = "0x959910", Offset = "0x959910", VA = "0x959910", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061B4")]
		[Address(RVA = "0x959898", Offset = "0x959898", VA = "0x959898")]
		private void DoFloatSubtract()
		{
		}

		[Token(Token = "0x60061B5")]
		[Address(RVA = "0x959914", Offset = "0x959914", VA = "0x959914")]
		public FloatSubtract()
		{
		}
	}
}

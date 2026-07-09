using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001049")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1660", Offset = "0x5A1660")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1660", Offset = "0x5A1660")]
	public class FloatAbs : FsmStateAction
	{
		[Token(Token = "0x4004C7C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF188", Offset = "0x5DF188")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF188", Offset = "0x5DF188")]
		[RequiredField]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004C7D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF1E8", Offset = "0x5DF1E8")]
		public bool everyFrame;

		[Token(Token = "0x6006187")]
		[Address(RVA = "0x958998", Offset = "0x958998", VA = "0x958998", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006188")]
		[Address(RVA = "0x9589A4", Offset = "0x9589A4", VA = "0x9589A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006189")]
		[Address(RVA = "0x958A18", Offset = "0x958A18", VA = "0x958A18", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600618A")]
		[Address(RVA = "0x9589E0", Offset = "0x9589E0", VA = "0x9589E0")]
		private void DoFloatAbs()
		{
		}

		[Token(Token = "0x600618B")]
		[Address(RVA = "0x958A1C", Offset = "0x958A1C", VA = "0x958A1C")]
		public FloatAbs()
		{
		}
	}
}

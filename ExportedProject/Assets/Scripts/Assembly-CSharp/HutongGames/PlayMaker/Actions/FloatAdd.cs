using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200104A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A16B0", Offset = "0x5A16B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A16B0", Offset = "0x5A16B0")]
	public class FloatAdd : FsmStateAction
	{
		[Token(Token = "0x4004C7E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DF220", Offset = "0x5DF220")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF220", Offset = "0x5DF220")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004C7F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF280", Offset = "0x5DF280")]
		public FsmFloat add;

		[Token(Token = "0x4004C80")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF2CC", Offset = "0x5DF2CC")]
		public bool everyFrame;

		[Token(Token = "0x4004C81")]
		[FieldOffset(Offset = "0x61")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DF304", Offset = "0x5DF304")]
		public bool perSecond;

		[Token(Token = "0x600618C")]
		[Address(RVA = "0x958A24", Offset = "0x958A24", VA = "0x958A24", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600618D")]
		[Address(RVA = "0x958A30", Offset = "0x958A30", VA = "0x958A30", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600618E")]
		[Address(RVA = "0x958AE4", Offset = "0x958AE4", VA = "0x958AE4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600618F")]
		[Address(RVA = "0x958A6C", Offset = "0x958A6C", VA = "0x958A6C")]
		private void DoFloatAdd()
		{
		}

		[Token(Token = "0x6006190")]
		[Address(RVA = "0x958AE8", Offset = "0x958AE8", VA = "0x958AE8")]
		public FloatAdd()
		{
		}
	}
}

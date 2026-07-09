using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F8C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D8DC", Offset = "0x59D8DC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D8DC", Offset = "0x59D8DC")]
	public class FloatFloor : FsmStateAction
	{
		[Token(Token = "0x4004977")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2B98", Offset = "0x5D2B98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2B98", Offset = "0x5D2B98")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004978")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2BF8", Offset = "0x5D2BF8")]
		public bool everyFrame;

		[Token(Token = "0x6005E99")]
		[Address(RVA = "0x9591F8", Offset = "0x9591F8", VA = "0x9591F8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E9A")]
		[Address(RVA = "0x959204", Offset = "0x959204", VA = "0x959204", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0x959278", Offset = "0x959278", VA = "0x959278", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0x959240", Offset = "0x959240", VA = "0x959240")]
		private void DoFloatAdd()
		{
		}

		[Token(Token = "0x6005E9D")]
		[Address(RVA = "0x95927C", Offset = "0x95927C", VA = "0x95927C")]
		public FloatFloor()
		{
		}
	}
}

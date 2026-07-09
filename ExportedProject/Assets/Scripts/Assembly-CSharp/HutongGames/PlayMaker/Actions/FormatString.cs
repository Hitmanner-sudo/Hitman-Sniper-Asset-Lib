using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200118B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8874", Offset = "0x5A8874")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8874", Offset = "0x5A8874")]
	public class FormatString : FsmStateAction
	{
		[Token(Token = "0x400537B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA188", Offset = "0x5FA188")]
		public FsmString format;

		[Token(Token = "0x400537C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA1D4", Offset = "0x5FA1D4")]
		public FsmVar[] variables;

		[Token(Token = "0x400537D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA20C", Offset = "0x5FA20C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA20C", Offset = "0x5FA20C")]
		[RequiredField]
		public FsmString storeResult;

		[Token(Token = "0x400537E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA26C", Offset = "0x5FA26C")]
		public bool everyFrame;

		[Token(Token = "0x400537F")]
		[FieldOffset(Offset = "0x70")]
		private object[] objectArray;

		[Token(Token = "0x6006774")]
		[Address(RVA = "0x95AB74", Offset = "0x95AB74", VA = "0x95AB74", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006775")]
		[Address(RVA = "0x95AB84", Offset = "0x95AB84", VA = "0x95AB84", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006776")]
		[Address(RVA = "0x95ADD0", Offset = "0x95ADD0", VA = "0x95ADD0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006777")]
		[Address(RVA = "0x95AC08", Offset = "0x95AC08", VA = "0x95AC08")]
		private void DoFormatString()
		{
		}

		[Token(Token = "0x6006778")]
		[Address(RVA = "0x95ADD4", Offset = "0x95ADD4", VA = "0x95ADD4")]
		public FormatString()
		{
		}
	}
}

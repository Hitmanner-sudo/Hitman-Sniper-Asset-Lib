using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9838", Offset = "0x5A9838")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9838", Offset = "0x5A9838")]
	public class GetCosine : FsmStateAction
	{
		[Token(Token = "0x40054C9")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEBC4", Offset = "0x5FEBC4")]
		public FsmFloat angle;

		[Token(Token = "0x40054CA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEC10", Offset = "0x5FEC10")]
		public FsmBool DegToRad;

		[Token(Token = "0x40054CB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEC48", Offset = "0x5FEC48")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FEC48", Offset = "0x5FEC48")]
		public FsmFloat result;

		[Token(Token = "0x40054CC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FECA8", Offset = "0x5FECA8")]
		public bool everyFrame;

		[Token(Token = "0x6006882")]
		[Address(RVA = "0x105F0FC", Offset = "0x105F0FC", VA = "0x105F0FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006883")]
		[Address(RVA = "0x105F130", Offset = "0x105F130", VA = "0x105F130", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006884")]
		[Address(RVA = "0x105F1DC", Offset = "0x105F1DC", VA = "0x105F1DC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006885")]
		[Address(RVA = "0x105F16C", Offset = "0x105F16C", VA = "0x105F16C")]
		private void DoCosine()
		{
		}

		[Token(Token = "0x6006886")]
		[Address(RVA = "0x105F1E0", Offset = "0x105F1E0", VA = "0x105F1E0")]
		public GetCosine()
		{
		}
	}
}

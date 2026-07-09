using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9888", Offset = "0x5A9888")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9888", Offset = "0x5A9888")]
	public class GetSine : FsmStateAction
	{
		[Token(Token = "0x40054CD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FECE0", Offset = "0x5FECE0")]
		[RequiredField]
		public FsmFloat angle;

		[Token(Token = "0x40054CE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FED2C", Offset = "0x5FED2C")]
		public FsmBool DegToRad;

		[Token(Token = "0x40054CF")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FED64", Offset = "0x5FED64")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FED64", Offset = "0x5FED64")]
		public FsmFloat result;

		[Token(Token = "0x40054D0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEDC4", Offset = "0x5FEDC4")]
		public bool everyFrame;

		[Token(Token = "0x6006887")]
		[Address(RVA = "0xC7EB78", Offset = "0xC7EB78", VA = "0xC7EB78", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006888")]
		[Address(RVA = "0xC7EBAC", Offset = "0xC7EBAC", VA = "0xC7EBAC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006889")]
		[Address(RVA = "0xC7EC58", Offset = "0xC7EC58", VA = "0xC7EC58", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600688A")]
		[Address(RVA = "0xC7EBE8", Offset = "0xC7EBE8", VA = "0xC7EBE8")]
		private void DoSine()
		{
		}

		[Token(Token = "0x600688B")]
		[Address(RVA = "0xC7EC5C", Offset = "0xC7EC5C", VA = "0xC7EC5C")]
		public GetSine()
		{
		}
	}
}

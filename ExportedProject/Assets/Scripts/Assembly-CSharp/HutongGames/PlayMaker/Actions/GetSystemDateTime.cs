using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001196")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8BE4", Offset = "0x5A8BE4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8BE4", Offset = "0x5A8BE4")]
	public class GetSystemDateTime : FsmStateAction
	{
		[Token(Token = "0x40053A5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FAE40", Offset = "0x5FAE40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAE40", Offset = "0x5FAE40")]
		public FsmString storeString;

		[Token(Token = "0x40053A6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAE90", Offset = "0x5FAE90")]
		public FsmString format;

		[Token(Token = "0x40053A7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAEC8", Offset = "0x5FAEC8")]
		public bool everyFrame;

		[Token(Token = "0x60067A3")]
		[Address(RVA = "0xC7FE50", Offset = "0xC7FE50", VA = "0xC7FE50", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067A4")]
		[Address(RVA = "0xC7FEA8", Offset = "0xC7FEA8", VA = "0xC7FEA8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067A5")]
		[Address(RVA = "0xC7FF60", Offset = "0xC7FF60", VA = "0xC7FF60", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067A6")]
		[Address(RVA = "0xC80004", Offset = "0xC80004", VA = "0xC80004")]
		public GetSystemDateTime()
		{
		}
	}
}

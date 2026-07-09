using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011BA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9658", Offset = "0x5A9658")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9658", Offset = "0x5A9658")]
	public class GetACosine : FsmStateAction
	{
		[Token(Token = "0x40054AA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE438", Offset = "0x5FE438")]
		[RequiredField]
		public FsmFloat Value;

		[Token(Token = "0x40054AB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE484", Offset = "0x5FE484")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE484", Offset = "0x5FE484")]
		public FsmFloat angle;

		[Token(Token = "0x40054AC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE4E4", Offset = "0x5FE4E4")]
		public FsmBool RadToDeg;

		[Token(Token = "0x40054AD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE51C", Offset = "0x5FE51C")]
		public bool everyFrame;

		[Token(Token = "0x6006864")]
		[Address(RVA = "0xDA18D8", Offset = "0xDA18D8", VA = "0xDA18D8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006865")]
		[Address(RVA = "0xDA1910", Offset = "0xDA1910", VA = "0xDA1910", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006866")]
		[Address(RVA = "0xDA19BC", Offset = "0xDA19BC", VA = "0xDA19BC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006867")]
		[Address(RVA = "0xDA194C", Offset = "0xDA194C", VA = "0xDA194C")]
		private void DoACosine()
		{
		}

		[Token(Token = "0x6006868")]
		[Address(RVA = "0xDA19C0", Offset = "0xDA19C0", VA = "0xDA19C0")]
		public GetACosine()
		{
		}
	}
}

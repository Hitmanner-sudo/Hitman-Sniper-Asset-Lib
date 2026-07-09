using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011C3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A98D8", Offset = "0x5A98D8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A98D8", Offset = "0x5A98D8")]
	public class GetTan : FsmStateAction
	{
		[Token(Token = "0x40054D1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEDFC", Offset = "0x5FEDFC")]
		[RequiredField]
		public FsmFloat angle;

		[Token(Token = "0x40054D2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEE48", Offset = "0x5FEE48")]
		public FsmBool DegToRad;

		[Token(Token = "0x40054D3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FEE80", Offset = "0x5FEE80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEE80", Offset = "0x5FEE80")]
		public FsmFloat result;

		[Token(Token = "0x40054D4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FEEE0", Offset = "0x5FEEE0")]
		public bool everyFrame;

		[Token(Token = "0x600688C")]
		[Address(RVA = "0xC801CC", Offset = "0xC801CC", VA = "0xC801CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600688D")]
		[Address(RVA = "0xC80200", Offset = "0xC80200", VA = "0xC80200", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600688E")]
		[Address(RVA = "0xC802AC", Offset = "0xC802AC", VA = "0xC802AC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600688F")]
		[Address(RVA = "0xC8023C", Offset = "0xC8023C", VA = "0xC8023C")]
		private void DoTan()
		{
		}

		[Token(Token = "0x6006890")]
		[Address(RVA = "0xC802B0", Offset = "0xC802B0", VA = "0xC802B0")]
		public GetTan()
		{
		}
	}
}

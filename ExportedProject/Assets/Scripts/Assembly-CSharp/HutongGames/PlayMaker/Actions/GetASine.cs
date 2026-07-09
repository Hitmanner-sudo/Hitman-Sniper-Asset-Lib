using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011BB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A96A8", Offset = "0x5A96A8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A96A8", Offset = "0x5A96A8")]
	public class GetASine : FsmStateAction
	{
		[Token(Token = "0x40054AE")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE554", Offset = "0x5FE554")]
		public FsmFloat Value;

		[Token(Token = "0x40054AF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE5A0", Offset = "0x5FE5A0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE5A0", Offset = "0x5FE5A0")]
		[RequiredField]
		public FsmFloat angle;

		[Token(Token = "0x40054B0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE600", Offset = "0x5FE600")]
		public FsmBool RadToDeg;

		[Token(Token = "0x40054B1")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE638", Offset = "0x5FE638")]
		public bool everyFrame;

		[Token(Token = "0x6006869")]
		[Address(RVA = "0xDA19C8", Offset = "0xDA19C8", VA = "0xDA19C8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600686A")]
		[Address(RVA = "0xDA1A00", Offset = "0xDA1A00", VA = "0xDA1A00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600686B")]
		[Address(RVA = "0xDA1AAC", Offset = "0xDA1AAC", VA = "0xDA1AAC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600686C")]
		[Address(RVA = "0xDA1A3C", Offset = "0xDA1A3C", VA = "0xDA1A3C")]
		private void DoASine()
		{
		}

		[Token(Token = "0x600686D")]
		[Address(RVA = "0xDA1AB0", Offset = "0xDA1AB0", VA = "0xDA1AB0")]
		public GetASine()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F61")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CC80", Offset = "0x59CC80")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CC80", Offset = "0x59CC80")]
	public class ConvertMaterialToObject : FsmStateAction
	{
		[Token(Token = "0x40048B1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFF60", Offset = "0x5CFF60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFF60", Offset = "0x5CFF60")]
		[RequiredField]
		public FsmMaterial materialVariable;

		[Token(Token = "0x40048B2")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFFC0", Offset = "0x5CFFC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFFC0", Offset = "0x5CFFC0")]
		public FsmObject objectVariable;

		[Token(Token = "0x40048B3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0020", Offset = "0x5D0020")]
		public bool everyFrame;

		[Token(Token = "0x6005DFD")]
		[Address(RVA = "0xD7F868", Offset = "0xD7F868", VA = "0xD7F868", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DFE")]
		[Address(RVA = "0xD7F874", Offset = "0xD7F874", VA = "0xD7F874", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DFF")]
		[Address(RVA = "0xD7F8EC", Offset = "0xD7F8EC", VA = "0xD7F8EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E00")]
		[Address(RVA = "0xD7F8B0", Offset = "0xD7F8B0", VA = "0xD7F8B0")]
		private void DoConvertMaterialToObject()
		{
		}

		[Token(Token = "0x6005E01")]
		[Address(RVA = "0xD7F8F0", Offset = "0xD7F8F0", VA = "0xD7F8F0")]
		public ConvertMaterialToObject()
		{
		}
	}
}

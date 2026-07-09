using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F60")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CC30", Offset = "0x59CC30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CC30", Offset = "0x59CC30")]
	public class ConvertIntToString : FsmStateAction
	{
		[Token(Token = "0x40048AD")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFE30", Offset = "0x5CFE30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFE30", Offset = "0x5CFE30")]
		public FsmInt intVariable;

		[Token(Token = "0x40048AE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFE90", Offset = "0x5CFE90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFE90", Offset = "0x5CFE90")]
		[RequiredField]
		public FsmString stringVariable;

		[Token(Token = "0x40048AF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFEF0", Offset = "0x5CFEF0")]
		public FsmString format;

		[Token(Token = "0x40048B0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFF28", Offset = "0x5CFF28")]
		public bool everyFrame;

		[Token(Token = "0x6005DF8")]
		[Address(RVA = "0xD7F748", Offset = "0xD7F748", VA = "0xD7F748", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DF9")]
		[Address(RVA = "0xD7F758", Offset = "0xD7F758", VA = "0xD7F758", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DFA")]
		[Address(RVA = "0xD7F85C", Offset = "0xD7F85C", VA = "0xD7F85C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DFB")]
		[Address(RVA = "0xD7F794", Offset = "0xD7F794", VA = "0xD7F794")]
		private void DoConvertIntToString()
		{
		}

		[Token(Token = "0x6005DFC")]
		[Address(RVA = "0xD7F860", Offset = "0xD7F860", VA = "0xD7F860")]
		public ConvertIntToString()
		{
		}
	}
}

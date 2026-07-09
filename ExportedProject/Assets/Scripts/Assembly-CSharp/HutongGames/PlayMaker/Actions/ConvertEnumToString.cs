using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F5B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CAF0", Offset = "0x59CAF0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CAF0", Offset = "0x59CAF0")]
	public class ConvertEnumToString : FsmStateAction
	{
		[Token(Token = "0x400489B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF9E0", Offset = "0x5CF9E0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF9E0", Offset = "0x5CF9E0")]
		[RequiredField]
		public FsmEnum enumVariable;

		[Token(Token = "0x400489C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFA40", Offset = "0x5CFA40")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CFA40", Offset = "0x5CFA40")]
		[RequiredField]
		public FsmString stringVariable;

		[Token(Token = "0x400489D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CFAA0", Offset = "0x5CFAA0")]
		public bool everyFrame;

		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0xD7F3A8", Offset = "0xD7F3A8", VA = "0xD7F3A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DE5")]
		[Address(RVA = "0xD7F3B4", Offset = "0xD7F3B4", VA = "0xD7F3B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DE6")]
		[Address(RVA = "0xD7F480", Offset = "0xD7F480", VA = "0xD7F480", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DE7")]
		[Address(RVA = "0xD7F3F0", Offset = "0xD7F3F0", VA = "0xD7F3F0")]
		private void DoConvertEnumToString()
		{
		}

		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0xD7F484", Offset = "0xD7F484", VA = "0xD7F484")]
		public ConvertEnumToString()
		{
		}
	}
}

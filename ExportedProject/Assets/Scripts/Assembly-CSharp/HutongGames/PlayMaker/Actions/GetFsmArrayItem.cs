using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F26")]
	[Attribute(Name = "ActionTarget", RVA = "0x59BA70", Offset = "0x59BA70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59BA70", Offset = "0x59BA70")]
	public class GetFsmArrayItem : BaseFsmVariableIndexAction
	{
		[Token(Token = "0x4004785")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB3AC", Offset = "0x5CB3AC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004786")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB3F8", Offset = "0x5CB3F8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB3F8", Offset = "0x5CB3F8")]
		public FsmString fsmName;

		[Token(Token = "0x4004787")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB448", Offset = "0x5CB448")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB448", Offset = "0x5CB448")]
		public FsmString variableName;

		[Token(Token = "0x4004788")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB4A8", Offset = "0x5CB4A8")]
		public FsmInt index;

		[Token(Token = "0x4004789")]
		[FieldOffset(Offset = "0xA0")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CB4E0", Offset = "0x5CB4E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB4E0", Offset = "0x5CB4E0")]
		public FsmVar storeValue;

		[Token(Token = "0x400478A")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CB540", Offset = "0x5CB540")]
		public bool everyFrame;

		[Token(Token = "0x6005CEB")]
		[Address(RVA = "0x10608CC", Offset = "0x10608CC", VA = "0x10608CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0x1060928", Offset = "0x1060928", VA = "0x1060928", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CED")]
		[Address(RVA = "0x1060964", Offset = "0x1060964", VA = "0x1060964")]
		private void DoGetFsmArray()
		{
		}

		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0x1060B84", Offset = "0x1060B84", VA = "0x1060B84", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0x1060B88", Offset = "0x1060B88", VA = "0x1060B88")]
		public GetFsmArrayItem()
		{
		}
	}
}

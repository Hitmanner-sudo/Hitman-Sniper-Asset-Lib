using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F0C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B240", Offset = "0x59B240")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B240", Offset = "0x59B240")]
	public class ArrayAddGameObject : FsmStateAction
	{
		[Token(Token = "0x400471F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9804", Offset = "0x5C9804")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9804", Offset = "0x5C9804")]
		[RequiredField]
		public FsmArray array;

		[Token(Token = "0x4004720")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9864", Offset = "0x5C9864")]
		[RequiredField]
		public FsmGameObject value;

		[Token(Token = "0x6005C85")]
		[Address(RVA = "0xD55D64", Offset = "0xD55D64", VA = "0xD55D64", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C86")]
		[Address(RVA = "0xD55D6C", Offset = "0xD55D6C", VA = "0xD55D6C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C87")]
		[Address(RVA = "0xD55D94", Offset = "0xD55D94", VA = "0xD55D94")]
		private void DoAddValue()
		{
		}

		[Token(Token = "0x6005C88")]
		[Address(RVA = "0xD55E14", Offset = "0xD55E14", VA = "0xD55E14")]
		public ArrayAddGameObject()
		{
		}
	}
}

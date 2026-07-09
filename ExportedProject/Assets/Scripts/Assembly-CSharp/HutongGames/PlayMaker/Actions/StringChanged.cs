using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001036")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1070", Offset = "0x5A1070")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1070", Offset = "0x5A1070")]
	public class StringChanged : FsmStateAction
	{
		[Token(Token = "0x4004C24")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD720", Offset = "0x5DD720")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD720", Offset = "0x5DD720")]
		public FsmString stringVariable;

		[Token(Token = "0x4004C25")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD780", Offset = "0x5DD780")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004C26")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD7B8", Offset = "0x5DD7B8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD7B8", Offset = "0x5DD7B8")]
		public FsmBool storeResult;

		[Token(Token = "0x4004C27")]
		[FieldOffset(Offset = "0x68")]
		private string previousValue;

		[Token(Token = "0x600612F")]
		[Address(RVA = "0xD2DC1C", Offset = "0xD2DC1C", VA = "0xD2DC1C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006130")]
		[Address(RVA = "0xD2DC28", Offset = "0xD2DC28", VA = "0xD2DC28", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006131")]
		[Address(RVA = "0xD2DC84", Offset = "0xD2DC84", VA = "0xD2DC84", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006132")]
		[Address(RVA = "0xD2DCF0", Offset = "0xD2DCF0", VA = "0xD2DCF0")]
		public StringChanged()
		{
		}
	}
}

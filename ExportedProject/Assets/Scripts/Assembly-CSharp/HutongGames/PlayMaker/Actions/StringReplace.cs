using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001194")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8B44", Offset = "0x5A8B44")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8B44", Offset = "0x5A8B44")]
	public class StringReplace : FsmStateAction
	{
		[Token(Token = "0x400539B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAB5C", Offset = "0x5FAB5C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FAB5C", Offset = "0x5FAB5C")]
		public FsmString stringVariable;

		[Token(Token = "0x400539C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FABBC", Offset = "0x5FABBC")]
		public FsmString replace;

		[Token(Token = "0x400539D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FABF4", Offset = "0x5FABF4")]
		public FsmString with;

		[Token(Token = "0x400539E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FAC2C", Offset = "0x5FAC2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAC2C", Offset = "0x5FAC2C")]
		[RequiredField]
		public FsmString storeResult;

		[Token(Token = "0x400539F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAC8C", Offset = "0x5FAC8C")]
		public bool everyFrame;

		[Token(Token = "0x600679B")]
		[Address(RVA = "0xD2E960", Offset = "0xD2E960", VA = "0xD2E960", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600679C")]
		[Address(RVA = "0xD2E9CC", Offset = "0xD2E9CC", VA = "0xD2E9CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600679D")]
		[Address(RVA = "0xD2EA94", Offset = "0xD2EA94", VA = "0xD2EA94", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600679E")]
		[Address(RVA = "0xD2EA08", Offset = "0xD2EA08", VA = "0xD2EA08")]
		private void DoReplace()
		{
		}

		[Token(Token = "0x600679F")]
		[Address(RVA = "0xD2EA98", Offset = "0xD2EA98", VA = "0xD2EA98")]
		public StringReplace()
		{
		}
	}
}

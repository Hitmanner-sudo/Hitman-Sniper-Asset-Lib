using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F8B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D88C", Offset = "0x59D88C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D88C", Offset = "0x59D88C")]
	public class SetEnumValue : FsmStateAction
	{
		[Token(Token = "0x4004974")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2AB0", Offset = "0x5D2AB0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D2AB0", Offset = "0x5D2AB0")]
		public FsmEnum enumVariable;

		[Token(Token = "0x4004975")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2B00", Offset = "0x5D2B00")]
		[Attribute(Name = "MatchFieldTypeAttribute", RVA = "0x5D2B00", Offset = "0x5D2B00")]
		public FsmEnum enumValue;

		[Token(Token = "0x4004976")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2B60", Offset = "0x5D2B60")]
		public bool everyFrame;

		[Token(Token = "0x6005E94")]
		[Address(RVA = "0x103911C", Offset = "0x103911C", VA = "0x103911C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E95")]
		[Address(RVA = "0x1039128", Offset = "0x1039128", VA = "0x1039128", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E96")]
		[Address(RVA = "0x10391A8", Offset = "0x10391A8", VA = "0x10391A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E97")]
		[Address(RVA = "0x1039164", Offset = "0x1039164", VA = "0x1039164")]
		private void DoSetEnumValue()
		{
		}

		[Token(Token = "0x6005E98")]
		[Address(RVA = "0x10391AC", Offset = "0x10391AC", VA = "0x10391AC")]
		public SetEnumValue()
		{
		}
	}
}

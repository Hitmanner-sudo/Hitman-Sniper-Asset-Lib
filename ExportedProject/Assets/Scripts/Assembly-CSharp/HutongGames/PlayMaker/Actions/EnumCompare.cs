using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200101F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0740", Offset = "0x5A0740")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0740", Offset = "0x5A0740")]
	public class EnumCompare : FsmStateAction
	{
		[Token(Token = "0x4004BA5")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB50C", Offset = "0x5DB50C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB50C", Offset = "0x5DB50C")]
		public FsmEnum enumVariable;

		[Token(Token = "0x4004BA6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "MatchFieldTypeAttribute", RVA = "0x5DB56C", Offset = "0x5DB56C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB56C", Offset = "0x5DB56C")]
		public FsmEnum compareTo;

		[Token(Token = "0x4004BA7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB5CC", Offset = "0x5DB5CC")]
		public FsmEvent equalEvent;

		[Token(Token = "0x4004BA8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB604", Offset = "0x5DB604")]
		public FsmEvent notEqualEvent;

		[Token(Token = "0x4004BA9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB63C", Offset = "0x5DB63C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB63C", Offset = "0x5DB63C")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BAA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB68C", Offset = "0x5DB68C")]
		public bool everyFrame;

		[Token(Token = "0x60060BB")]
		[Address(RVA = "0xE15D1C", Offset = "0xE15D1C", VA = "0xE15D1C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060BC")]
		[Address(RVA = "0xE15D30", Offset = "0xE15D30", VA = "0xE15D30", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060BD")]
		[Address(RVA = "0xE15E08", Offset = "0xE15E08", VA = "0xE15E08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060BE")]
		[Address(RVA = "0xE15D6C", Offset = "0xE15D6C", VA = "0xE15D6C")]
		private void DoEnumCompare()
		{
		}

		[Token(Token = "0x60060BF")]
		[Address(RVA = "0xE15E0C", Offset = "0xE15E0C", VA = "0xE15E0C")]
		public EnumCompare()
		{
		}
	}
}

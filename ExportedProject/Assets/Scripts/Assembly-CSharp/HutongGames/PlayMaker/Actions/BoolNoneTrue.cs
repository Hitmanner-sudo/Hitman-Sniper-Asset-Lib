using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200101A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0600", Offset = "0x5A0600")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0600", Offset = "0x5A0600")]
	public class BoolNoneTrue : FsmStateAction
	{
		[Token(Token = "0x4004B8D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAFE0", Offset = "0x5DAFE0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DAFE0", Offset = "0x5DAFE0")]
		public FsmBool[] boolVariables;

		[Token(Token = "0x4004B8E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB040", Offset = "0x5DB040")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004B8F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB078", Offset = "0x5DB078")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB078", Offset = "0x5DB078")]
		public FsmBool storeResult;

		[Token(Token = "0x4004B90")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB0C8", Offset = "0x5DB0C8")]
		public bool everyFrame;

		[Token(Token = "0x60060A7")]
		[Address(RVA = "0xA7F508", Offset = "0xA7F508", VA = "0xA7F508", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060A8")]
		[Address(RVA = "0xA7F518", Offset = "0xA7F518", VA = "0xA7F518", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060A9")]
		[Address(RVA = "0xA7F600", Offset = "0xA7F600", VA = "0xA7F600", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060AA")]
		[Address(RVA = "0xA7F554", Offset = "0xA7F554", VA = "0xA7F554")]
		private void DoNoneTrue()
		{
		}

		[Token(Token = "0x60060AB")]
		[Address(RVA = "0xA7F604", Offset = "0xA7F604", VA = "0xA7F604")]
		public BoolNoneTrue()
		{
		}
	}
}

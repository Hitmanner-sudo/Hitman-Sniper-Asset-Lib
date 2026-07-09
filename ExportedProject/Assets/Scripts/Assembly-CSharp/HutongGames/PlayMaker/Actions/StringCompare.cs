using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001037")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A10C0", Offset = "0x5A10C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A10C0", Offset = "0x5A10C0")]
	public class StringCompare : FsmStateAction
	{
		[Token(Token = "0x4004C28")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD808", Offset = "0x5DD808")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD808", Offset = "0x5DD808")]
		public FsmString stringVariable;

		[Token(Token = "0x4004C29")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD868", Offset = "0x5DD868")]
		public FsmString compareTo;

		[Token(Token = "0x4004C2A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD8A0", Offset = "0x5DD8A0")]
		public FsmEvent equalEvent;

		[Token(Token = "0x4004C2B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD8D8", Offset = "0x5DD8D8")]
		public FsmEvent notEqualEvent;

		[Token(Token = "0x4004C2C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD910", Offset = "0x5DD910")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD910", Offset = "0x5DD910")]
		public FsmBool storeResult;

		[Token(Token = "0x4004C2D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD960", Offset = "0x5DD960")]
		public bool everyFrame;

		[Token(Token = "0x6006133")]
		[Address(RVA = "0xD2DCF8", Offset = "0xD2DCF8", VA = "0xD2DCF8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006134")]
		[Address(RVA = "0xD2DD58", Offset = "0xD2DD58", VA = "0xD2DD58", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006135")]
		[Address(RVA = "0xD2DE30", Offset = "0xD2DE30", VA = "0xD2DE30", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006136")]
		[Address(RVA = "0xD2DD94", Offset = "0xD2DD94", VA = "0xD2DD94")]
		private void DoStringCompare()
		{
		}

		[Token(Token = "0x6006137")]
		[Address(RVA = "0xD2DE34", Offset = "0xD2DE34", VA = "0xD2DE34")]
		public StringCompare()
		{
		}
	}
}

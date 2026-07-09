using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F7F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D4E8", Offset = "0x59D4E8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D4E8", Offset = "0x59D4E8")]
	public class GetTouchCount : FsmStateAction
	{
		[Token(Token = "0x400490F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1484", Offset = "0x5D1484")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1484", Offset = "0x5D1484")]
		public FsmInt storeCount;

		[Token(Token = "0x4004910")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D14E4", Offset = "0x5D14E4")]
		public bool everyFrame;

		[Token(Token = "0x6005E64")]
		[Address(RVA = "0xC8041C", Offset = "0xC8041C", VA = "0xC8041C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E65")]
		[Address(RVA = "0xC80428", Offset = "0xC80428", VA = "0xC80428", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E66")]
		[Address(RVA = "0xC804A8", Offset = "0xC804A8", VA = "0xC804A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E67")]
		[Address(RVA = "0xC80478", Offset = "0xC80478", VA = "0xC80478")]
		private void DoGetTouchCount()
		{
		}

		[Token(Token = "0x6005E68")]
		[Address(RVA = "0xC804D8", Offset = "0xC804D8", VA = "0xC804D8")]
		public GetTouchCount()
		{
		}
	}
}

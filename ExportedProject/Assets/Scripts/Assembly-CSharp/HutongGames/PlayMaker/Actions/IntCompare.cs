using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001032")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0F30", Offset = "0x5A0F30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0F30", Offset = "0x5A0F30")]
	public class IntCompare : FsmStateAction
	{
		[Token(Token = "0x4004C0E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD0F4", Offset = "0x5DD0F4")]
		public FsmInt integer1;

		[Token(Token = "0x4004C0F")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD140", Offset = "0x5DD140")]
		public FsmInt integer2;

		[Token(Token = "0x4004C10")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD18C", Offset = "0x5DD18C")]
		public FsmEvent equal;

		[Token(Token = "0x4004C11")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD1C4", Offset = "0x5DD1C4")]
		public FsmEvent lessThan;

		[Token(Token = "0x4004C12")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD1FC", Offset = "0x5DD1FC")]
		public FsmEvent greaterThan;

		[Token(Token = "0x4004C13")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD234", Offset = "0x5DD234")]
		public bool everyFrame;

		[Token(Token = "0x6006119")]
		[Address(RVA = "0xB15920", Offset = "0xB15920", VA = "0xB15920", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600611A")]
		[Address(RVA = "0xB15964", Offset = "0xB15964", VA = "0xB15964", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600611B")]
		[Address(RVA = "0xB15A8C", Offset = "0xB15A8C", VA = "0xB15A8C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600611C")]
		[Address(RVA = "0xB159A0", Offset = "0xB159A0", VA = "0xB159A0")]
		private void DoIntCompare()
		{
		}

		[Token(Token = "0x600611D")]
		[Address(RVA = "0xB15A90", Offset = "0xB15A90", VA = "0xB15A90", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x600611E")]
		[Address(RVA = "0xB15B90", Offset = "0xB15B90", VA = "0xB15B90")]
		public IntCompare()
		{
		}
	}
}

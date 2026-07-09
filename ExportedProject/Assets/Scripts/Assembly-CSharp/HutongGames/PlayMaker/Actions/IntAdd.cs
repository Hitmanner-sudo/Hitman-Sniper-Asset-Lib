using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001055")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A19D0", Offset = "0x5A19D0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A19D0", Offset = "0x5A19D0")]
	public class IntAdd : FsmStateAction
	{
		[Token(Token = "0x4004CB1")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DFE00", Offset = "0x5DFE00")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFE00", Offset = "0x5DFE00")]
		public FsmInt intVariable;

		[Token(Token = "0x4004CB2")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFE60", Offset = "0x5DFE60")]
		public FsmInt add;

		[Token(Token = "0x4004CB3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DFEAC", Offset = "0x5DFEAC")]
		public bool everyFrame;

		[Token(Token = "0x60061BB")]
		[Address(RVA = "0xB15668", Offset = "0xB15668", VA = "0xB15668", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061BC")]
		[Address(RVA = "0xB15674", Offset = "0xB15674", VA = "0xB15674", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061BD")]
		[Address(RVA = "0xB156F0", Offset = "0xB156F0", VA = "0xB156F0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60061BE")]
		[Address(RVA = "0xB15744", Offset = "0xB15744", VA = "0xB15744")]
		public IntAdd()
		{
		}
	}
}

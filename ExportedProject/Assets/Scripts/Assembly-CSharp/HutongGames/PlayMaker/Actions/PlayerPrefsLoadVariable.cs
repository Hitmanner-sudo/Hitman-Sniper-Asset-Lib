using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010BE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3A94", Offset = "0x5A3A94")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3A94", Offset = "0x5A3A94")]
	public class PlayerPrefsLoadVariable : FsmStateAction
	{
		[Token(Token = "0x4004F2D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA8D8", Offset = "0x5EA8D8")]
		public FsmString key;

		[Token(Token = "0x4004F2E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA910", Offset = "0x5EA910")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA910", Offset = "0x5EA910")]
		public FsmVar variable;

		[Token(Token = "0x60063D8")]
		[Address(RVA = "0xB8C078", Offset = "0xB8C078", VA = "0xB8C078", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063D9")]
		[Address(RVA = "0xB8C080", Offset = "0xB8C080", VA = "0xB8C080", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063DA")]
		[Address(RVA = "0xB8C21C", Offset = "0xB8C21C", VA = "0xB8C21C")]
		public PlayerPrefsLoadVariable()
		{
		}
	}
}

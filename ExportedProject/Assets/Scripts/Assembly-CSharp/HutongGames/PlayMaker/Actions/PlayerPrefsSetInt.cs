using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3BB4", Offset = "0x5A3BB4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3BB4", Offset = "0x5A3BB4")]
	public class PlayerPrefsSetInt : FsmStateAction
	{
		[Token(Token = "0x4004F33")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5EAAB0", Offset = "0x5EAAB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAAB0", Offset = "0x5EAAB0")]
		public FsmString[] keys;

		[Token(Token = "0x4004F34")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAB40", Offset = "0x5EAB40")]
		public FsmInt[] values;

		[Token(Token = "0x60063E1")]
		[Address(RVA = "0xB8C4A0", Offset = "0xB8C4A0", VA = "0xB8C4A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063E2")]
		[Address(RVA = "0xB8C518", Offset = "0xB8C518", VA = "0xB8C518", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063E3")]
		[Address(RVA = "0xB8C68C", Offset = "0xB8C68C", VA = "0xB8C68C")]
		public PlayerPrefsSetInt()
		{
		}
	}
}

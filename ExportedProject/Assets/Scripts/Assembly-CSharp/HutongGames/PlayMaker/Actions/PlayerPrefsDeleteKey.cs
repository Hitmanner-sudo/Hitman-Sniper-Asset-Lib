using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A38B4", Offset = "0x5A38B4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A38B4", Offset = "0x5A38B4")]
	public class PlayerPrefsDeleteKey : FsmStateAction
	{
		[Token(Token = "0x4004F22")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA4D0", Offset = "0x5EA4D0")]
		public FsmString key;

		[Token(Token = "0x60063C9")]
		[Address(RVA = "0xB8B818", Offset = "0xB8B818", VA = "0xB8B818", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063CA")]
		[Address(RVA = "0xB8B86C", Offset = "0xB8B86C", VA = "0xB8B86C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063CB")]
		[Address(RVA = "0xB8B90C", Offset = "0xB8B90C", VA = "0xB8B90C")]
		public PlayerPrefsDeleteKey()
		{
		}
	}
}

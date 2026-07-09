using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010BA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3914", Offset = "0x5A3914")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3914", Offset = "0x5A3914")]
	public class PlayerPrefsGetFloat : FsmStateAction
	{
		[Token(Token = "0x4004F23")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5EA508", Offset = "0x5EA508")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA508", Offset = "0x5EA508")]
		public FsmString[] keys;

		[Token(Token = "0x4004F24")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA598", Offset = "0x5EA598")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA598", Offset = "0x5EA598")]
		public FsmFloat[] variables;

		[Token(Token = "0x60063CC")]
		[Address(RVA = "0xB8B914", Offset = "0xB8B914", VA = "0xB8B914", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063CD")]
		[Address(RVA = "0xB8B98C", Offset = "0xB8B98C", VA = "0xB8B98C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063CE")]
		[Address(RVA = "0xB8BB18", Offset = "0xB8BB18", VA = "0xB8BB18")]
		public PlayerPrefsGetFloat()
		{
		}
	}
}

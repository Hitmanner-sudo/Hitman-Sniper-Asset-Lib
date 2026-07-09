using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010BF")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3AF4", Offset = "0x5A3AF4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3AF4", Offset = "0x5A3AF4")]
	public class PlayerPrefsSaveVariable : FsmStateAction
	{
		[Token(Token = "0x4004F2F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA960", Offset = "0x5EA960")]
		public FsmString key;

		[Token(Token = "0x4004F30")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA998", Offset = "0x5EA998")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA998", Offset = "0x5EA998")]
		public FsmVar variable;

		[Token(Token = "0x60063DB")]
		[Address(RVA = "0xB8C224", Offset = "0xB8C224", VA = "0xB8C224", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063DC")]
		[Address(RVA = "0xB8C22C", Offset = "0xB8C22C", VA = "0xB8C22C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063DD")]
		[Address(RVA = "0xB8C2AC", Offset = "0xB8C2AC", VA = "0xB8C2AC")]
		public PlayerPrefsSaveVariable()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010BC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A39D4", Offset = "0x5A39D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A39D4", Offset = "0x5A39D4")]
	public class PlayerPrefsGetString : FsmStateAction
	{
		[Token(Token = "0x4004F27")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5EA6C8", Offset = "0x5EA6C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA6C8", Offset = "0x5EA6C8")]
		public FsmString[] keys;

		[Token(Token = "0x4004F28")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA758", Offset = "0x5EA758")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA758", Offset = "0x5EA758")]
		public FsmString[] variables;

		[Token(Token = "0x60063D2")]
		[Address(RVA = "0xB8BD34", Offset = "0xB8BD34", VA = "0xB8BD34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063D3")]
		[Address(RVA = "0xB8BD98", Offset = "0xB8BD98", VA = "0xB8BD98", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063D4")]
		[Address(RVA = "0xB8BF2C", Offset = "0xB8BF2C", VA = "0xB8BF2C")]
		public PlayerPrefsGetString()
		{
		}
	}
}

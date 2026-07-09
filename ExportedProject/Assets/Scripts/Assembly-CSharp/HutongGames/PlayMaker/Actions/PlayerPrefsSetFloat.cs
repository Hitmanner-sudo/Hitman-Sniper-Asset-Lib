using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3B54", Offset = "0x5A3B54")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3B54", Offset = "0x5A3B54")]
	public class PlayerPrefsSetFloat : FsmStateAction
	{
		[Token(Token = "0x4004F31")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5EA9E8", Offset = "0x5EA9E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA9E8", Offset = "0x5EA9E8")]
		public FsmString[] keys;

		[Token(Token = "0x4004F32")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAA78", Offset = "0x5EAA78")]
		public FsmFloat[] values;

		[Token(Token = "0x60063DE")]
		[Address(RVA = "0xB8C2B4", Offset = "0xB8C2B4", VA = "0xB8C2B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063DF")]
		[Address(RVA = "0xB8C32C", Offset = "0xB8C32C", VA = "0xB8C32C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063E0")]
		[Address(RVA = "0xB8C498", Offset = "0xB8C498", VA = "0xB8C498")]
		public PlayerPrefsSetFloat()
		{
		}
	}
}

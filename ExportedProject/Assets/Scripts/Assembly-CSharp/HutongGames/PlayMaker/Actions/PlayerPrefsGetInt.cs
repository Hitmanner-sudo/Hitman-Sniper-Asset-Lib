using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010BB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3974", Offset = "0x5A3974")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3974", Offset = "0x5A3974")]
	public class PlayerPrefsGetInt : FsmStateAction
	{
		[Token(Token = "0x4004F25")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5EA5E8", Offset = "0x5EA5E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA5E8", Offset = "0x5EA5E8")]
		public FsmString[] keys;

		[Token(Token = "0x4004F26")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA678", Offset = "0x5EA678")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA678", Offset = "0x5EA678")]
		public FsmInt[] variables;

		[Token(Token = "0x60063CF")]
		[Address(RVA = "0xB8BB20", Offset = "0xB8BB20", VA = "0xB8BB20", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063D0")]
		[Address(RVA = "0xB8BB98", Offset = "0xB8BB98", VA = "0xB8BB98", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063D1")]
		[Address(RVA = "0xB8BD2C", Offset = "0xB8BD2C", VA = "0xB8BD2C")]
		public PlayerPrefsGetInt()
		{
		}
	}
}

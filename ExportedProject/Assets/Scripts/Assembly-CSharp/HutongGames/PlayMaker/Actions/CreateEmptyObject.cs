using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FCC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ED48", Offset = "0x59ED48")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ED48", Offset = "0x59ED48")]
	public class CreateEmptyObject : FsmStateAction
	{
		[Token(Token = "0x4004A5A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6034", Offset = "0x5D6034")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004A5B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D606C", Offset = "0x5D606C")]
		public FsmGameObject spawnPoint;

		[Token(Token = "0x4004A5C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D60A4", Offset = "0x5D60A4")]
		public FsmVector3 position;

		[Token(Token = "0x4004A5D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D60DC", Offset = "0x5D60DC")]
		public FsmVector3 rotation;

		[Token(Token = "0x4004A5E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6114", Offset = "0x5D6114")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6114", Offset = "0x5D6114")]
		public FsmGameObject storeObject;

		[Token(Token = "0x6005F68")]
		[Address(RVA = "0xD82AC4", Offset = "0xD82AC4", VA = "0xD82AC4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F69")]
		[Address(RVA = "0xD82B5C", Offset = "0xD82B5C", VA = "0xD82B5C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F6A")]
		[Address(RVA = "0xD82EA4", Offset = "0xD82EA4", VA = "0xD82EA4")]
		public CreateEmptyObject()
		{
		}
	}
}

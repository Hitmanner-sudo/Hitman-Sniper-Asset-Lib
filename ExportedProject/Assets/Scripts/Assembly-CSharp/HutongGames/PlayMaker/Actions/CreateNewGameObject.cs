using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FCD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ED98", Offset = "0x59ED98")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ED98", Offset = "0x59ED98")]
	public class CreateNewGameObject : FsmStateAction
	{
		[Token(Token = "0x4004A5F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6164", Offset = "0x5D6164")]
		public FsmString name;

		[Token(Token = "0x4004A60")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D619C", Offset = "0x5D619C")]
		public FsmGameObject parent;

		[Token(Token = "0x4004A61")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D61D4", Offset = "0x5D61D4")]
		public FsmGameObject spawnPoint;

		[Token(Token = "0x4004A62")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D620C", Offset = "0x5D620C")]
		public FsmVector3 position;

		[Token(Token = "0x4004A63")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6244", Offset = "0x5D6244")]
		public FsmVector3 rotation;

		[Token(Token = "0x4004A64")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D627C", Offset = "0x5D627C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D627C", Offset = "0x5D627C")]
		public FsmGameObject storeObject;

		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0xD82EAC", Offset = "0xD82EAC", VA = "0xD82EAC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0xD82F90", Offset = "0xD82F90", VA = "0xD82F90", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0xD832A4", Offset = "0xD832A4", VA = "0xD832A4")]
		public CreateNewGameObject()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FCE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EDE8", Offset = "0x59EDE8")]
	[Attribute(Name = "ActionTarget", RVA = "0x59EDE8", Offset = "0x59EDE8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EDE8", Offset = "0x59EDE8")]
	public class CreateObject : FsmStateAction
	{
		[Token(Token = "0x4004A65")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D62CC", Offset = "0x5D62CC")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004A66")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6318", Offset = "0x5D6318")]
		public FsmGameObject parent;

		[Token(Token = "0x4004A67")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6350", Offset = "0x5D6350")]
		public FsmGameObject spawnPoint;

		[Token(Token = "0x4004A68")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6388", Offset = "0x5D6388")]
		public FsmVector3 position;

		[Token(Token = "0x4004A69")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D63C0", Offset = "0x5D63C0")]
		public FsmVector3 rotation;

		[Token(Token = "0x4004A6A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D63F8", Offset = "0x5D63F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D63F8", Offset = "0x5D63F8")]
		public FsmGameObject storeObject;

		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0xD832AC", Offset = "0xD832AC", VA = "0xD832AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0xD83348", Offset = "0xD83348", VA = "0xD83348", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F70")]
		[Address(RVA = "0xD83674", Offset = "0xD83674", VA = "0xD83674")]
		public CreateObject()
		{
		}
	}
}

using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200109B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2F20", Offset = "0x5A2F20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2F20", Offset = "0x5A2F20")]
	public class GetTrigger2dInfo : FsmStateAction
	{
		[Token(Token = "0x4004E5E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6FBC", Offset = "0x5E6FBC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6FBC", Offset = "0x5E6FBC")]
		public FsmGameObject gameObjectHit;

		[Token(Token = "0x4004E5F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E700C", Offset = "0x5E700C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E700C", Offset = "0x5E700C")]
		public FsmInt shapeCount;

		[Token(Token = "0x4004E60")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E705C", Offset = "0x5E705C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E705C", Offset = "0x5E705C")]
		public FsmString physics2dMaterialName;

		[Token(Token = "0x600632D")]
		[Address(RVA = "0xC809B4", Offset = "0xC809B4", VA = "0xC809B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600632E")]
		[Address(RVA = "0xC809C0", Offset = "0xC809C0", VA = "0xC809C0")]
		private void StoreTriggerInfo()
		{
		}

		[Token(Token = "0x600632F")]
		[Address(RVA = "0xC80B38", Offset = "0xC80B38", VA = "0xC80B38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006330")]
		[Address(RVA = "0xC80B60", Offset = "0xC80B60", VA = "0xC80B60")]
		public GetTrigger2dInfo()
		{
		}
	}
}

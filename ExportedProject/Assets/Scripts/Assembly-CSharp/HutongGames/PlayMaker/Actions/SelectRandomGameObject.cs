using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F6C0", Offset = "0x59F6C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F6C0", Offset = "0x59F6C0")]
	public class SelectRandomGameObject : FsmStateAction
	{
		[Token(Token = "0x4004AC9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7DC8", Offset = "0x5D7DC8")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5D7DC8", Offset = "0x5D7DC8")]
		public FsmGameObject[] gameObjects;

		[Token(Token = "0x4004ACA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7E58", Offset = "0x5D7E58")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D7E58", Offset = "0x5D7E58")]
		public FsmFloat[] weights;

		[Token(Token = "0x4004ACB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7EAC", Offset = "0x5D7EAC")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7EAC", Offset = "0x5D7EAC")]
		public FsmGameObject storeGameObject;

		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0xB6FE28", Offset = "0xB6FE28", VA = "0xB6FE28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0xB6FF70", Offset = "0xB6FF70", VA = "0xB6FF70", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0xB6FF98", Offset = "0xB6FF98", VA = "0xB6FF98")]
		private void DoSelectRandomGameObject()
		{
		}

		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0xB70038", Offset = "0xB70038", VA = "0xB70038")]
		public SelectRandomGameObject()
		{
		}
	}
}

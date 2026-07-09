using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A36C4", Offset = "0x5A36C4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A36C4", Offset = "0x5A36C4")]
	public class TouchObject2dEvent : FsmStateAction
	{
		[Token(Token = "0x4004F0A")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E9DF0", Offset = "0x5E9DF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9DF0", Offset = "0x5E9DF0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004F0B")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9E84", Offset = "0x5E9E84")]
		public FsmInt fingerId;

		[Token(Token = "0x4004F0C")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9EBC", Offset = "0x5E9EBC")]
		[Attribute(Name = "ActionSection", RVA = "0x5E9EBC", Offset = "0x5E9EBC")]
		public FsmEvent touchBegan;

		[Token(Token = "0x4004F0D")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9F1C", Offset = "0x5E9F1C")]
		public FsmEvent touchMoved;

		[Token(Token = "0x4004F0E")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9F54", Offset = "0x5E9F54")]
		public FsmEvent touchStationary;

		[Token(Token = "0x4004F0F")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9F8C", Offset = "0x5E9F8C")]
		public FsmEvent touchEnded;

		[Token(Token = "0x4004F10")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9FC4", Offset = "0x5E9FC4")]
		public FsmEvent touchCanceled;

		[Token(Token = "0x4004F11")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ActionSection", RVA = "0x5E9FFC", Offset = "0x5E9FFC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E9FFC", Offset = "0x5E9FFC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9FFC", Offset = "0x5E9FFC")]
		public FsmInt storeFingerId;

		[Token(Token = "0x4004F12")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EA070", Offset = "0x5EA070")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EA070", Offset = "0x5EA070")]
		public FsmVector2 storeHitPoint;

		[Token(Token = "0x60063A4")]
		[Address(RVA = "0xAD6D54", Offset = "0xAD6D54", VA = "0xAD6D54", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063A5")]
		[Address(RVA = "0xAD6DD0", Offset = "0xAD6DD0", VA = "0xAD6DD0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60063A6")]
		[Address(RVA = "0xAD7224", Offset = "0xAD7224", VA = "0xAD7224")]
		public TouchObject2dEvent()
		{
		}
	}
}

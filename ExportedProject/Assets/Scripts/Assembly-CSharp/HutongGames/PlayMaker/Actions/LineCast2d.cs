using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A30B0", Offset = "0x5A30B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A30B0", Offset = "0x5A30B0")]
	public class LineCast2d : FsmStateAction
	{
		[Token(Token = "0x4004E76")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5E7744", Offset = "0x5E7744")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7744", Offset = "0x5E7744")]
		public FsmOwnerDefault fromGameObject;

		[Token(Token = "0x4004E77")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E77A4", Offset = "0x5E77A4")]
		public FsmVector2 fromPosition;

		[Token(Token = "0x4004E78")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E77DC", Offset = "0x5E77DC")]
		public FsmGameObject toGameObject;

		[Token(Token = "0x4004E79")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7814", Offset = "0x5E7814")]
		public FsmVector2 toPosition;

		[Token(Token = "0x4004E7A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E784C", Offset = "0x5E784C")]
		public FsmInt minDepth;

		[Token(Token = "0x4004E7B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7884", Offset = "0x5E7884")]
		public FsmInt maxDepth;

		[Token(Token = "0x4004E7C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ActionSection", RVA = "0x5E78BC", Offset = "0x5E78BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E78BC", Offset = "0x5E78BC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E78BC", Offset = "0x5E78BC")]
		public FsmEvent hitEvent;

		[Token(Token = "0x4004E7D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7930", Offset = "0x5E7930")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7930", Offset = "0x5E7930")]
		public FsmBool storeDidHit;

		[Token(Token = "0x4004E7E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7980", Offset = "0x5E7980")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7980", Offset = "0x5E7980")]
		public FsmGameObject storeHitObject;

		[Token(Token = "0x4004E7F")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E79D0", Offset = "0x5E79D0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E79D0", Offset = "0x5E79D0")]
		public FsmVector2 storeHitPoint;

		[Token(Token = "0x4004E80")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7A20", Offset = "0x5E7A20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7A20", Offset = "0x5E7A20")]
		public FsmVector2 storeHitNormal;

		[Token(Token = "0x4004E81")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7A70", Offset = "0x5E7A70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7A70", Offset = "0x5E7A70")]
		public FsmFloat storeHitDistance;

		[Token(Token = "0x4004E82")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ActionSection", RVA = "0x5E7AC0", Offset = "0x5E7AC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7AC0", Offset = "0x5E7AC0")]
		public FsmInt repeatInterval;

		[Token(Token = "0x4004E83")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E7B20", Offset = "0x5E7B20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7B20", Offset = "0x5E7B20")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004E84")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7B70", Offset = "0x5E7B70")]
		public FsmBool invertMask;

		[Token(Token = "0x4004E85")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7BA8", Offset = "0x5E7BA8")]
		[Attribute(Name = "ActionSection", RVA = "0x5E7BA8", Offset = "0x5E7BA8")]
		public FsmColor debugColor;

		[Token(Token = "0x4004E86")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E7C08", Offset = "0x5E7C08")]
		public FsmBool debug;

		[Token(Token = "0x4004E87")]
		[FieldOffset(Offset = "0xD8")]
		private Transform _fromTrans;

		[Token(Token = "0x4004E88")]
		[FieldOffset(Offset = "0xE0")]
		private Transform _toTrans;

		[Token(Token = "0x4004E89")]
		[FieldOffset(Offset = "0xE8")]
		private int repeat;

		[Token(Token = "0x6006345")]
		[Address(RVA = "0x9C8AC8", Offset = "0x9C8AC8", VA = "0x9C8AC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006346")]
		[Address(RVA = "0x9C8BD4", Offset = "0x9C8BD4", VA = "0x9C8BD4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006347")]
		[Address(RVA = "0x9C91B0", Offset = "0x9C91B0", VA = "0x9C91B0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006348")]
		[Address(RVA = "0x9C8D0C", Offset = "0x9C8D0C", VA = "0x9C8D0C")]
		private void DoRaycast()
		{
		}

		[Token(Token = "0x6006349")]
		[Address(RVA = "0x9C91C8", Offset = "0x9C91C8", VA = "0x9C91C8")]
		public LineCast2d()
		{
		}
	}
}

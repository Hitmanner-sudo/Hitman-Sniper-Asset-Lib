using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001096")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2D90", Offset = "0x5A2D90")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2D90", Offset = "0x5A2D90")]
	public class GetNextOverlapCircle2d : FsmStateAction
	{
		[Token(Token = "0x4004E24")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E610C", Offset = "0x5E610C")]
		[Attribute(Name = "ActionSection", RVA = "0x5E610C", Offset = "0x5E610C")]
		public FsmOwnerDefault fromGameObject;

		[Token(Token = "0x4004E25")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E616C", Offset = "0x5E616C")]
		public FsmVector2 fromPosition;

		[Token(Token = "0x4004E26")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E61A4", Offset = "0x5E61A4")]
		public FsmFloat radius;

		[Token(Token = "0x4004E27")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E61DC", Offset = "0x5E61DC")]
		public FsmInt minDepth;

		[Token(Token = "0x4004E28")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6214", Offset = "0x5E6214")]
		public FsmInt maxDepth;

		[Token(Token = "0x4004E29")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E624C", Offset = "0x5E624C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E624C", Offset = "0x5E624C")]
		public FsmBool resetFlag;

		[Token(Token = "0x4004E2A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E629C", Offset = "0x5E629C")]
		[Attribute(Name = "ActionSection", RVA = "0x5E629C", Offset = "0x5E629C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E629C", Offset = "0x5E629C")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004E2B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6310", Offset = "0x5E6310")]
		public FsmBool invertMask;

		[Token(Token = "0x4004E2C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6348", Offset = "0x5E6348")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6348", Offset = "0x5E6348")]
		[Attribute(Name = "ActionSection", RVA = "0x5E6348", Offset = "0x5E6348")]
		public FsmInt collidersCount;

		[Token(Token = "0x4004E2D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E63BC", Offset = "0x5E63BC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E63BC", Offset = "0x5E63BC")]
		public FsmGameObject storeNextCollider;

		[Token(Token = "0x4004E2E")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E641C", Offset = "0x5E641C")]
		public FsmEvent loopEvent;

		[Token(Token = "0x4004E2F")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6454", Offset = "0x5E6454")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x4004E30")]
		[FieldOffset(Offset = "0xB0")]
		private Collider2D[] colliders;

		[Token(Token = "0x4004E31")]
		[FieldOffset(Offset = "0xB8")]
		private int colliderCount;

		[Token(Token = "0x4004E32")]
		[FieldOffset(Offset = "0xBC")]
		private int nextColliderIndex;

		[Token(Token = "0x6006314")]
		[Address(RVA = "0x1065C80", Offset = "0x1065C80", VA = "0x1065C80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006315")]
		[Address(RVA = "0x1065DA0", Offset = "0x1065DA0", VA = "0x1065DA0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006316")]
		[Address(RVA = "0x10660B4", Offset = "0x10660B4", VA = "0x10660B4")]
		private void DoGetNextCollider()
		{
		}

		[Token(Token = "0x6006317")]
		[Address(RVA = "0x1065E20", Offset = "0x1065E20", VA = "0x1065E20")]
		private Collider2D[] GetOverlapCircleAll()
		{
			return null;
		}

		[Token(Token = "0x6006318")]
		[Address(RVA = "0x106618C", Offset = "0x106618C", VA = "0x106618C")]
		public GetNextOverlapCircle2d()
		{
		}
	}
}

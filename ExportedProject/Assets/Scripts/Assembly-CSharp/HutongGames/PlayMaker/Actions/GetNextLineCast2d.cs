using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001094")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2CF0", Offset = "0x5A2CF0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2CF0", Offset = "0x5A2CF0")]
	public class GetNextLineCast2d : FsmStateAction
	{
		[Token(Token = "0x4004E01")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5E5904", Offset = "0x5E5904")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5904", Offset = "0x5E5904")]
		public FsmOwnerDefault fromGameObject;

		[Token(Token = "0x4004E02")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5964", Offset = "0x5E5964")]
		public FsmVector2 fromPosition;

		[Token(Token = "0x4004E03")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E599C", Offset = "0x5E599C")]
		public FsmGameObject toGameObject;

		[Token(Token = "0x4004E04")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E59D4", Offset = "0x5E59D4")]
		public FsmVector2 toPosition;

		[Token(Token = "0x4004E05")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5A0C", Offset = "0x5E5A0C")]
		public FsmInt minDepth;

		[Token(Token = "0x4004E06")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5A44", Offset = "0x5E5A44")]
		public FsmInt maxDepth;

		[Token(Token = "0x4004E07")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5A7C", Offset = "0x5E5A7C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5A7C", Offset = "0x5E5A7C")]
		public FsmBool resetFlag;

		[Token(Token = "0x4004E08")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ActionSection", RVA = "0x5E5ACC", Offset = "0x5E5ACC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5ACC", Offset = "0x5E5ACC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5ACC", Offset = "0x5E5ACC")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004E09")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5B40", Offset = "0x5E5B40")]
		public FsmBool invertMask;

		[Token(Token = "0x4004E0A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ActionSection", RVA = "0x5E5B78", Offset = "0x5E5B78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5B78", Offset = "0x5E5B78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5B78", Offset = "0x5E5B78")]
		public FsmInt collidersCount;

		[Token(Token = "0x4004E0B")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5BEC", Offset = "0x5E5BEC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5BEC", Offset = "0x5E5BEC")]
		public FsmGameObject storeNextCollider;

		[Token(Token = "0x4004E0C")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5C3C", Offset = "0x5E5C3C")]
		public FsmVector2 storeNextHitPoint;

		[Token(Token = "0x4004E0D")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5C74", Offset = "0x5E5C74")]
		public FsmVector2 storeNextHitNormal;

		[Token(Token = "0x4004E0E")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5CAC", Offset = "0x5E5CAC")]
		public FsmFloat storeNextHitDistance;

		[Token(Token = "0x4004E0F")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5CE4", Offset = "0x5E5CE4")]
		public FsmEvent loopEvent;

		[Token(Token = "0x4004E10")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5D1C", Offset = "0x5E5D1C")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x4004E11")]
		[FieldOffset(Offset = "0xD0")]
		private RaycastHit2D[] hits;

		[Token(Token = "0x4004E12")]
		[FieldOffset(Offset = "0xD8")]
		private int colliderCount;

		[Token(Token = "0x4004E13")]
		[FieldOffset(Offset = "0xDC")]
		private int nextColliderIndex;

		[Token(Token = "0x600630A")]
		[Address(RVA = "0x1064FC0", Offset = "0x1064FC0", VA = "0x1064FC0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600630B")]
		[Address(RVA = "0x10650F4", Offset = "0x10650F4", VA = "0x10650F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600630C")]
		[Address(RVA = "0x1065488", Offset = "0x1065488", VA = "0x1065488")]
		private void DoGetNextCollider()
		{
		}

		[Token(Token = "0x600630D")]
		[Address(RVA = "0x1065174", Offset = "0x1065174", VA = "0x1065174")]
		private RaycastHit2D[] GetLineCastAll()
		{
			return null;
		}

		[Token(Token = "0x600630E")]
		[Address(RVA = "0x10656E4", Offset = "0x10656E4", VA = "0x10656E4")]
		public GetNextLineCast2d()
		{
		}
	}
}

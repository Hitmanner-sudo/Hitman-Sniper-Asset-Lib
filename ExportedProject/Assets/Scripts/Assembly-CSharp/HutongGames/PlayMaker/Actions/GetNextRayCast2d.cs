using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001098")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2E30", Offset = "0x5A2E30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2E30", Offset = "0x5A2E30")]
	public class GetNextRayCast2d : FsmStateAction
	{
		[Token(Token = "0x4004E41")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E67D4", Offset = "0x5E67D4")]
		[Attribute(Name = "ActionSection", RVA = "0x5E67D4", Offset = "0x5E67D4")]
		public FsmOwnerDefault fromGameObject;

		[Token(Token = "0x4004E42")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6834", Offset = "0x5E6834")]
		public FsmVector2 fromPosition;

		[Token(Token = "0x4004E43")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E686C", Offset = "0x5E686C")]
		public FsmVector2 direction;

		[Token(Token = "0x4004E44")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E68A4", Offset = "0x5E68A4")]
		public Space space;

		[Token(Token = "0x4004E45")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E68DC", Offset = "0x5E68DC")]
		public FsmFloat distance;

		[Token(Token = "0x4004E46")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6914", Offset = "0x5E6914")]
		public FsmInt minDepth;

		[Token(Token = "0x4004E47")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E694C", Offset = "0x5E694C")]
		public FsmInt maxDepth;

		[Token(Token = "0x4004E48")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6984", Offset = "0x5E6984")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6984", Offset = "0x5E6984")]
		public FsmBool resetFlag;

		[Token(Token = "0x4004E49")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E69D4", Offset = "0x5E69D4")]
		[Attribute(Name = "ActionSection", RVA = "0x5E69D4", Offset = "0x5E69D4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E69D4", Offset = "0x5E69D4")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004E4A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6A48", Offset = "0x5E6A48")]
		public FsmBool invertMask;

		[Token(Token = "0x4004E4B")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ActionSection", RVA = "0x5E6A80", Offset = "0x5E6A80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6A80", Offset = "0x5E6A80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6A80", Offset = "0x5E6A80")]
		public FsmInt collidersCount;

		[Token(Token = "0x4004E4C")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6AF4", Offset = "0x5E6AF4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6AF4", Offset = "0x5E6AF4")]
		public FsmGameObject storeNextCollider;

		[Token(Token = "0x4004E4D")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6B44", Offset = "0x5E6B44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6B44", Offset = "0x5E6B44")]
		public FsmVector2 storeNextHitPoint;

		[Token(Token = "0x4004E4E")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6B94", Offset = "0x5E6B94")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6B94", Offset = "0x5E6B94")]
		public FsmVector2 storeNextHitNormal;

		[Token(Token = "0x4004E4F")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6BE4", Offset = "0x5E6BE4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6BE4", Offset = "0x5E6BE4")]
		public FsmFloat storeNextHitDistance;

		[Token(Token = "0x4004E50")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6C34", Offset = "0x5E6C34")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6C34", Offset = "0x5E6C34")]
		public FsmFloat storeNextHitFraction;

		[Token(Token = "0x4004E51")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6C84", Offset = "0x5E6C84")]
		public FsmEvent loopEvent;

		[Token(Token = "0x4004E52")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6CBC", Offset = "0x5E6CBC")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x4004E53")]
		[FieldOffset(Offset = "0xE0")]
		private RaycastHit2D[] hits;

		[Token(Token = "0x4004E54")]
		[FieldOffset(Offset = "0xE8")]
		private int colliderCount;

		[Token(Token = "0x4004E55")]
		[FieldOffset(Offset = "0xEC")]
		private int nextColliderIndex;

		[Token(Token = "0x600631E")]
		[Address(RVA = "0x1066654", Offset = "0x1066654", VA = "0x1066654", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600631F")]
		[Address(RVA = "0x1066790", Offset = "0x1066790", VA = "0x1066790", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006320")]
		[Address(RVA = "0x1066BE8", Offset = "0x1066BE8", VA = "0x1066BE8")]
		private void DoGetNextCollider()
		{
		}

		[Token(Token = "0x6006321")]
		[Address(RVA = "0x1066810", Offset = "0x1066810", VA = "0x1066810")]
		private RaycastHit2D[] GetRayCastAll()
		{
			return null;
		}

		[Token(Token = "0x6006322")]
		[Address(RVA = "0x1066E7C", Offset = "0x1066E7C", VA = "0x1066E7C")]
		public GetNextRayCast2d()
		{
		}
	}
}

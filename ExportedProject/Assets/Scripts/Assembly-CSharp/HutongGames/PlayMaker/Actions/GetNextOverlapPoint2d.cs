using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001097")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2DE0", Offset = "0x5A2DE0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2DE0", Offset = "0x5A2DE0")]
	public class GetNextOverlapPoint2d : FsmStateAction
	{
		[Token(Token = "0x4004E33")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5E648C", Offset = "0x5E648C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E648C", Offset = "0x5E648C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004E34")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E64EC", Offset = "0x5E64EC")]
		public FsmVector2 position;

		[Token(Token = "0x4004E35")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6524", Offset = "0x5E6524")]
		public FsmInt minDepth;

		[Token(Token = "0x4004E36")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E655C", Offset = "0x5E655C")]
		public FsmInt maxDepth;

		[Token(Token = "0x4004E37")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6594", Offset = "0x5E6594")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6594", Offset = "0x5E6594")]
		public FsmBool resetFlag;

		[Token(Token = "0x4004E38")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E65E4", Offset = "0x5E65E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E65E4", Offset = "0x5E65E4")]
		[Attribute(Name = "ActionSection", RVA = "0x5E65E4", Offset = "0x5E65E4")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004E39")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6658", Offset = "0x5E6658")]
		public FsmBool invertMask;

		[Token(Token = "0x4004E3A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ActionSection", RVA = "0x5E6690", Offset = "0x5E6690")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6690", Offset = "0x5E6690")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6690", Offset = "0x5E6690")]
		public FsmInt collidersCount;

		[Token(Token = "0x4004E3B")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6704", Offset = "0x5E6704")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E6704", Offset = "0x5E6704")]
		[RequiredField]
		public FsmGameObject storeNextCollider;

		[Token(Token = "0x4004E3C")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E6764", Offset = "0x5E6764")]
		public FsmEvent loopEvent;

		[Token(Token = "0x4004E3D")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E679C", Offset = "0x5E679C")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x4004E3E")]
		[FieldOffset(Offset = "0xA8")]
		private Collider2D[] colliders;

		[Token(Token = "0x4004E3F")]
		[FieldOffset(Offset = "0xB0")]
		private int colliderCount;

		[Token(Token = "0x4004E40")]
		[FieldOffset(Offset = "0xB4")]
		private int nextColliderIndex;

		[Token(Token = "0x6006319")]
		[Address(RVA = "0x1066194", Offset = "0x1066194", VA = "0x1066194", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600631A")]
		[Address(RVA = "0x10662A4", Offset = "0x10662A4", VA = "0x10662A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600631B")]
		[Address(RVA = "0x106657C", Offset = "0x106657C", VA = "0x106657C")]
		private void DoGetNextCollider()
		{
		}

		[Token(Token = "0x600631C")]
		[Address(RVA = "0x1066324", Offset = "0x1066324", VA = "0x1066324")]
		private Collider2D[] GetOverlapPointAll()
		{
			return null;
		}

		[Token(Token = "0x600631D")]
		[Address(RVA = "0x106664C", Offset = "0x106664C", VA = "0x106664C")]
		public GetNextOverlapPoint2d()
		{
		}
	}
}

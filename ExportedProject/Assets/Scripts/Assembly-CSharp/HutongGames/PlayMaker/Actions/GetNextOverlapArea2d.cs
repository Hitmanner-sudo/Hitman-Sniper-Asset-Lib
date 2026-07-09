using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001095")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2D40", Offset = "0x5A2D40")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2D40", Offset = "0x5A2D40")]
	public class GetNextOverlapArea2d : FsmStateAction
	{
		[Token(Token = "0x4004E14")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5E5D54", Offset = "0x5E5D54")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5D54", Offset = "0x5E5D54")]
		public FsmOwnerDefault firstCornerGameObject;

		[Token(Token = "0x4004E15")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5DB4", Offset = "0x5E5DB4")]
		public FsmVector2 firstCornerPosition;

		[Token(Token = "0x4004E16")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5DEC", Offset = "0x5E5DEC")]
		public FsmGameObject secondCornerGameObject;

		[Token(Token = "0x4004E17")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5E24", Offset = "0x5E5E24")]
		public FsmVector2 secondCornerPosition;

		[Token(Token = "0x4004E18")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5E5C", Offset = "0x5E5E5C")]
		public FsmInt minDepth;

		[Token(Token = "0x4004E19")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5E94", Offset = "0x5E5E94")]
		public FsmInt maxDepth;

		[Token(Token = "0x4004E1A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5ECC", Offset = "0x5E5ECC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5ECC", Offset = "0x5E5ECC")]
		public FsmBool resetFlag;

		[Token(Token = "0x4004E1B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5F1C", Offset = "0x5E5F1C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5F1C", Offset = "0x5E5F1C")]
		[Attribute(Name = "ActionSection", RVA = "0x5E5F1C", Offset = "0x5E5F1C")]
		public FsmInt[] layerMask;

		[Token(Token = "0x4004E1C")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5F90", Offset = "0x5E5F90")]
		public FsmBool invertMask;

		[Token(Token = "0x4004E1D")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5FC8", Offset = "0x5E5FC8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E5FC8", Offset = "0x5E5FC8")]
		[Attribute(Name = "ActionSection", RVA = "0x5E5FC8", Offset = "0x5E5FC8")]
		public FsmInt collidersCount;

		[Token(Token = "0x4004E1E")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E603C", Offset = "0x5E603C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E603C", Offset = "0x5E603C")]
		[RequiredField]
		public FsmGameObject storeNextCollider;

		[Token(Token = "0x4004E1F")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E609C", Offset = "0x5E609C")]
		public FsmEvent loopEvent;

		[Token(Token = "0x4004E20")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E60D4", Offset = "0x5E60D4")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x4004E21")]
		[FieldOffset(Offset = "0xB8")]
		private Collider2D[] colliders;

		[Token(Token = "0x4004E22")]
		[FieldOffset(Offset = "0xC0")]
		private int colliderCount;

		[Token(Token = "0x4004E23")]
		[FieldOffset(Offset = "0xC4")]
		private int nextColliderIndex;

		[Token(Token = "0x600630F")]
		[Address(RVA = "0x10656EC", Offset = "0x10656EC", VA = "0x10656EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006310")]
		[Address(RVA = "0x106581C", Offset = "0x106581C", VA = "0x106581C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006311")]
		[Address(RVA = "0x1065BA8", Offset = "0x1065BA8", VA = "0x1065BA8")]
		private void DoGetNextCollider()
		{
		}

		[Token(Token = "0x6006312")]
		[Address(RVA = "0x106589C", Offset = "0x106589C", VA = "0x106589C")]
		private Collider2D[] GetOverlapAreaAll()
		{
			return null;
		}

		[Token(Token = "0x6006313")]
		[Address(RVA = "0x1065C78", Offset = "0x1065C78", VA = "0x1065C78")]
		public GetNextOverlapArea2d()
		{
		}
	}
}

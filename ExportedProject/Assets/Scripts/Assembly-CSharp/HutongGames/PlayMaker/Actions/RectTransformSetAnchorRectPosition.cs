using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4CFC", Offset = "0x5A4CFC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4CFC", Offset = "0x5A4CFC")]
	public class RectTransformSetAnchorRectPosition : BaseUpdateAction
	{
		[Token(Token = "0x20010F5")]
		public enum AnchorReference
		{
			[Token(Token = "0x4005039")]
			TopLeft = 0,
			[Token(Token = "0x400503A")]
			Top = 1,
			[Token(Token = "0x400503B")]
			TopRight = 2,
			[Token(Token = "0x400503C")]
			Right = 3,
			[Token(Token = "0x400503D")]
			BottomRight = 4,
			[Token(Token = "0x400503E")]
			Bottom = 5,
			[Token(Token = "0x400503F")]
			BottomLeft = 6,
			[Token(Token = "0x4005040")]
			Left = 7,
			[Token(Token = "0x4005041")]
			Center = 8
		}

		[Token(Token = "0x4005030")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EF048", Offset = "0x5EF048")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF048", Offset = "0x5EF048")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005031")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF0DC", Offset = "0x5EF0DC")]
		public AnchorReference anchorReference;

		[Token(Token = "0x4005032")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF114", Offset = "0x5EF114")]
		public FsmBool normalized;

		[Token(Token = "0x4005033")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF14C", Offset = "0x5EF14C")]
		public FsmVector2 anchor;

		[Token(Token = "0x4005034")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF184", Offset = "0x5EF184")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EF184", Offset = "0x5EF184")]
		public FsmFloat x;

		[Token(Token = "0x4005035")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EF1D8", Offset = "0x5EF1D8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF1D8", Offset = "0x5EF1D8")]
		public FsmFloat y;

		[Token(Token = "0x4005036")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform _rt;

		[Token(Token = "0x4005037")]
		[FieldOffset(Offset = "0x88")]
		private Rect _anchorRect;

		[Token(Token = "0x60064E4")]
		[Address(RVA = "0x96052C", Offset = "0x96052C", VA = "0x96052C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064E5")]
		[Address(RVA = "0x9605EC", Offset = "0x9605EC", VA = "0x9605EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064E6")]
		[Address(RVA = "0x9609A8", Offset = "0x9609A8", VA = "0x9609A8", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064E7")]
		[Address(RVA = "0x9606C8", Offset = "0x9606C8", VA = "0x9606C8")]
		private void DoSetAnchor()
		{
		}

		[Token(Token = "0x60064E8")]
		[Address(RVA = "0x9609AC", Offset = "0x9609AC", VA = "0x9609AC")]
		public RectTransformSetAnchorRectPosition()
		{
		}
	}
}

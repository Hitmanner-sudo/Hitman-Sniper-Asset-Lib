using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010F6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4D5C", Offset = "0x5A4D5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4D5C", Offset = "0x5A4D5C")]
	public class RectTransformSetAnchoredPosition : BaseUpdateAction
	{
		[Token(Token = "0x4005042")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EF22C", Offset = "0x5EF22C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF22C", Offset = "0x5EF22C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005043")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF2C0", Offset = "0x5EF2C0")]
		public FsmVector2 position;

		[Token(Token = "0x4005044")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF2F8", Offset = "0x5EF2F8")]
		public FsmFloat x;

		[Token(Token = "0x4005045")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EF330", Offset = "0x5EF330")]
		public FsmFloat y;

		[Token(Token = "0x4005046")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x60064E9")]
		[Address(RVA = "0x9609B4", Offset = "0x9609B4", VA = "0x9609B4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064EA")]
		[Address(RVA = "0x960A58", Offset = "0x960A58", VA = "0x960A58", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064EB")]
		[Address(RVA = "0x960BF8", Offset = "0x960BF8", VA = "0x960BF8", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064EC")]
		[Address(RVA = "0x960B34", Offset = "0x960B34", VA = "0x960B34")]
		private void DoSetAnchoredPosition()
		{
		}

		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x960BFC", Offset = "0x960BFC", VA = "0x960BFC")]
		public RectTransformSetAnchoredPosition()
		{
		}
	}
}

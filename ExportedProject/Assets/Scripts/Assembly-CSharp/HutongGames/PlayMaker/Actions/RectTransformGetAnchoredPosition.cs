using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A475C", Offset = "0x5A475C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A475C", Offset = "0x5A475C")]
	public class RectTransformGetAnchoredPosition : BaseUpdateAction
	{
		[Token(Token = "0x4004FC8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED34C", Offset = "0x5ED34C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ED34C", Offset = "0x5ED34C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FC9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED3E0", Offset = "0x5ED3E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED3E0", Offset = "0x5ED3E0")]
		public FsmVector2 position;

		[Token(Token = "0x4004FCA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED430", Offset = "0x5ED430")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED430", Offset = "0x5ED430")]
		public FsmFloat x;

		[Token(Token = "0x4004FCB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED480", Offset = "0x5ED480")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED480", Offset = "0x5ED480")]
		public FsmFloat y;

		[Token(Token = "0x4004FCC")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x6006499")]
		[Address(RVA = "0xB45080", Offset = "0xB45080", VA = "0xB45080", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600649A")]
		[Address(RVA = "0xB450AC", Offset = "0xB450AC", VA = "0xB450AC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600649B")]
		[Address(RVA = "0xB45238", Offset = "0xB45238", VA = "0xB45238", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x600649C")]
		[Address(RVA = "0xB45188", Offset = "0xB45188", VA = "0xB45188")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x600649D")]
		[Address(RVA = "0xB4523C", Offset = "0xB4523C", VA = "0xB4523C")]
		public RectTransformGetAnchoredPosition()
		{
		}
	}
}

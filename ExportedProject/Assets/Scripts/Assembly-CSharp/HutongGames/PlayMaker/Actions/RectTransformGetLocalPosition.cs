using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010E5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A47BC", Offset = "0x5A47BC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A47BC", Offset = "0x5A47BC")]
	public class RectTransformGetLocalPosition : BaseUpdateAction
	{
		[Token(Token = "0x20010E6")]
		public enum LocalPositionReference
		{
			[Token(Token = "0x4004FD6")]
			Anchor = 0,
			[Token(Token = "0x4004FD7")]
			CenterPosition = 1
		}

		[Token(Token = "0x4004FCD")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5ED4D0", Offset = "0x5ED4D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED4D0", Offset = "0x5ED4D0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FCE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED564", Offset = "0x5ED564")]
		public LocalPositionReference reference;

		[Token(Token = "0x4004FCF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED59C", Offset = "0x5ED59C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED59C", Offset = "0x5ED59C")]
		public FsmVector3 position;

		[Token(Token = "0x4004FD0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED5EC", Offset = "0x5ED5EC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED5EC", Offset = "0x5ED5EC")]
		public FsmVector2 position2d;

		[Token(Token = "0x4004FD1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED63C", Offset = "0x5ED63C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED63C", Offset = "0x5ED63C")]
		public FsmFloat x;

		[Token(Token = "0x4004FD2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED68C", Offset = "0x5ED68C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED68C", Offset = "0x5ED68C")]
		public FsmFloat y;

		[Token(Token = "0x4004FD3")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5ED6DC", Offset = "0x5ED6DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5ED6DC", Offset = "0x5ED6DC")]
		public FsmFloat z;

		[Token(Token = "0x4004FD4")]
		[FieldOffset(Offset = "0x88")]
		private RectTransform _rt;

		[Token(Token = "0x600649E")]
		[Address(RVA = "0xB45244", Offset = "0xB45244", VA = "0xB45244", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600649F")]
		[Address(RVA = "0xB4527C", Offset = "0xB4527C", VA = "0xB4527C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064A0")]
		[Address(RVA = "0xB45508", Offset = "0xB45508", VA = "0xB45508", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064A1")]
		[Address(RVA = "0xB45358", Offset = "0xB45358", VA = "0xB45358")]
		private void DoGetValues()
		{
		}

		[Token(Token = "0x60064A2")]
		[Address(RVA = "0xB4550C", Offset = "0xB4550C", VA = "0xB4550C")]
		public RectTransformGetLocalPosition()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010FC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4F9C", Offset = "0x5A4F9C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4F9C", Offset = "0x5A4F9C")]
	public class RectTransformSetScreenPosition : BaseUpdateAction
	{
		[Token(Token = "0x4005064")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EFA74", Offset = "0x5EFA74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFA74", Offset = "0x5EFA74")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005065")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFB08", Offset = "0x5EFB08")]
		public FsmVector2 screenPosition;

		[Token(Token = "0x4005066")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFB40", Offset = "0x5EFB40")]
		public FsmFloat x;

		[Token(Token = "0x4005067")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFB78", Offset = "0x5EFB78")]
		public FsmFloat y;

		[Token(Token = "0x4005068")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EFBB0", Offset = "0x5EFBB0")]
		public FsmBool normalized;

		[Token(Token = "0x4005069")]
		[FieldOffset(Offset = "0x78")]
		private GameObject cachedGameObject;

		[Token(Token = "0x400506A")]
		[FieldOffset(Offset = "0x80")]
		private RectTransform _rt;

		[Token(Token = "0x400506B")]
		[FieldOffset(Offset = "0x88")]
		private Canvas rootCanvas;

		[Token(Token = "0x400506C")]
		[FieldOffset(Offset = "0x90")]
		private RectTransform rootRectTransform;

		[Token(Token = "0x400506D")]
		[FieldOffset(Offset = "0x98")]
		private Camera canvasCamera;

		[Token(Token = "0x6006507")]
		[Address(RVA = "0x961A18", Offset = "0x961A18", VA = "0x961A18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006508")]
		[Address(RVA = "0x961AF4", Offset = "0x961AF4", VA = "0x961AF4")]
		private bool UpdateCache()
		{
			return default(bool);
		}

		[Token(Token = "0x6006509")]
		[Address(RVA = "0x961C84", Offset = "0x961C84", VA = "0x961C84", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600650A")]
		[Address(RVA = "0x961EC8", Offset = "0x961EC8", VA = "0x961EC8", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x600650B")]
		[Address(RVA = "0x961CCC", Offset = "0x961CCC", VA = "0x961CCC")]
		private void DoSetScreenPosition()
		{
		}

		[Token(Token = "0x600650C")]
		[Address(RVA = "0x961ECC", Offset = "0x961ECC", VA = "0x961ECC")]
		public RectTransformSetScreenPosition()
		{
		}
	}
}

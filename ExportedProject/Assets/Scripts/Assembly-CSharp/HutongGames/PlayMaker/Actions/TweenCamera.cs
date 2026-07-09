using HutongGames.PlayMaker.TweenEnums;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011CB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9A1C", Offset = "0x5A9A1C")]
	[Attribute(Name = "ActionTarget", RVA = "0x5A9A1C", Offset = "0x5A9A1C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9A1C", Offset = "0x5A9A1C")]
	public class TweenCamera : TweenComponentBase<Camera>
	{
		[Token(Token = "0x20011CC")]
		public enum CameraProperty
		{
			[Token(Token = "0x4005505")]
			Aspect = 0,
			[Token(Token = "0x4005506")]
			BackgroundColor = 1,
			[Token(Token = "0x4005507")]
			FieldOfView = 2,
			[Token(Token = "0x4005508")]
			OrthoSize = 3,
			[Token(Token = "0x4005509")]
			PixelRect = 4,
			[Token(Token = "0x400550A")]
			ViewportRect = 5
		}

		[Token(Token = "0x40054F8")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF47C", Offset = "0x5FF47C")]
		public CameraProperty property;

		[Token(Token = "0x40054F9")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF4B4", Offset = "0x5FF4B4")]
		public TweenDirection tweenDirection;

		[Token(Token = "0x40054FA")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF4EC", Offset = "0x5FF4EC")]
		public FsmColor targetColor;

		[Token(Token = "0x40054FB")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF524", Offset = "0x5FF524")]
		public FsmFloat targetFloat;

		[Token(Token = "0x40054FC")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FF55C", Offset = "0x5FF55C")]
		public FsmRect targetRect;

		[Token(Token = "0x40054FD")]
		[FieldOffset(Offset = "0xE8")]
		private Camera camera;

		[Token(Token = "0x40054FE")]
		[FieldOffset(Offset = "0xF0")]
		private Color fromColor;

		[Token(Token = "0x40054FF")]
		[FieldOffset(Offset = "0x100")]
		private Color toColor;

		[Token(Token = "0x4005500")]
		[FieldOffset(Offset = "0x110")]
		private float fromFloat;

		[Token(Token = "0x4005501")]
		[FieldOffset(Offset = "0x114")]
		private float toFloat;

		[Token(Token = "0x4005502")]
		[FieldOffset(Offset = "0x118")]
		private Rect fromRect;

		[Token(Token = "0x4005503")]
		[FieldOffset(Offset = "0x128")]
		private Rect toRect;

		[Token(Token = "0x60068B9")]
		[Address(RVA = "0xCAC154", Offset = "0xCAC154", VA = "0xCAC154", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60068BA")]
		[Address(RVA = "0xCAC1B8", Offset = "0xCAC1B8", VA = "0xCAC1B8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60068BB")]
		[Address(RVA = "0xCAC44C", Offset = "0xCAC44C", VA = "0xCAC44C", Slot = "63")]
		protected override void DoTween()
		{
		}

		[Token(Token = "0x60068BC")]
		[Address(RVA = "0xCAC7C8", Offset = "0xCAC7C8", VA = "0xCAC7C8")]
		public TweenCamera()
		{
		}
	}
}

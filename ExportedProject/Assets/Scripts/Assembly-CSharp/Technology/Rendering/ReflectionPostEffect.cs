using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Rendering
{
	[Token(Token = "0x2000BA0")]
	[ExecuteInEditMode]
	public class ReflectionPostEffect : ImageEffectBase
	{
		[NonSerialized]
		[Token(Token = "0x4003AB6")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 TopLeft;

		[NonSerialized]
		[Token(Token = "0x4003AB7")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 TopRight;

		[NonSerialized]
		[Token(Token = "0x4003AB8")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 BottomLeft;

		[NonSerialized]
		[Token(Token = "0x4003AB9")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 BottomRight;

		[Token(Token = "0x60049E7")]
		[Address(RVA = "0x962EBC", Offset = "0x962EBC", VA = "0x962EBC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60049E8")]
		[Address(RVA = "0x962F10", Offset = "0x962F10", VA = "0x962F10")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60049E9")]
		[Address(RVA = "0x96309C", Offset = "0x96309C", VA = "0x96309C")]
		public ReflectionPostEffect()
		{
		}
	}
}

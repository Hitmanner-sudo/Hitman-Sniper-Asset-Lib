using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EBA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599990", Offset = "0x599990")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599990", Offset = "0x599990")]
	public class CapturePoseAsAnimationClip : FsmStateAction
	{
		[Token(Token = "0x40045BC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C28D4", Offset = "0x5C28D4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C28D4", Offset = "0x5C28D4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045BD")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2968", Offset = "0x5C2968")]
		public FsmBool position;

		[Token(Token = "0x40045BE")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C29A0", Offset = "0x5C29A0")]
		public FsmBool rotation;

		[Token(Token = "0x40045BF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C29D8", Offset = "0x5C29D8")]
		public FsmBool scale;

		[Token(Token = "0x40045C0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2A10", Offset = "0x5C2A10")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5C2A10", Offset = "0x5C2A10")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C2A10", Offset = "0x5C2A10")]
		public FsmObject storeAnimationClip;

		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0xAF2474", Offset = "0xAF2474", VA = "0xAF2474", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B00")]
		[Address(RVA = "0xAF24C4", Offset = "0xAF24C4", VA = "0xAF24C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B01")]
		[Address(RVA = "0xAF24EC", Offset = "0xAF24EC", VA = "0xAF24EC")]
		private void DoCaptureAnimationClip()
		{
		}

		[Token(Token = "0x6005B02")]
		[Address(RVA = "0xAF2844", Offset = "0xAF2844", VA = "0xAF2844")]
		private void CaptureTransform(Transform transform, string path, AnimationClip clip)
		{
		}

		[Token(Token = "0x6005B03")]
		[Address(RVA = "0xAF2BC4", Offset = "0xAF2BC4", VA = "0xAF2BC4")]
		private void CapturePosition(Transform transform, string path, AnimationClip clip)
		{
		}

		[Token(Token = "0x6005B04")]
		[Address(RVA = "0xAF2CA0", Offset = "0xAF2CA0", VA = "0xAF2CA0")]
		private void CaptureRotation(Transform transform, string path, AnimationClip clip)
		{
		}

		[Token(Token = "0x6005B05")]
		[Address(RVA = "0xAF2DB0", Offset = "0xAF2DB0", VA = "0xAF2DB0")]
		private void CaptureScale(Transform transform, string path, AnimationClip clip)
		{
		}

		[Token(Token = "0x6005B06")]
		[Address(RVA = "0xAF2E8C", Offset = "0xAF2E8C", VA = "0xAF2E8C")]
		private void SetConstantCurve(AnimationClip clip, string childPath, string propertyPath, float value)
		{
		}

		[Token(Token = "0x6005B07")]
		[Address(RVA = "0xAF2F80", Offset = "0xAF2F80", VA = "0xAF2F80")]
		public CapturePoseAsAnimationClip()
		{
		}
	}
}

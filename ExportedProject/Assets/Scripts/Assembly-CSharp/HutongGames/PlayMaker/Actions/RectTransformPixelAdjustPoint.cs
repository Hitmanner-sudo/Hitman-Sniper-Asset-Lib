using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010ED")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4A5C", Offset = "0x5A4A5C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4A5C", Offset = "0x5A4A5C")]
	public class RectTransformPixelAdjustPoint : BaseUpdateAction
	{
		[Token(Token = "0x4004FF9")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE0D4", Offset = "0x5EE0D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE0D4", Offset = "0x5EE0D4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004FFA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE168", Offset = "0x5EE168")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE168", Offset = "0x5EE168")]
		[RequiredField]
		public FsmGameObject canvas;

		[Token(Token = "0x4004FFB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE1FC", Offset = "0x5EE1FC")]
		public FsmVector2 screenPoint;

		[Token(Token = "0x4004FFC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE234", Offset = "0x5EE234")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE234", Offset = "0x5EE234")]
		[RequiredField]
		[Attribute(Name = "ActionSection", RVA = "0x5EE234", Offset = "0x5EE234")]
		public FsmVector2 pixelPoint;

		[Token(Token = "0x4004FFD")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform _rt;

		[Token(Token = "0x4004FFE")]
		[FieldOffset(Offset = "0x78")]
		private Canvas _canvas;

		[Token(Token = "0x60064C1")]
		[Address(RVA = "0xB46284", Offset = "0xB46284", VA = "0xB46284", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064C2")]
		[Address(RVA = "0xB46304", Offset = "0xB46304", VA = "0xB46304", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064C3")]
		[Address(RVA = "0xB465E0", Offset = "0xB465E0", VA = "0xB465E0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064C4")]
		[Address(RVA = "0xB4653C", Offset = "0xB4653C", VA = "0xB4653C")]
		private void DoAction()
		{
		}

		[Token(Token = "0x60064C5")]
		[Address(RVA = "0xB465E4", Offset = "0xB465E4", VA = "0xB465E4")]
		public RectTransformPixelAdjustPoint()
		{
		}
	}
}

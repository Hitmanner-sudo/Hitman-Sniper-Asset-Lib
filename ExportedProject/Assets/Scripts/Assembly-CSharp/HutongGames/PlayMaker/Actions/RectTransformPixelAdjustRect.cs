using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010EE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A4ABC", Offset = "0x5A4ABC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A4ABC", Offset = "0x5A4ABC")]
	public class RectTransformPixelAdjustRect : BaseUpdateAction
	{
		[Token(Token = "0x4004FFF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE2B8", Offset = "0x5EE2B8")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE2B8", Offset = "0x5EE2B8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005000")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE34C", Offset = "0x5EE34C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5EE34C", Offset = "0x5EE34C")]
		[RequiredField]
		public FsmGameObject canvas;

		[Token(Token = "0x4005001")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EE3E0", Offset = "0x5EE3E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EE3E0", Offset = "0x5EE3E0")]
		[Attribute(Name = "ActionSection", RVA = "0x5EE3E0", Offset = "0x5EE3E0")]
		public FsmRect pixelRect;

		[Token(Token = "0x4005002")]
		[FieldOffset(Offset = "0x68")]
		private RectTransform _rt;

		[Token(Token = "0x4005003")]
		[FieldOffset(Offset = "0x70")]
		private Canvas _canvas;

		[Token(Token = "0x60064C6")]
		[Address(RVA = "0xB465EC", Offset = "0xB465EC", VA = "0xB465EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60064C7")]
		[Address(RVA = "0xB46668", Offset = "0xB46668", VA = "0xB46668", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60064C8")]
		[Address(RVA = "0xB4692C", Offset = "0xB4692C", VA = "0xB4692C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x60064C9")]
		[Address(RVA = "0xB468A0", Offset = "0xB468A0", VA = "0xB468A0")]
		private void DoAction()
		{
		}

		[Token(Token = "0x60064CA")]
		[Address(RVA = "0xB46930", Offset = "0xB46930", VA = "0xB46930")]
		public RectTransformPixelAdjustRect()
		{
		}
	}
}

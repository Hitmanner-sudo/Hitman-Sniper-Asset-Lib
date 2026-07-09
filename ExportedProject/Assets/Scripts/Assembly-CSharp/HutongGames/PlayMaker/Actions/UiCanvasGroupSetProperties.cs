using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA0F4", Offset = "0x5AA0F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA0F4", Offset = "0x5AA0F4")]
	public class UiCanvasGroupSetProperties : ComponentAction<CanvasGroup>
	{
		[Token(Token = "0x4005589")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600310", Offset = "0x600310")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x600310", Offset = "0x600310")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400558A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6003A4", Offset = "0x6003A4")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x6003A4", Offset = "0x6003A4")]
		public FsmFloat alpha;

		[Token(Token = "0x400558B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6003F8", Offset = "0x6003F8")]
		public FsmBool interactable;

		[Token(Token = "0x400558C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600430", Offset = "0x600430")]
		public FsmBool blocksRaycasts;

		[Token(Token = "0x400558D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600468", Offset = "0x600468")]
		public FsmBool ignoreParentGroup;

		[Token(Token = "0x400558E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6004A0", Offset = "0x6004A0")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400558F")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6004D8", Offset = "0x6004D8")]
		public bool everyFrame;

		[Token(Token = "0x4005590")]
		[FieldOffset(Offset = "0xA0")]
		private CanvasGroup component;

		[Token(Token = "0x4005591")]
		[FieldOffset(Offset = "0xA8")]
		private float originalAlpha;

		[Token(Token = "0x4005592")]
		[FieldOffset(Offset = "0xAC")]
		private bool originalInteractable;

		[Token(Token = "0x4005593")]
		[FieldOffset(Offset = "0xAD")]
		private bool originalBlocksRaycasts;

		[Token(Token = "0x4005594")]
		[FieldOffset(Offset = "0xAE")]
		private bool originalIgnoreParentGroup;

		[Token(Token = "0x600692C")]
		[Address(RVA = "0x1177CFC", Offset = "0x1177CFC", VA = "0x1177CFC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600692D")]
		[Address(RVA = "0x1177DF0", Offset = "0x1177DF0", VA = "0x1177DF0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600692E")]
		[Address(RVA = "0x117809C", Offset = "0x117809C", VA = "0x117809C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600692F")]
		[Address(RVA = "0x1177F30", Offset = "0x1177F30", VA = "0x1177F30")]
		private void DoAction()
		{
		}

		[Token(Token = "0x6006930")]
		[Address(RVA = "0x11780A0", Offset = "0x11780A0", VA = "0x11780A0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006931")]
		[Address(RVA = "0x11781D4", Offset = "0x11781D4", VA = "0x11781D4")]
		public UiCanvasGroupSetProperties()
		{
		}
	}
}

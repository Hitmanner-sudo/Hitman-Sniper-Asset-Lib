using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA284", Offset = "0x5AA284")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA284", Offset = "0x5AA284")]
	public class UiGetLastPointerDataInfo : FsmStateAction
	{
		[Token(Token = "0x40055BE")]
		[FieldOffset(Offset = "0x0")]
		public static PointerEventData lastPointerEventData;

		[Token(Token = "0x40055BF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600AD4", Offset = "0x600AD4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600AD4", Offset = "0x600AD4")]
		public FsmInt clickCount;

		[Token(Token = "0x40055C0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600B24", Offset = "0x600B24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600B24", Offset = "0x600B24")]
		public FsmFloat clickTime;

		[Token(Token = "0x40055C1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600B74", Offset = "0x600B74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600B74", Offset = "0x600B74")]
		public FsmVector2 delta;

		[Token(Token = "0x40055C2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600BC4", Offset = "0x600BC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600BC4", Offset = "0x600BC4")]
		public FsmBool dragging;

		[Token(Token = "0x40055C3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x600C14", Offset = "0x600C14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600C14", Offset = "0x600C14")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600C14", Offset = "0x600C14")]
		public FsmEnum inputButton;

		[Token(Token = "0x40055C4")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600CAC", Offset = "0x600CAC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600CAC", Offset = "0x600CAC")]
		public FsmBool eligibleForClick;

		[Token(Token = "0x40055C5")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600CFC", Offset = "0x600CFC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600CFC", Offset = "0x600CFC")]
		public FsmGameObject enterEventCamera;

		[Token(Token = "0x40055C6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600D4C", Offset = "0x600D4C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600D4C", Offset = "0x600D4C")]
		public FsmGameObject pressEventCamera;

		[Token(Token = "0x40055C7")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600D9C", Offset = "0x600D9C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600D9C", Offset = "0x600D9C")]
		public FsmBool isPointerMoving;

		[Token(Token = "0x40055C8")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600DEC", Offset = "0x600DEC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600DEC", Offset = "0x600DEC")]
		public FsmBool isScrolling;

		[Token(Token = "0x40055C9")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600E3C", Offset = "0x600E3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600E3C", Offset = "0x600E3C")]
		public FsmGameObject lastPress;

		[Token(Token = "0x40055CA")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600E8C", Offset = "0x600E8C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600E8C", Offset = "0x600E8C")]
		public FsmGameObject pointerDrag;

		[Token(Token = "0x40055CB")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600EDC", Offset = "0x600EDC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600EDC", Offset = "0x600EDC")]
		public FsmGameObject pointerEnter;

		[Token(Token = "0x40055CC")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600F2C", Offset = "0x600F2C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600F2C", Offset = "0x600F2C")]
		public FsmInt pointerId;

		[Token(Token = "0x40055CD")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600F7C", Offset = "0x600F7C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600F7C", Offset = "0x600F7C")]
		public FsmGameObject pointerPress;

		[Token(Token = "0x40055CE")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600FCC", Offset = "0x600FCC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x600FCC", Offset = "0x600FCC")]
		public FsmVector2 position;

		[Token(Token = "0x40055CF")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60101C", Offset = "0x60101C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60101C", Offset = "0x60101C")]
		public FsmVector2 pressPosition;

		[Token(Token = "0x40055D0")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60106C", Offset = "0x60106C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60106C", Offset = "0x60106C")]
		public FsmGameObject rawPointerPress;

		[Token(Token = "0x40055D1")]
		[FieldOffset(Offset = "0xE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6010BC", Offset = "0x6010BC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6010BC", Offset = "0x6010BC")]
		public FsmVector2 scrollDelta;

		[Token(Token = "0x40055D2")]
		[FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60110C", Offset = "0x60110C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60110C", Offset = "0x60110C")]
		public FsmBool used;

		[Token(Token = "0x40055D3")]
		[FieldOffset(Offset = "0xF0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60115C", Offset = "0x60115C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60115C", Offset = "0x60115C")]
		public FsmBool useDragThreshold;

		[Token(Token = "0x40055D4")]
		[FieldOffset(Offset = "0xF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6011AC", Offset = "0x6011AC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6011AC", Offset = "0x6011AC")]
		public FsmVector3 worldNormal;

		[Token(Token = "0x40055D5")]
		[FieldOffset(Offset = "0x100")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6011FC", Offset = "0x6011FC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6011FC", Offset = "0x6011FC")]
		public FsmVector3 worldPosition;

		[Token(Token = "0x6006949")]
		[Address(RVA = "0x117A880", Offset = "0x117A880", VA = "0x117A880", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600694A")]
		[Address(RVA = "0x117A900", Offset = "0x117A900", VA = "0x117A900", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600694B")]
		[Address(RVA = "0x117AED8", Offset = "0x117AED8", VA = "0x117AED8")]
		public UiGetLastPointerDataInfo()
		{
		}
	}
}

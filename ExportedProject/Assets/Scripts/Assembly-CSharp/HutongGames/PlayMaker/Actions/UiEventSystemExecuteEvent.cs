using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011E7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA234", Offset = "0x5AA234")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA234", Offset = "0x5AA234")]
	public class UiEventSystemExecuteEvent : FsmStateAction
	{
		[Token(Token = "0x20011E8")]
		public enum EventHandlers
		{
			[Token(Token = "0x40055AE")]
			Submit = 0,
			[Token(Token = "0x40055AF")]
			beginDrag = 1,
			[Token(Token = "0x40055B0")]
			cancel = 2,
			[Token(Token = "0x40055B1")]
			deselectHandler = 3,
			[Token(Token = "0x40055B2")]
			dragHandler = 4,
			[Token(Token = "0x40055B3")]
			dropHandler = 5,
			[Token(Token = "0x40055B4")]
			endDragHandler = 6,
			[Token(Token = "0x40055B5")]
			initializePotentialDrag = 7,
			[Token(Token = "0x40055B6")]
			pointerClickHandler = 8,
			[Token(Token = "0x40055B7")]
			pointerDownHandler = 9,
			[Token(Token = "0x40055B8")]
			pointerEnterHandler = 10,
			[Token(Token = "0x40055B9")]
			pointerExitHandler = 11,
			[Token(Token = "0x40055BA")]
			pointerUpHandler = 12,
			[Token(Token = "0x40055BB")]
			scrollHandler = 13,
			[Token(Token = "0x40055BC")]
			submitHandler = 14,
			[Token(Token = "0x40055BD")]
			updateSelectedHandler = 15
		}

		[Token(Token = "0x40055A8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600994", Offset = "0x600994")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40055A9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6009E0", Offset = "0x6009E0")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x6009E0", Offset = "0x6009E0")]
		public FsmEnum eventHandler;

		[Token(Token = "0x40055AA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600A64", Offset = "0x600A64")]
		public FsmEvent success;

		[Token(Token = "0x40055AB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x600A9C", Offset = "0x600A9C")]
		public FsmEvent canNotHandleEvent;

		[Token(Token = "0x40055AC")]
		[FieldOffset(Offset = "0x70")]
		private GameObject go;

		[Token(Token = "0x6006945")]
		[Address(RVA = "0x1179220", Offset = "0x1179220", VA = "0x1179220", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006946")]
		[Address(RVA = "0x1179290", Offset = "0x1179290", VA = "0x1179290", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006947")]
		[Address(RVA = "0x11792E4", Offset = "0x11792E4", VA = "0x11792E4")]
		private bool ExecuteEvent()
		{
			return default(bool);
		}

		[Token(Token = "0x6006948")]
		[Address(RVA = "0x117A43C", Offset = "0x117A43C", VA = "0x117A43C")]
		public UiEventSystemExecuteEvent()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA694", Offset = "0x5AA694")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA694", Offset = "0x5AA694")]
	public class UiOnPointerDownEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055EC")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60187C", Offset = "0x60187C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60187C", Offset = "0x60187C")]
		public FsmEvent onPointerDownEvent;

		[Token(Token = "0x600697E")]
		[Address(RVA = "0xB9469C", Offset = "0xB9469C", VA = "0xB9469C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600697F")]
		[Address(RVA = "0xB946C4", Offset = "0xB946C4", VA = "0xB946C4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006980")]
		[Address(RVA = "0xB9475C", Offset = "0xB9475C", VA = "0xB9475C")]
		private void OnPointerDownDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006981")]
		[Address(RVA = "0xB94828", Offset = "0xB94828", VA = "0xB94828")]
		public UiOnPointerDownEvent()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011ED")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA3C4", Offset = "0x5AA3C4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA3C4", Offset = "0x5AA3C4")]
	public class UiOnBeginDragEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055E3")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6015AC", Offset = "0x6015AC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6015AC", Offset = "0x6015AC")]
		public FsmEvent onBeginDragEvent;

		[Token(Token = "0x600695A")]
		[Address(RVA = "0xB93884", Offset = "0xB93884", VA = "0xB93884", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600695B")]
		[Address(RVA = "0xB938AC", Offset = "0xB938AC", VA = "0xB938AC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600695C")]
		[Address(RVA = "0xB93944", Offset = "0xB93944", VA = "0xB93944")]
		private void OnBeginDragDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x600695D")]
		[Address(RVA = "0xB93A10", Offset = "0xB93A10", VA = "0xB93A10")]
		public UiOnBeginDragEvent()
		{
		}
	}
}

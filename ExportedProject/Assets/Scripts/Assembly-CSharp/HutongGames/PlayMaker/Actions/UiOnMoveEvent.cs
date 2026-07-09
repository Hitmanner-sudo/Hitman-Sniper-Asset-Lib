using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA5F4", Offset = "0x5AA5F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA5F4", Offset = "0x5AA5F4")]
	public class UiOnMoveEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055EA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6017DC", Offset = "0x6017DC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6017DC", Offset = "0x6017DC")]
		public FsmEvent onMoveEvent;

		[Token(Token = "0x6006976")]
		[Address(RVA = "0xB94374", Offset = "0xB94374", VA = "0xB94374", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006977")]
		[Address(RVA = "0xB9439C", Offset = "0xB9439C", VA = "0xB9439C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006978")]
		[Address(RVA = "0xB94434", Offset = "0xB94434", VA = "0xB94434")]
		private void OnMoveDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006979")]
		[Address(RVA = "0xB94500", Offset = "0xB94500", VA = "0xB94500")]
		public UiOnMoveEvent()
		{
		}
	}
}

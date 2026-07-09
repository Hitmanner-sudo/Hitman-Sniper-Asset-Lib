using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011EE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA414", Offset = "0x5AA414")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA414", Offset = "0x5AA414")]
	public class UiOnCancelEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055E4")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6015FC", Offset = "0x6015FC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6015FC", Offset = "0x6015FC")]
		public FsmEvent onCancelEvent;

		[Token(Token = "0x600695E")]
		[Address(RVA = "0xB93A18", Offset = "0xB93A18", VA = "0xB93A18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600695F")]
		[Address(RVA = "0xB93A24", Offset = "0xB93A24", VA = "0xB93A24", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006960")]
		[Address(RVA = "0xB93ABC", Offset = "0xB93ABC", VA = "0xB93ABC")]
		private void OnCancelDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006961")]
		[Address(RVA = "0xB93B88", Offset = "0xB93B88", VA = "0xB93B88")]
		public UiOnCancelEvent()
		{
		}
	}
}

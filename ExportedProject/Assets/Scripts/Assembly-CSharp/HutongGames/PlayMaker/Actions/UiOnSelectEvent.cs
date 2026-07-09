using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011FB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA824", Offset = "0x5AA824")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA824", Offset = "0x5AA824")]
	public class UiOnSelectEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055F1")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601A0C", Offset = "0x601A0C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601A0C", Offset = "0x601A0C")]
		public FsmEvent onSelectEvent;

		[Token(Token = "0x6006992")]
		[Address(RVA = "0xB94E80", Offset = "0xB94E80", VA = "0xB94E80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006993")]
		[Address(RVA = "0xB94EA8", Offset = "0xB94EA8", VA = "0xB94EA8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006994")]
		[Address(RVA = "0xB94F40", Offset = "0xB94F40", VA = "0xB94F40")]
		private void OnSelectDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006995")]
		[Address(RVA = "0xB9500C", Offset = "0xB9500C", VA = "0xB9500C")]
		public UiOnSelectEvent()
		{
		}
	}
}

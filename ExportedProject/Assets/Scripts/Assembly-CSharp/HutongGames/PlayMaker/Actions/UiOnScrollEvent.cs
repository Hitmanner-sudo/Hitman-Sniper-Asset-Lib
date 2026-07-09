using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011FA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA7D4", Offset = "0x5AA7D4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA7D4", Offset = "0x5AA7D4")]
	public class UiOnScrollEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055F0")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6019BC", Offset = "0x6019BC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6019BC", Offset = "0x6019BC")]
		public FsmEvent onScrollEvent;

		[Token(Token = "0x600698E")]
		[Address(RVA = "0xB94CEC", Offset = "0xB94CEC", VA = "0xB94CEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600698F")]
		[Address(RVA = "0xB94D14", Offset = "0xB94D14", VA = "0xB94D14", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006990")]
		[Address(RVA = "0xB94DAC", Offset = "0xB94DAC", VA = "0xB94DAC")]
		private void OnScrollDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006991")]
		[Address(RVA = "0xB94E78", Offset = "0xB94E78", VA = "0xB94E78")]
		public UiOnScrollEvent()
		{
		}
	}
}

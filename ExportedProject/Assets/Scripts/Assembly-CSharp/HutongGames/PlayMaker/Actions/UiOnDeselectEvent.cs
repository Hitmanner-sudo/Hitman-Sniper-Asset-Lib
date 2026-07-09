using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011EF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA464", Offset = "0x5AA464")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA464", Offset = "0x5AA464")]
	public class UiOnDeselectEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055E5")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60164C", Offset = "0x60164C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60164C", Offset = "0x60164C")]
		public FsmEvent onDeselectEvent;

		[Token(Token = "0x6006962")]
		[Address(RVA = "0xB93B90", Offset = "0xB93B90", VA = "0xB93B90", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006963")]
		[Address(RVA = "0xB93BB8", Offset = "0xB93BB8", VA = "0xB93BB8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006964")]
		[Address(RVA = "0xB93C50", Offset = "0xB93C50", VA = "0xB93C50")]
		private void OnDeselectDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006965")]
		[Address(RVA = "0xB93D1C", Offset = "0xB93D1C", VA = "0xB93D1C")]
		public UiOnDeselectEvent()
		{
		}
	}
}

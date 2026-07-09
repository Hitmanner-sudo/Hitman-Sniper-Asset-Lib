using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA644", Offset = "0x5AA644")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA644", Offset = "0x5AA644")]
	public class UiOnPointerClickEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055EB")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60182C", Offset = "0x60182C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60182C", Offset = "0x60182C")]
		public FsmEvent onPointerClickEvent;

		[Token(Token = "0x600697A")]
		[Address(RVA = "0xB94508", Offset = "0xB94508", VA = "0xB94508", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600697B")]
		[Address(RVA = "0xB94530", Offset = "0xB94530", VA = "0xB94530", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600697C")]
		[Address(RVA = "0xB945C8", Offset = "0xB945C8", VA = "0xB945C8")]
		private void OnPointerClickDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x600697D")]
		[Address(RVA = "0xB94694", Offset = "0xB94694", VA = "0xB94694")]
		public UiOnPointerClickEvent()
		{
		}
	}
}

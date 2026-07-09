using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA734", Offset = "0x5AA734")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA734", Offset = "0x5AA734")]
	public class UiOnPointerExitEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055EE")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60191C", Offset = "0x60191C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60191C", Offset = "0x60191C")]
		public FsmEvent onPointerExitEvent;

		[Token(Token = "0x6006986")]
		[Address(RVA = "0xB949C4", Offset = "0xB949C4", VA = "0xB949C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006987")]
		[Address(RVA = "0xB949EC", Offset = "0xB949EC", VA = "0xB949EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006988")]
		[Address(RVA = "0xB94A84", Offset = "0xB94A84", VA = "0xB94A84")]
		private void OnPointerExitDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006989")]
		[Address(RVA = "0xB94B50", Offset = "0xB94B50", VA = "0xB94B50")]
		public UiOnPointerExitEvent()
		{
		}
	}
}

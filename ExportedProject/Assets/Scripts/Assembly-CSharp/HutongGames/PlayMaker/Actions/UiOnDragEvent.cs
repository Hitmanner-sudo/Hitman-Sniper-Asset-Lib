using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA4B4", Offset = "0x5AA4B4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA4B4", Offset = "0x5AA4B4")]
	public class UiOnDragEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055E6")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60169C", Offset = "0x60169C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60169C", Offset = "0x60169C")]
		public FsmEvent onDragEvent;

		[Token(Token = "0x6006966")]
		[Address(RVA = "0xB93D24", Offset = "0xB93D24", VA = "0xB93D24", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006967")]
		[Address(RVA = "0xB93D4C", Offset = "0xB93D4C", VA = "0xB93D4C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006968")]
		[Address(RVA = "0xB93DE4", Offset = "0xB93DE4", VA = "0xB93DE4")]
		private void OnDragDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006969")]
		[Address(RVA = "0xB93EB0", Offset = "0xB93EB0", VA = "0xB93EB0")]
		public UiOnDragEvent()
		{
		}
	}
}

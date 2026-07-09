using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA784", Offset = "0x5AA784")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA784", Offset = "0x5AA784")]
	public class UiOnPointerUpEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055EF")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60196C", Offset = "0x60196C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60196C", Offset = "0x60196C")]
		public FsmEvent onPointerUpEvent;

		[Token(Token = "0x600698A")]
		[Address(RVA = "0xB94B58", Offset = "0xB94B58", VA = "0xB94B58", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600698B")]
		[Address(RVA = "0xB94B80", Offset = "0xB94B80", VA = "0xB94B80", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600698C")]
		[Address(RVA = "0xB94C18", Offset = "0xB94C18", VA = "0xB94C18")]
		private void OnPointerUpDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x600698D")]
		[Address(RVA = "0xB94CE4", Offset = "0xB94CE4", VA = "0xB94CE4")]
		public UiOnPointerUpEvent()
		{
		}
	}
}

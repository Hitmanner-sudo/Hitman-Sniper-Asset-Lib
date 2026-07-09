using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA5A4", Offset = "0x5AA5A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA5A4", Offset = "0x5AA5A4")]
	public class UiOnInitializePotentialDragEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055E9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60178C", Offset = "0x60178C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60178C", Offset = "0x60178C")]
		public FsmEvent onInitializePotentialDragEvent;

		[Token(Token = "0x6006972")]
		[Address(RVA = "0xB941E0", Offset = "0xB941E0", VA = "0xB941E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006973")]
		[Address(RVA = "0xB94208", Offset = "0xB94208", VA = "0xB94208", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006974")]
		[Address(RVA = "0xB942A0", Offset = "0xB942A0", VA = "0xB942A0")]
		private void OnInitializePotentialDragDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006975")]
		[Address(RVA = "0xB9436C", Offset = "0xB9436C", VA = "0xB9436C")]
		public UiOnInitializePotentialDragEvent()
		{
		}
	}
}

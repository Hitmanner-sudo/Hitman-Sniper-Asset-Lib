using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA504", Offset = "0x5AA504")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA504", Offset = "0x5AA504")]
	public class UiOnDropEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055E7")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6016EC", Offset = "0x6016EC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6016EC", Offset = "0x6016EC")]
		public FsmEvent onDropEvent;

		[Token(Token = "0x600696A")]
		[Address(RVA = "0xB93EB8", Offset = "0xB93EB8", VA = "0xB93EB8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600696B")]
		[Address(RVA = "0xB93EE0", Offset = "0xB93EE0", VA = "0xB93EE0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600696C")]
		[Address(RVA = "0xB93F78", Offset = "0xB93F78", VA = "0xB93F78")]
		private void OnDropDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x600696D")]
		[Address(RVA = "0xB94044", Offset = "0xB94044", VA = "0xB94044")]
		public UiOnDropEvent()
		{
		}
	}
}

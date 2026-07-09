using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011FC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA874", Offset = "0x5AA874")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA874", Offset = "0x5AA874")]
	public class UiOnSubmitEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055F2")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601A5C", Offset = "0x601A5C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601A5C", Offset = "0x601A5C")]
		public FsmEvent onSubmitEvent;

		[Token(Token = "0x6006996")]
		[Address(RVA = "0xB95014", Offset = "0xB95014", VA = "0xB95014", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006997")]
		[Address(RVA = "0xB9503C", Offset = "0xB9503C", VA = "0xB9503C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006998")]
		[Address(RVA = "0xB950D4", Offset = "0xB950D4", VA = "0xB950D4")]
		private void OnSubmitDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006999")]
		[Address(RVA = "0xB951A0", Offset = "0xB951A0", VA = "0xB951A0")]
		public UiOnSubmitEvent()
		{
		}
	}
}

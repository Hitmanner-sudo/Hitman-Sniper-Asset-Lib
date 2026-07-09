using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA554", Offset = "0x5AA554")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA554", Offset = "0x5AA554")]
	public class UiOnEndDragEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055E8")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60173C", Offset = "0x60173C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60173C", Offset = "0x60173C")]
		public FsmEvent onEndDragEvent;

		[Token(Token = "0x600696E")]
		[Address(RVA = "0xB9404C", Offset = "0xB9404C", VA = "0xB9404C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600696F")]
		[Address(RVA = "0xB94074", Offset = "0xB94074", VA = "0xB94074", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006970")]
		[Address(RVA = "0xB9410C", Offset = "0xB9410C", VA = "0xB9410C")]
		private void OnEndDragDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006971")]
		[Address(RVA = "0xB941D8", Offset = "0xB941D8", VA = "0xB941D8")]
		public UiOnEndDragEvent()
		{
		}
	}
}

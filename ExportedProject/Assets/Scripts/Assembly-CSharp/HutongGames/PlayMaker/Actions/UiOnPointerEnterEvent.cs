using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011F7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA6E4", Offset = "0x5AA6E4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA6E4", Offset = "0x5AA6E4")]
	public class UiOnPointerEnterEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055ED")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6018CC", Offset = "0x6018CC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6018CC", Offset = "0x6018CC")]
		public FsmEvent onPointerEnterEvent;

		[Token(Token = "0x6006982")]
		[Address(RVA = "0xB94830", Offset = "0xB94830", VA = "0xB94830", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006983")]
		[Address(RVA = "0xB94858", Offset = "0xB94858", VA = "0xB94858", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006984")]
		[Address(RVA = "0xB948F0", Offset = "0xB948F0", VA = "0xB948F0")]
		private void OnPointerEnterDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x6006985")]
		[Address(RVA = "0xB949BC", Offset = "0xB949BC", VA = "0xB949BC")]
		public UiOnPointerEnterEvent()
		{
		}
	}
}

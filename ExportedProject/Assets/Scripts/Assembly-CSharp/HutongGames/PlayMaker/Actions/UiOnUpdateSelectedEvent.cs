using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011FD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA8C4", Offset = "0x5AA8C4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA8C4", Offset = "0x5AA8C4")]
	public class UiOnUpdateSelectedEvent : EventTriggerActionBase
	{
		[Token(Token = "0x40055F3")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601AAC", Offset = "0x601AAC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601AAC", Offset = "0x601AAC")]
		public FsmEvent onUpdateSelectedEvent;

		[Token(Token = "0x600699A")]
		[Address(RVA = "0xB951A8", Offset = "0xB951A8", VA = "0xB951A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600699B")]
		[Address(RVA = "0xB951D0", Offset = "0xB951D0", VA = "0xB951D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600699C")]
		[Address(RVA = "0xB95268", Offset = "0xB95268", VA = "0xB95268")]
		private void OnUpdateSelectedDelegate(BaseEventData data)
		{
		}

		[Token(Token = "0x600699D")]
		[Address(RVA = "0xB95334", Offset = "0xB95334", VA = "0xB95334")]
		public UiOnUpdateSelectedEvent()
		{
		}
	}
}

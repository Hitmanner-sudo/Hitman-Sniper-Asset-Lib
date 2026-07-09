using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001204")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAAF4", Offset = "0x5AAAF4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAAF4", Offset = "0x5AAAF4")]
	public class UiGetIsInteractable : ComponentAction<Selectable>
	{
		[Token(Token = "0x4005626")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602A4C", Offset = "0x602A4C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x602A4C", Offset = "0x602A4C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005627")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602AE0", Offset = "0x602AE0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x602AE0", Offset = "0x602AE0")]
		public FsmBool isInteractable;

		[Token(Token = "0x4005628")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602B30", Offset = "0x602B30")]
		public FsmEvent isInteractableEvent;

		[Token(Token = "0x4005629")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602B68", Offset = "0x602B68")]
		public FsmEvent isNotInteractableEvent;

		[Token(Token = "0x400562A")]
		[FieldOffset(Offset = "0x88")]
		private Selectable selectable;

		[Token(Token = "0x60069BB")]
		[Address(RVA = "0x117A6CC", Offset = "0x117A6CC", VA = "0x117A6CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069BC")]
		[Address(RVA = "0x117A6DC", Offset = "0x117A6DC", VA = "0x117A6DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069BD")]
		[Address(RVA = "0x117A764", Offset = "0x117A764", VA = "0x117A764")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x60069BE")]
		[Address(RVA = "0x117A834", Offset = "0x117A834", VA = "0x117A834")]
		public UiGetIsInteractable()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200124F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC224", Offset = "0x5AC224")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC224", Offset = "0x5AC224")]
	public class UiToggleOnValueChangedEvent : ComponentAction<Toggle>
	{
		[Token(Token = "0x40057BA")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x608DE8", Offset = "0x608DE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608DE8", Offset = "0x608DE8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40057BB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608E7C", Offset = "0x608E7C")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x40057BC")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608EB4", Offset = "0x608EB4")]
		public FsmEvent sendEvent;

		[Token(Token = "0x40057BD")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x608EEC", Offset = "0x608EEC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x608EEC", Offset = "0x608EEC")]
		public FsmBool value;

		[Token(Token = "0x40057BE")]
		[FieldOffset(Offset = "0x88")]
		private Toggle toggle;

		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0xB99FE8", Offset = "0xB99FE8", VA = "0xB99FE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B30")]
		[Address(RVA = "0xB99FF8", Offset = "0xB99FF8", VA = "0xB99FF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B31")]
		[Address(RVA = "0xB9A258", Offset = "0xB9A258", VA = "0xB9A258", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006B32")]
		[Address(RVA = "0xB9A370", Offset = "0xB9A370", VA = "0xB9A370")]
		public void DoOnValueChanged(bool _value)
		{
		}

		[Token(Token = "0x6006B33")]
		[Address(RVA = "0xB9A420", Offset = "0xB9A420", VA = "0xB9A420")]
		public UiToggleOnValueChangedEvent()
		{
		}
	}
}

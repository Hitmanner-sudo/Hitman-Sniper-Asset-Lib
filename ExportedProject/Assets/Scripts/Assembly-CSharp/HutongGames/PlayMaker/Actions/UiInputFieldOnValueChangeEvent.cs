using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200122C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB734", Offset = "0x5AB734")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB734", Offset = "0x5AB734")]
	public class UiInputFieldOnValueChangeEvent : ComponentAction<InputField>
	{
		[Token(Token = "0x40056FE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605FE0", Offset = "0x605FE0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605FE0", Offset = "0x605FE0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056FF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606074", Offset = "0x606074")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x4005700")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6060AC", Offset = "0x6060AC")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4005701")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6060E4", Offset = "0x6060E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6060E4", Offset = "0x6060E4")]
		public FsmString text;

		[Token(Token = "0x4005702")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x6006A73")]
		[Address(RVA = "0xB90A48", Offset = "0xB90A48", VA = "0xB90A48", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A74")]
		[Address(RVA = "0xB90A58", Offset = "0xB90A58", VA = "0xB90A58", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A75")]
		[Address(RVA = "0xB90BB0", Offset = "0xB90BB0", VA = "0xB90BB0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A76")]
		[Address(RVA = "0xB90CC8", Offset = "0xB90CC8", VA = "0xB90CC8")]
		public void DoOnValueChange(string value)
		{
		}

		[Token(Token = "0x6006A77")]
		[Address(RVA = "0xB90D74", Offset = "0xB90D74", VA = "0xB90D74")]
		public UiInputFieldOnValueChangeEvent()
		{
		}
	}
}

using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200122B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB6E4", Offset = "0x5AB6E4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB6E4", Offset = "0x5AB6E4")]
	public class UiInputFieldOnSubmitEvent : ComponentAction<InputField>
	{
		[Token(Token = "0x40056F9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605E8C", Offset = "0x605E8C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605E8C", Offset = "0x605E8C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056FA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605F20", Offset = "0x605F20")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x40056FB")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605F58", Offset = "0x605F58")]
		public FsmEvent sendEvent;

		[Token(Token = "0x40056FC")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605F90", Offset = "0x605F90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605F90", Offset = "0x605F90")]
		public FsmString text;

		[Token(Token = "0x40056FD")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x6006A6E")]
		[Address(RVA = "0xB906A4", Offset = "0xB906A4", VA = "0xB906A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A6F")]
		[Address(RVA = "0xB906B4", Offset = "0xB906B4", VA = "0xB906B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A70")]
		[Address(RVA = "0xB9080C", Offset = "0xB9080C", VA = "0xB9080C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A71")]
		[Address(RVA = "0xB90924", Offset = "0xB90924", VA = "0xB90924")]
		public void DoOnEndEdit(string value)
		{
		}

		[Token(Token = "0x6006A72")]
		[Address(RVA = "0xB909FC", Offset = "0xB909FC", VA = "0xB909FC")]
		public UiInputFieldOnSubmitEvent()
		{
		}
	}
}

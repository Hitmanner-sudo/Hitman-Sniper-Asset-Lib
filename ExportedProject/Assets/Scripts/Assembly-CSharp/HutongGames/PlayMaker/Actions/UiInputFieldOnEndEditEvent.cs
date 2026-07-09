using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200122A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB694", Offset = "0x5AB694")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB694", Offset = "0x5AB694")]
	public class UiInputFieldOnEndEditEvent : ComponentAction<InputField>
	{
		[Token(Token = "0x40056F3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605CE8", Offset = "0x605CE8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605CE8", Offset = "0x605CE8")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056F4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605D7C", Offset = "0x605D7C")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x40056F5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605DB4", Offset = "0x605DB4")]
		public FsmEvent sendEvent;

		[Token(Token = "0x40056F6")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605DEC", Offset = "0x605DEC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605DEC", Offset = "0x605DEC")]
		public FsmString text;

		[Token(Token = "0x40056F7")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605E3C", Offset = "0x605E3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605E3C", Offset = "0x605E3C")]
		public FsmBool wasCanceled;

		[Token(Token = "0x40056F8")]
		[FieldOffset(Offset = "0x90")]
		private InputField inputField;

		[Token(Token = "0x6006A69")]
		[Address(RVA = "0xB902EC", Offset = "0xB902EC", VA = "0xB902EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A6A")]
		[Address(RVA = "0xB902FC", Offset = "0xB902FC", VA = "0xB902FC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A6B")]
		[Address(RVA = "0xB90454", Offset = "0xB90454", VA = "0xB90454", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A6C")]
		[Address(RVA = "0xB9056C", Offset = "0xB9056C", VA = "0xB9056C")]
		public void DoOnEndEdit(string value)
		{
		}

		[Token(Token = "0x6006A6D")]
		[Address(RVA = "0xB90658", Offset = "0xB90658", VA = "0xB90658")]
		public UiInputFieldOnEndEditEvent()
		{
		}
	}
}

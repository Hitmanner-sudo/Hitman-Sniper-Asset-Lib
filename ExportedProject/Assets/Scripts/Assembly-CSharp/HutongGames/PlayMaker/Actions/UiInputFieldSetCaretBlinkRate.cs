using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001233")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB964", Offset = "0x5AB964")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB964", Offset = "0x5AB964")]
	public class UiInputFieldSetCaretBlinkRate : ComponentAction<InputField>
	{
		[Token(Token = "0x4005725")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6068CC", Offset = "0x6068CC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6068CC", Offset = "0x6068CC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005726")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606960", Offset = "0x606960")]
		public FsmInt caretBlinkRate;

		[Token(Token = "0x4005727")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6069AC", Offset = "0x6069AC")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005728")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6069E4", Offset = "0x6069E4")]
		public bool everyFrame;

		[Token(Token = "0x4005729")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x400572A")]
		[FieldOffset(Offset = "0x90")]
		private float originalValue;

		[Token(Token = "0x6006A9A")]
		[Address(RVA = "0xB9111C", Offset = "0xB9111C", VA = "0xB9111C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A9B")]
		[Address(RVA = "0xB9112C", Offset = "0xB9112C", VA = "0xB9112C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A9C")]
		[Address(RVA = "0xB91288", Offset = "0xB91288", VA = "0xB91288", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A9D")]
		[Address(RVA = "0xB911E0", Offset = "0xB911E0", VA = "0xB911E0")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006A9E")]
		[Address(RVA = "0xB9128C", Offset = "0xB9128C", VA = "0xB9128C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A9F")]
		[Address(RVA = "0xB91334", Offset = "0xB91334", VA = "0xB91334")]
		public UiInputFieldSetCaretBlinkRate()
		{
		}
	}
}

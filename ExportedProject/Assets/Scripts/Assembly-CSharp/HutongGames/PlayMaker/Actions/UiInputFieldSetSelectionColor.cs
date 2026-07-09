using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001231")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB8C4", Offset = "0x5AB8C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB8C4", Offset = "0x5AB8C4")]
	public class UiInputFieldSetSelectionColor : ComponentAction<InputField>
	{
		[Token(Token = "0x4005719")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606628", Offset = "0x606628")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606628", Offset = "0x606628")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400571A")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6066BC", Offset = "0x6066BC")]
		public FsmColor selectionColor;

		[Token(Token = "0x400571B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606708", Offset = "0x606708")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400571C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606740", Offset = "0x606740")]
		public bool everyFrame;

		[Token(Token = "0x400571D")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x400571E")]
		[FieldOffset(Offset = "0x90")]
		private Color originalValue;

		[Token(Token = "0x6006A8E")]
		[Address(RVA = "0xB91AF0", Offset = "0xB91AF0", VA = "0xB91AF0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A8F")]
		[Address(RVA = "0xB91B00", Offset = "0xB91B00", VA = "0xB91B00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A90")]
		[Address(RVA = "0xB91C58", Offset = "0xB91C58", VA = "0xB91C58", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A91")]
		[Address(RVA = "0xB91BB8", Offset = "0xB91BB8", VA = "0xB91BB8")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006A92")]
		[Address(RVA = "0xB91C5C", Offset = "0xB91C5C", VA = "0xB91C5C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A93")]
		[Address(RVA = "0xB91D08", Offset = "0xB91D08", VA = "0xB91D08")]
		public UiInputFieldSetSelectionColor()
		{
		}
	}
}

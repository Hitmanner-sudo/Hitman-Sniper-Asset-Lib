using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001232")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB914", Offset = "0x5AB914")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB914", Offset = "0x5AB914")]
	public class UiInputFieldSetText : ComponentAction<InputField>
	{
		[Token(Token = "0x400571F")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606778", Offset = "0x606778")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606778", Offset = "0x606778")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005720")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60680C", Offset = "0x60680C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60680C", Offset = "0x60680C")]
		public FsmString text;

		[Token(Token = "0x4005721")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60685C", Offset = "0x60685C")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005722")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606894", Offset = "0x606894")]
		public bool everyFrame;

		[Token(Token = "0x4005723")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x4005724")]
		[FieldOffset(Offset = "0x90")]
		private string originalString;

		[Token(Token = "0x6006A94")]
		[Address(RVA = "0xB91D54", Offset = "0xB91D54", VA = "0xB91D54", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A95")]
		[Address(RVA = "0xB91D64", Offset = "0xB91D64", VA = "0xB91D64", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A96")]
		[Address(RVA = "0xB91EC0", Offset = "0xB91EC0", VA = "0xB91EC0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A97")]
		[Address(RVA = "0xB91E18", Offset = "0xB91E18", VA = "0xB91E18")]
		private void DoSetTextValue()
		{
		}

		[Token(Token = "0x6006A98")]
		[Address(RVA = "0xB91EC4", Offset = "0xB91EC4", VA = "0xB91EC4", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A99")]
		[Address(RVA = "0xB91F6C", Offset = "0xB91F6C", VA = "0xB91F6C")]
		public UiInputFieldSetText()
		{
		}
	}
}

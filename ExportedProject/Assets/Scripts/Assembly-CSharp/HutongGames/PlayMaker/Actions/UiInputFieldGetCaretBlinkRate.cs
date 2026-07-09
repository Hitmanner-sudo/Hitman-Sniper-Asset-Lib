using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200121E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB2D4", Offset = "0x5AB2D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB2D4", Offset = "0x5AB2D4")]
	public class UiInputFieldGetCaretBlinkRate : ComponentAction<InputField>
	{
		[Token(Token = "0x40056B4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604CD0", Offset = "0x604CD0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604CD0", Offset = "0x604CD0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056B5")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x604D64", Offset = "0x604D64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604D64", Offset = "0x604D64")]
		public FsmFloat caretBlinkRate;

		[Token(Token = "0x40056B6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604DC4", Offset = "0x604DC4")]
		public bool everyFrame;

		[Token(Token = "0x40056B7")]
		[FieldOffset(Offset = "0x80")]
		private InputField inputField;

		[Token(Token = "0x6006A33")]
		[Address(RVA = "0xB8EE58", Offset = "0xB8EE58", VA = "0xB8EE58", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A34")]
		[Address(RVA = "0xB8EE64", Offset = "0xB8EE64", VA = "0xB8EE64", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A35")]
		[Address(RVA = "0xB8EF90", Offset = "0xB8EF90", VA = "0xB8EF90", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006A36")]
		[Address(RVA = "0xB8EF00", Offset = "0xB8EF00", VA = "0xB8EF00")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006A37")]
		[Address(RVA = "0xB8EF94", Offset = "0xB8EF94", VA = "0xB8EF94")]
		public UiInputFieldGetCaretBlinkRate()
		{
		}
	}
}

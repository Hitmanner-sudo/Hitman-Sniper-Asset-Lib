using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001228")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB5F4", Offset = "0x5AB5F4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB5F4", Offset = "0x5AB5F4")]
	public class UiInputFieldMoveCaretToTextEnd : ComponentAction<InputField>
	{
		[Token(Token = "0x40056ED")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605B50", Offset = "0x605B50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605B50", Offset = "0x605B50")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056EE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605BE4", Offset = "0x605BE4")]
		public FsmBool shift;

		[Token(Token = "0x40056EF")]
		[FieldOffset(Offset = "0x78")]
		private InputField inputField;

		[Token(Token = "0x6006A61")]
		[Address(RVA = "0xB8FF94", Offset = "0xB8FF94", VA = "0xB8FF94", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A62")]
		[Address(RVA = "0xB8FFC4", Offset = "0xB8FFC4", VA = "0xB8FFC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A63")]
		[Address(RVA = "0xB9004C", Offset = "0xB9004C", VA = "0xB9004C")]
		private void DoAction()
		{
		}

		[Token(Token = "0x6006A64")]
		[Address(RVA = "0xB900F4", Offset = "0xB900F4", VA = "0xB900F4")]
		public UiInputFieldMoveCaretToTextEnd()
		{
		}
	}
}

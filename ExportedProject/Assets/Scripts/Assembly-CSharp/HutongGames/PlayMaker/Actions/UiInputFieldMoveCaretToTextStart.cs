using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001229")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB644", Offset = "0x5AB644")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB644", Offset = "0x5AB644")]
	public class UiInputFieldMoveCaretToTextStart : ComponentAction<InputField>
	{
		[Token(Token = "0x40056F0")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605C1C", Offset = "0x605C1C")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x605C1C", Offset = "0x605C1C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056F1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605CB0", Offset = "0x605CB0")]
		public FsmBool shift;

		[Token(Token = "0x40056F2")]
		[FieldOffset(Offset = "0x78")]
		private InputField inputField;

		[Token(Token = "0x6006A65")]
		[Address(RVA = "0xB90140", Offset = "0xB90140", VA = "0xB90140", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A66")]
		[Address(RVA = "0xB90170", Offset = "0xB90170", VA = "0xB90170", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A67")]
		[Address(RVA = "0xB901F8", Offset = "0xB901F8", VA = "0xB901F8")]
		private void DoAction()
		{
		}

		[Token(Token = "0x6006A68")]
		[Address(RVA = "0xB902A0", Offset = "0xB902A0", VA = "0xB902A0")]
		public UiInputFieldMoveCaretToTextStart()
		{
		}
	}
}

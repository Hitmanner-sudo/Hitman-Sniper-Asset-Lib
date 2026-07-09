using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200122D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB784", Offset = "0x5AB784")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB784", Offset = "0x5AB784")]
	public class UiInputFieldSetAsterixChar : ComponentAction<InputField>
	{
		[Token(Token = "0x4005703")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606134", Offset = "0x606134")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x606134", Offset = "0x606134")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005704")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6061C8", Offset = "0x6061C8")]
		public FsmString asterixChar;

		[Token(Token = "0x4005705")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x606214", Offset = "0x606214")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005706")]
		[FieldOffset(Offset = "0x80")]
		private InputField inputField;

		[Token(Token = "0x4005707")]
		[FieldOffset(Offset = "0x88")]
		private char originalValue;

		[Token(Token = "0x4005708")]
		[FieldOffset(Offset = "0x0")]
		private static char __char__;

		[Token(Token = "0x6006A78")]
		[Address(RVA = "0xB90DC0", Offset = "0xB90DC0", VA = "0xB90DC0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A79")]
		[Address(RVA = "0xB90E18", Offset = "0xB90E18", VA = "0xB90E18", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A7A")]
		[Address(RVA = "0xB90EB8", Offset = "0xB90EB8", VA = "0xB90EB8")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006A7B")]
		[Address(RVA = "0xB90FD8", Offset = "0xB90FD8", VA = "0xB90FD8", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A7C")]
		[Address(RVA = "0xB91080", Offset = "0xB91080", VA = "0xB91080")]
		public UiInputFieldSetAsterixChar()
		{
		}
	}
}

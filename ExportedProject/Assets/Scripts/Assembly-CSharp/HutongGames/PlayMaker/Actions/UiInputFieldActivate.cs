using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200121C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB234", Offset = "0x5AB234")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB234", Offset = "0x5AB234")]
	public class UiInputFieldActivate : ComponentAction<InputField>
	{
		[Token(Token = "0x40056AE")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604B38", Offset = "0x604B38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604B38", Offset = "0x604B38")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056AF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604BCC", Offset = "0x604BCC")]
		public FsmBool deactivateOnExit;

		[Token(Token = "0x40056B0")]
		[FieldOffset(Offset = "0x78")]
		private InputField inputField;

		[Token(Token = "0x6006A29")]
		[Address(RVA = "0xB8EA38", Offset = "0xB8EA38", VA = "0xB8EA38", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A2A")]
		[Address(RVA = "0xB8EA40", Offset = "0xB8EA40", VA = "0xB8EA40", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A2B")]
		[Address(RVA = "0xB8EAC8", Offset = "0xB8EAC8", VA = "0xB8EAC8")]
		private void DoAction()
		{
		}

		[Token(Token = "0x6006A2C")]
		[Address(RVA = "0xB8EB58", Offset = "0xB8EB58", VA = "0xB8EB58", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A2D")]
		[Address(RVA = "0xB8EBFC", Offset = "0xB8EBFC", VA = "0xB8EBFC")]
		public UiInputFieldActivate()
		{
		}
	}
}

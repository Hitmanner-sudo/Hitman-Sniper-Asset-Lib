using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200121D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB284", Offset = "0x5AB284")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB284", Offset = "0x5AB284")]
	public class UiInputFieldDeactivate : ComponentAction<InputField>
	{
		[Token(Token = "0x40056B1")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x604C04", Offset = "0x604C04")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604C04", Offset = "0x604C04")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056B2")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x604C98", Offset = "0x604C98")]
		public FsmBool activateOnExit;

		[Token(Token = "0x40056B3")]
		[FieldOffset(Offset = "0x78")]
		private InputField inputField;

		[Token(Token = "0x6006A2E")]
		[Address(RVA = "0xB8EC48", Offset = "0xB8EC48", VA = "0xB8EC48", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A2F")]
		[Address(RVA = "0xB8EC50", Offset = "0xB8EC50", VA = "0xB8EC50", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A30")]
		[Address(RVA = "0xB8ECD8", Offset = "0xB8ECD8", VA = "0xB8ECD8")]
		private void DoAction()
		{
		}

		[Token(Token = "0x6006A31")]
		[Address(RVA = "0xB8ED68", Offset = "0xB8ED68", VA = "0xB8ED68", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006A32")]
		[Address(RVA = "0xB8EE0C", Offset = "0xB8EE0C", VA = "0xB8EE0C")]
		public UiInputFieldDeactivate()
		{
		}
	}
}

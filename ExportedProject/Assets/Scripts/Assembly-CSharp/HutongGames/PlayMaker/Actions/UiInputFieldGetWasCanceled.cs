using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001227")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB5A4", Offset = "0x5AB5A4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB5A4", Offset = "0x5AB5A4")]
	public class UiInputFieldGetWasCanceled : ComponentAction<InputField>
	{
		[Token(Token = "0x40056E8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6059FC", Offset = "0x6059FC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6059FC", Offset = "0x6059FC")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056E9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605A90", Offset = "0x605A90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605A90", Offset = "0x605A90")]
		public FsmBool wasCanceled;

		[Token(Token = "0x40056EA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605AE0", Offset = "0x605AE0")]
		public FsmEvent wasCanceledEvent;

		[Token(Token = "0x40056EB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605B18", Offset = "0x605B18")]
		public FsmEvent wasNotCanceledEvent;

		[Token(Token = "0x40056EC")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x6006A5D")]
		[Address(RVA = "0xB8FDEC", Offset = "0xB8FDEC", VA = "0xB8FDEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A5E")]
		[Address(RVA = "0xB8FDF8", Offset = "0xB8FDF8", VA = "0xB8FDF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A5F")]
		[Address(RVA = "0xB8FE80", Offset = "0xB8FE80", VA = "0xB8FE80")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006A60")]
		[Address(RVA = "0xB8FF48", Offset = "0xB8FF48", VA = "0xB8FF48")]
		public UiInputFieldGetWasCanceled()
		{
		}
	}
}

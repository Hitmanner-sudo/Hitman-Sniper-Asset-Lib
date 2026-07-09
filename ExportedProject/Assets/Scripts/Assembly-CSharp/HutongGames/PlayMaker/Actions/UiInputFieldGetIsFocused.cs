using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001221")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AB3C4", Offset = "0x5AB3C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AB3C4", Offset = "0x5AB3C4")]
	public class UiInputFieldGetIsFocused : ComponentAction<InputField>
	{
		[Token(Token = "0x40056C3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6050EC", Offset = "0x6050EC")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6050EC", Offset = "0x6050EC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40056C4")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x605180", Offset = "0x605180")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605180", Offset = "0x605180")]
		public FsmBool isFocused;

		[Token(Token = "0x40056C5")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6051D0", Offset = "0x6051D0")]
		public FsmEvent isfocusedEvent;

		[Token(Token = "0x40056C6")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x605208", Offset = "0x605208")]
		public FsmEvent isNotFocusedEvent;

		[Token(Token = "0x40056C7")]
		[FieldOffset(Offset = "0x88")]
		private InputField inputField;

		[Token(Token = "0x6006A41")]
		[Address(RVA = "0xB8F358", Offset = "0xB8F358", VA = "0xB8F358", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006A42")]
		[Address(RVA = "0xB8F364", Offset = "0xB8F364", VA = "0xB8F364", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006A43")]
		[Address(RVA = "0xB8F3EC", Offset = "0xB8F3EC", VA = "0xB8F3EC")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x6006A44")]
		[Address(RVA = "0xB8F4B4", Offset = "0xB8F4B4", VA = "0xB8F4B4")]
		public UiInputFieldGetIsFocused()
		{
		}
	}
}
